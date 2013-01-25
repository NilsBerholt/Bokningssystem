using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;


namespace Bokningssystem
{
    public partial class FormInmatning : Form
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        public FormInmatning()
        {
            InitializeComponent();
            //buttonRegistrera.Hide();
            if (DEBUG)
                buttonDebug.Visible = true;
            else
                buttonDebug.Visible = false;
            richTextBoxMeddelanden1.BorderStyle = BorderStyle.None;
            richTextBoxMeddelanden.BorderStyle = BorderStyle.None;
            richTextBoxMeddelanden1.Text = "Logga in med din email-adress\nför att kunna lägga till en bokning\neller för att se när du har bokat.";
        }

        private void label6_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel2Collapsed)
            {
                buttonRegistrera.Show();
                splitContainer1.Panel2Collapsed = false;
                splitContainer1.Panel1Collapsed = true;
                // splitContainer1.Width = 420;
                richTextBoxMeddelanden.Text = "Fyll i alla fälten till höger\nför att göra en korrekt registrering.";
                this.Width = 420;
                this.Height = 414;

            }
            else
            {
                buttonRegistrera.Hide();
                splitContainer1.Panel2Collapsed = true;
                // splitContainer1.Width = 180;
                richTextBoxMeddelanden1.Text = "Logga in med din email-adress\nför att kunna lägga till en bokning\neller för att se när du har bokat.";
                this.Width = 420;
                this.Height = 414;
            }
        }

        private void buttonLogga_Click(object sender, EventArgs e)
        {
            string[] felMeddelanden;
            List<string> errorMsg = new List<string>();
            if (textBoxEmailLogin.Text == "" | textBoxLosenLogin.Text == "")
                errorMsg.Add("Du måste skriva in både email och lösenord för att logga in.");
            else
            {
                input inmatning = new input();
                SqlCeDatabase db = new SqlCeDatabase();
                TextBox[] inmatningar = { textBoxEmailLogin };

                string[] kolladInmatning = inmatning.kollaInmatning(inmatningar);
                felMeddelanden = inmatning.GetTmpMsgs();

                if (felMeddelanden.Length > 0)
                {
                    if (DEBUG)
                    {
                        string fullFel = string.Empty;
                        richTextBoxMeddelanden1.Text = "";
                        foreach (string meddelande in felMeddelanden)
                            fullFel += meddelande + "\n";

                        MessageBox.Show(fullFel);
                    }
                    else
                    {
                        if (felMeddelanden.Contains("giltig adress"))
                        {
                            richTextBoxMeddelanden1.Text = "Du har inte skrivit in en giltig email-adress";
                        }
                        errorMsg.Add("Det blev ett fel med din inloggning.\nKontakta systemansvarig.");
                    }
                }
                else
                {
                    string queryLogin = "Select email, losen FROM KUNDER WHERE email='?x?'";
                    if (db.query(queryLogin, kolladInmatning)[0] == "1")
                    {
                        string[] sokResultat = db.fetchAll();
                        if (sokResultat[1].Contains("inga värden"))
                            errorMsg.Add("Din emailadress finns inte i vår databas, är du säker på att du har skapat en användare?\n" +
                                "Om inte, klicka på Skapa användare för att göra just det.");
                        else
                        {
                            if (sokResultat[1] == textBoxLosenLogin.Text)
                            {
                                kund anvandare = new kund(sokResultat[0], sokResultat[1]);
                                FormBoka minBokning = new FormBoka(anvandare);
                                if (DEBUG)
                                {
                                    this.Hide();
                                    minBokning.ShowDialog();
                                    this.Show();
                                }
                                else
                                {
                                    this.Hide();
                                    minBokning.ShowDialog();
                                    this.Close();
                                }
                            }
                            else
                                errorMsg.Add("Det blev fel med kombinationen med lösenord och emailadressen");
                        }
                    }
                    else
                    {
                        if (DEBUG)
                        {
                            errorMsg.AddRange(db.query(queryLogin, kolladInmatning));
                            string fullFel = string.Empty;
                            foreach (string meddelande in errorMsg)
                                fullFel += meddelande;
                            MessageBox.Show(fullFel);
                        }
                        else
                            errorMsg.Add("Det blev något fel med inloggningen, kontakta systemansvarig");
                    }
                }
            }
            if (errorMsg.Count > 0)
            {
                string fullFel = string.Empty;
                foreach (string fel in errorMsg)
                    fullFel += fel + "\n";
                richTextBoxMeddelanden1.Text = fullFel;
            }
        }

        private void buttonRegistrera_Click(object sender, EventArgs e)
        {
            input inmatning = new input();
            richTextBoxMeddelanden.Text = "";
            if (textBoxLosen.Text == textBoxLosenBek.Text)
            {
                TextBox[] inmatningsBoxar = { textBoxNamn, textBoxEmail, textBoxTelefon, textBoxAdress, textBoxPersnr, textBoxLosen };
                string[] inmatVärden = inmatning.kollaInmatning(inmatningsBoxar);
                if (DEBUG)
                {
                    string[] errorMsgs = inmatning.GetTmpMsgs();

                    foreach (string meddelande in errorMsgs)
                        richTextBoxMeddelanden.Text += meddelande + "\n";
                }
                string[] regResultat = inmatning.ReggaKund(inmatVärden);
                if (regResultat[0] == "1" )
                {
                    if (DEBUG)
                        richTextBoxMeddelanden.Text += "Ditt konto registrerades utan problem!\nDu kan nu logga in.";
                    else 
                        richTextBoxMeddelanden1.Text = "Ditt konto registrerades utan problem!\nDu kan nu logga in.";
                    splitContainer1.Panel2Collapsed = true;
                }
                else if (regResultat[1].Contains("A duplicate value"))
                {
                    if (DEBUG)
                        richTextBoxMeddelanden.Text += "Det finns redan ett konto med denna emailadress eller med detta personnummer. " +
                            "\nKontrollera att du inte redan skapat ett konto.\n";
                    else 
                        richTextBoxMeddelanden.Text = "Det finns redan ett konto med denna emailadress eller med detta personnummer. " +
                            "\nKontrollera att du inte redan skapat ett konto.\n";
                }
                else
                {
                    if (DEBUG)
                        richTextBoxMeddelanden.Text += regResultat[1];
                    else 
                        richTextBoxMeddelanden.Text += "Det blev ett fel när du skulle registreras.\nFörsök gärna lite senare.";
                }
            }
            else richTextBoxMeddelanden.Text += "Dina lösenord stämmer inte överens\n";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed)
            {
                buttonRegistrera.Show();
                richTextBoxMeddelanden.BorderStyle = BorderStyle.None;
                splitContainer1.Panel1Collapsed = false;
                splitContainer1.Panel2Collapsed = true;
                // splitContainer1.Width = 420;
                richTextBoxMeddelanden1.Text = "Logga in med din email-adress\nför att kunna lägga till en bokning\neller för att se när du har bokat.";
                this.Width = 420;
                this.Height = 414;

            }
            else
            {
                buttonRegistrera.Hide();
                splitContainer1.Panel1Collapsed = true;
                // splitContainer1.Width = 180;
                richTextBoxMeddelanden.Text = "Fyll i alla fälten till höger\nför att göra en korrekt registrering.";
                this.Width = 420;
                this.Height = 414;
            }
        }

        private void buttonVisa_Click(object sender, EventArgs e)
        {
            string queryVisa = "Select * from Kunder";
            string[] args = { };

            SqlCeDatabase db = new SqlCeDatabase();

            string[] kollaQuery = db.query(queryVisa, args);
            if (kollaQuery[0] != "0")
            {
                string[] läsResultat = db.fetchAll();

                string FullResultat = string.Empty;
                foreach (string resultat in läsResultat)
                    FullResultat += resultat + "\n";
                MessageBox.Show(FullResultat);
            }
            else
            {
                richTextBoxMeddelanden.Text = kollaQuery[1];
            }
        }

        private void buttonDebug_Click(object sender, EventArgs e)
        {
            if (DEBUG)
            {
                Properties.Settings.Default.Debug = false;
                buttonVisa.Hide();
            }

            else
            {
                Properties.Settings.Default.Debug = true;
                buttonVisa.Show();
                buttonVisa.Enabled = true;
            }

            DEBUG = Properties.Settings.Default.Debug;
            MessageBox.Show("Debug är " + Properties.Settings.Default.Debug.ToString());
        }
    }
}