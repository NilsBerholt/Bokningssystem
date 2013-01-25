using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bokningssystem
{
    public partial class FormBoka : Form
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        private kund anvandare;
        private bool kundHarReggadBil;
        private string uppdatera = null;

        public void DoljAndringar()
        {
            maskedTextBoxNytt.Hide();
            maskedTextBoxNytt.Text = "";
            maskedTextBoxBekräfta.Hide();
            maskedTextBoxBekräfta.Text = "";
            maskedTextBoxGamla.Hide();
            maskedTextBoxGamla.Text = "";
            maskedTextBoxBekLosen.Hide();
            maskedTextBoxBekLosen.Text = "";
            labelNytt.Hide();
            labelGamla.Hide();
            labelBekräfta.Hide();
            labelBekLosen.Hide();
            buttonRedigera.Hide();
        }

        public FormBoka(kund anvandare)
        {
            InitializeComponent();
            SqlCeDatabase db = new SqlCeDatabase();
            this.anvandare = anvandare;

            labelNamn.Text = anvandare.GetNamn();
            labelEmail.Text = anvandare.GetEmail();
            labelTfn.Text = anvandare.GetTfn();
            labelAdress.Text = anvandare.GetAdress();
            label7.Text = "";
            DoljAndringar();

            string regQuery = "SELECT reg FROM fordon WHERE agare='?x?'";
            string[] args = { anvandare.GetEmail() };

            string[] queryResultat = db.query(regQuery, args);
            if (queryResultat[0] == "1")
            {
                string[] ny = { "Ny bil" };
                string[] fetchResultat = db.fetchAll();
                if (fetchResultat[0] != "fel")
                {
                    List<string> kundBilar = fetchResultat.ToList();
                    kundBilar.Add("Ny bil...");
                    kundHarReggadBil = true;
                    comboBoxReg.DataSource = kundBilar;
                }
                else
                {
                    kundHarReggadBil = false;
                    comboBoxReg.DataSource = ny;
                }
            }

            splitContainer1.Panel2Collapsed = true;
            richTextBoxBokningMeny.Text = "Tryck på Ny bokning för att göra en ny bokning.\nTryck på Mina Bokningar för att se vad du har bokat och när.";
            if (DEBUG)
            {
                richTextBoxBokningMeny.Text += "\nNamn: " + anvandare.GetNamn();
                richTextBoxBokningMeny.Text += "\nEmail: " + anvandare.GetEmail();
            }
            
        }

        public void buttonBoka_Click(object sender, EventArgs e)
        {
            input inmatning = new input();
            
            DateTime datum = DateTime.Now;
            string regnr = comboBoxReg.Text;
            if (kundHarReggadBil)
            {
                if (inmatning.boka(this.anvandare, regnr, datum))
                    richTextBoxMeddelandenBoka.Text = "Bokningen genomfördes utan problem";
                else
                {
                    richTextBoxMeddelandenBoka.Text = "Det blev något fel med bokningen";
                    string[] felmeddelande = inmatning.GetTmpMsgs();
                    if (felmeddelande.Contains("A duplicate value"))
                        richTextBoxMeddelandenBoka.Text = "Datumet du valt är upptaget, välj ett annat";
                    if (DEBUG)
                    {
                        richTextBoxMeddelandenBoka.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
                        richTextBoxMeddelandenBoka.Text += "\n**** FELMEDDELANDE ****";
                        foreach (string fel in felmeddelande)
                            richTextBoxMeddelandenBoka.Text += "\n" + fel + "\n";
                    }
                }
            }
            else
            {
                string modell = textBoxModell.Text;
                string marke = textBoxMarke.Text;
                string arsmodell = textBoxArsModell.Text;
                if (inmatning.boka(this.anvandare, regnr, datum, marke, modell, arsmodell))
                    richTextBoxMeddelandenBoka.Text = "Bokningen genomfördes utan problem";
                else
                {
                    richTextBoxMeddelandenBoka.Text = "Det blev något fel med bokningen";
                    string[] felmeddelande = inmatning.GetTmpMsgs();
                    if (felmeddelande.Contains("A duplicate value"))
                        richTextBoxMeddelandenBoka.Text = "Datumet du valt är upptaget, välj ett annat";
                    if (DEBUG)
                    {
                        richTextBoxMeddelandenBoka.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
                        richTextBoxMeddelandenBoka.Text += "**** FELMEDDELANDE ****";
                        foreach (string fel in felmeddelande)
                            richTextBoxMeddelandenBoka.Text += "\n" + fel + "\n";
                    }
                }
            }
        }

        private void buttonNyBoka_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;
            if (kundHarReggadBil)
                panelNyBil.Hide();
            tabControl1.SelectTab(tabPageNyBok);
        }

        private void comboBoxReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxReg.Text.Contains("Ny bil"))
            {
                kundHarReggadBil = false;
                panelNyBil.Show();
            }
            else
            {
                panelNyBil.Hide();
                kundHarReggadBil = true;
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void buttonMinBok_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageMinBok);
        }

        private void labelEditNamn_Click(object sender, EventArgs e)
        {
            DoljAndringar();
            maskedTextBoxGamla.UseSystemPasswordChar = false;
            maskedTextBoxBekräfta.UseSystemPasswordChar = false;
            maskedTextBoxNytt.UseSystemPasswordChar = false;
            label7.Text = "";
            maskedTextBoxNytt.Show();
            labelNytt.Show();
            buttonRedigera.Show();
            labelNytt.Text = "Nytt namn";
            this.uppdatera = "namn";
            
        }

        private void labelEditEmail_Click(object sender, EventArgs e)
        {
            DoljAndringar();
            maskedTextBoxGamla.UseSystemPasswordChar = false;
            maskedTextBoxBekräfta.UseSystemPasswordChar = false;
            maskedTextBoxNytt.UseSystemPasswordChar = false;
            label7.Text = "";
            maskedTextBoxNytt.Show();
            maskedTextBoxBekräfta.Show();
            maskedTextBoxGamla.Show();
            maskedTextBoxBekLosen.Show();
            labelNytt.Show();
            labelBekräfta.Show();
            labelGamla.Show();
            labelBekLosen.Show();
            buttonRedigera.Show();
            labelGamla.Text = "Din nuvarande email";
            labelBekräfta.Text = "Bekräfta din email";
            labelNytt.Text = "Din nya email";
            labelBekLosen.Text = "Dtt lösenord för att ändra emailen";
            this.uppdatera = "email";
        }

        private void labelEditTfn_Click(object sender, EventArgs e)
        {
            DoljAndringar();
            maskedTextBoxGamla.UseSystemPasswordChar = false;
            maskedTextBoxBekräfta.UseSystemPasswordChar = false;
            maskedTextBoxNytt.UseSystemPasswordChar = false;
            label7.Text = "";
            maskedTextBoxNytt.Show();
            maskedTextBoxBekräfta.Show();
            maskedTextBoxGamla.Show();
            maskedTextBoxBekLosen.Show();
            labelGamla.Show();
            labelNytt.Show();
            labelBekräfta.Show();
            labelBekLosen.Show();
            buttonRedigera.Show();
            labelGamla.Text = "Ditt nuvarande nummer";
            labelBekräfta.Text = "Bekräfta ditt telefonnummer";
            labelNytt.Text = "Ditt ny telefonnummer";
            labelBekLosen.Text = "Ditt lösenord för att ändra emailen";
            this.uppdatera = "tfn";
        }

        private void labelEditAdress_Click(object sender, EventArgs e)
        {
            DoljAndringar();
            maskedTextBoxGamla.UseSystemPasswordChar = false;
            maskedTextBoxBekräfta.UseSystemPasswordChar = false;
            maskedTextBoxNytt.UseSystemPasswordChar = false;
            label7.Text = "";
            maskedTextBoxNytt.Show();
            labelNytt.Show();
            buttonRedigera.Show();
            labelNytt.Text = "Din nya adress";
            this.uppdatera = "adress";
        }

        private void labelEditLosen_Click(object sender, EventArgs e)
        {
            DoljAndringar();
            label7.Text = "";
            maskedTextBoxGamla.UseSystemPasswordChar = true;
            maskedTextBoxBekräfta.UseSystemPasswordChar = true;
            maskedTextBoxNytt.UseSystemPasswordChar = true;
            maskedTextBoxNytt.Show();
            maskedTextBoxBekräfta.Show();
            maskedTextBoxGamla.Show();
            labelGamla.Show();
            labelNytt.Show();
            labelBekräfta.Show();
            buttonRedigera.Show();
            labelGamla.Text = "Ditt nu varande lösenord";
            labelBekräfta.Text = "Bekräfta ditt lösenord";
            labelNytt.Text = "Ditt ny lösenord";
            this.uppdatera = "losen";
        }

        private void buttonRedigera_Click(object sender, EventArgs e)
        {
            string losen = maskedTextBoxBekLosen.Text;

            switch (this.uppdatera)
            {
                case "namn":
                    string namn = maskedTextBoxNytt.Text;
                    this.anvandare.SetNamn(namn);
                    label7.Text = "Du har nu bytt namn";
                    labelNamn.Text = anvandare.GetNamn();
                    DoljAndringar();
                    break;

                case "email":
                    string email = maskedTextBoxNytt.Text;
                    string email1 = maskedTextBoxBekräfta.Text;
                    string email2 = maskedTextBoxGamla.Text;

                    if (losen == anvandare.GetLosen())
                    {
                        if (email2 == anvandare.GetEmail())
                        {
                            if (email == email1)
                            {
                                int result = anvandare.SetEmail(email1);
                                if (result == 0)
                                {
                                    label7.Text = "Du har nu bytt email-adress";
                                }
                                else
                                {
                                    label7.Text = "Det blev något fel någonstans...";
                                }
                            }
                            else
                            {
                                label7.Text = "Dina email-adresser stämmer inte ihop";
                            }
                            labelEmail.Text = anvandare.GetEmail();
                        }
                        else
                        {
                            label7.Text = "Din nuvarande email stämemr inte överäns med det du har skrivit nu";
                        }
                    }
                    else
                    {
                        label7.Text = "Du skrev in fel lösenord för att kunna ändra din email.";
                    }
                    DoljAndringar();
                    break;

                case "tfn":
                    string tfn = maskedTextBoxNytt.Text;
                    string tfn1 = maskedTextBoxBekräfta.Text;
                    string tfn2 = maskedTextBoxGamla.Text;

                    if (losen == anvandare.GetLosen())
                    {
                        if (tfn2 == anvandare.GetTfn())
                        {
                            if (tfn == tfn1)
                            {
                                int result = anvandare.SetTfn(tfn);
                                if (result == 0)
                                {
                                    label7.Text = "Du har nu bytt telefonnummer";
                                }
                                else
                                {
                                    label7.Text = "Det blev något fel någonstans...";
                                }
                            }
                            else
                            {
                                label7.Text = "Dina telefonnummer stämmer inte ihop";
                            }
                            labelTfn.Text = anvandare.GetTfn();
                        }
                        else
                        {
                            label7.Text = "Ditt nuvarande nummer stämemr inte överäns med det du har skrivit nu";
                        }
                    }
                    else
                    {
                        label7.Text = "Du skrev in fel lösenord för att kunna ändra ditt telefonnummer.";
                    }
                    DoljAndringar();
                        break;

                case "adress":
                        string adress = maskedTextBoxNytt.Text;
                        this.anvandare.SetAdress(adress);
                        labelAdress.Text = anvandare.GetAdress();
                        label7.Text = "Du har nu ändrat din adress";
                        DoljAndringar();
                    break;

                case "losen":
                    string losen1 = maskedTextBoxGamla.Text;
                    string losen2 = maskedTextBoxNytt.Text;
                    string losen3 = maskedTextBoxBekräfta.Text;

                    if (losen1 == anvandare.GetLosen())
                    {
                        if (losen2 == losen3)
                        {
                            int result = anvandare.SetLosen(losen2);
                            if (result == 0)
                            {
                                label7.Text = "Du har nu bytt lösenord";
                            }
                            else
                            {
                                label7.Text = "Det blev något fel någonstans...";
                            }
                        }
                        else
                        {
                            label7.Text = "Det bekräftande lösenordet stämmer inte ihop med det ny du skrev";
                        }
                    }
                    else
                    {
                        label7.Text = "Ditt lösenord stämmer inte ihop med det du skrev nu";
                    }
                    DoljAndringar();
                    break;
            }
        }

        private void buttonProfil_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageProfil);
        }
    }
}
