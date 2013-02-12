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
    public partial class FormHyra : Form
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        private kund anvandare;
        private string uppdatera = null;
        private string dag = "";
        private string slutdag = "";

        /// <summary>
        /// Funktion som döljer och tömmer strängarna i labels och textboxar
        /// </summary>
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
        public void DoljHyr()
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                { 
                    checkedListBox1.SelectedItem = CheckState.Unchecked;
                }
            panelTider.Hide();
            buttonHyr.Hide();
        }

        /// <summary>
        /// Konstruktören för FormHyra-formen, här börjar koden från FormHyra.
        /// Här initalieras alla komponenter och kund objektet sparas som global variabel för formen.
        /// </summary>
        /// <param name="anvandare">Kund objektet för den som hyr</param>
        public FormHyra(kund anvandare)
        {
            InitializeComponent(); 
            SqlCeDatabase db = new SqlCeDatabase();
            this.anvandare = anvandare;

            // Initiera profilvariablerna från kund objektet
            labelNamn.Text = anvandare.GetNamn();
            labelEmail.Text = anvandare.GetEmail();
            labelTfn.Text = anvandare.GetTfn();
            labelAdress.Text = anvandare.GetAdress();

            // Fixar så man bara kan välja ett datum i monthCalendar1.
            monthCalendar1.MaxSelectionCount = 1;
            DoljAndringar();
            panelTider.Hide();
            //buttonHyr.Hide();

            richTextBoxBokningMeny.Text = "Tryck på Ny hyrning för att göra en ny hyrning.\nTryck på Mina hyrningar för att se vad du har hyrt och när.";
            if (DEBUG)
            {
                richTextBoxBokningMeny.Text += "\nNamn: " + anvandare.GetNamn();
                richTextBoxBokningMeny.Text += "\nEmail: " + anvandare.GetEmail();
            }
        }

        /// <summary>
        /// Byter mellan tabbarna i Formen.
        /// Kollar vilket namn som knappen som startade har och gör en switch case på dem.
        /// </summary>
        /// <param name="sender">objektet som startade eventet, måste vara en knapp</param>
        /// <param name="e"></param>
        private void bytaTabPage(object sender, EventArgs e)
        {
            Button tabButton = sender as Button;
            string namn = tabButton.Name;
            namn = namn.Substring(6);

            switch (namn)
            {
                case "NyHyr":
                    tabControl1.SelectTab(tabPageNyHyr);
                    monthCalendar1.SelectionStart = DateTime.Today;
                    DoljHyr();
                    richTextBoxMeddelandenHyra.Text = "Du måste välj datum och hur många dagar du vill hyra ett fordon innan du kan hyra.";
                    break;

                case "MinHyr":
                    labelHyrningMeddelande.Text = "";
                    tabControl1.SelectTab(tabPageMinHyr);
                    tableLayoutPanelHyrning.Controls.Clear();
                    fyllHyrningar();
                    break;

                case "Profil":
                    tabControl1.SelectTab(tabPageProfil);
                    break;

                case "Meny":
                    tabControl1.SelectTab(tabPageMeny);
                    tableLayoutPanelHyrning.Controls.Clear();
                    break;

                case "1":
                    tabControl1.SelectTab(tabPageMeny);
                    DoljHyr();
                    break;

                case "2":
                    tabControl1.SelectTab(tabPageMeny);
                    break;
                    

                default:
                    if (DEBUG)
                        richTextBoxBokningMeny.Text = "Denna åtgärd är ännu inte implementerad i bytaTabPage\nKnappnamnet: " + namn;
                    break;
            }
        }

        /// <summary>
        /// Funktion som startar och gör i ordning profilsidans ändringslabels.
        /// Den gör om sender objektet till en label och utifrån namnet på labeln så kommer den byta text
        /// och synlighet på labels och textboxar.
        /// Den lägger även till informationen om vad som uppdateras.
        /// </summary>
        /// <param name="sender">Objektet som startade eventet, måste vara en Label</param>
        /// <param name="e"></param>
        private void startEdit(object sender, EventArgs e)
        {
            DoljAndringar();
            // Skapar en array med de intressanta lablarna och gör object sender till en label
            Label startLabel = sender as Label;
            string namn = startLabel.Name.Substring(9, startLabel.Name.Length - 9);
            bool bekräftelseBehövs = false;

            // Om namnet är labelEditLosen så låt textboxen använda sig av PasswordChar istället för vanliga karaktärer
            if (namn == "Losen")
            {
                maskedTextBoxGamla.UseSystemPasswordChar = true;
                maskedTextBoxBekräfta.UseSystemPasswordChar = true;
                maskedTextBoxNytt.UseSystemPasswordChar = true;
            }
            // Annars använd vanliga karaktärer
            else
            {
                maskedTextBoxGamla.UseSystemPasswordChar = false;
                maskedTextBoxBekräfta.UseSystemPasswordChar = false;
                maskedTextBoxNytt.UseSystemPasswordChar = false;
            }

            // Använd substringen av labelns namn för att utföra mer specifika uppgifter
            switch (namn)
            {
                case "Namn":
                    labelNytt.Text = "Nytt namn";
                    this.uppdatera = "namn";
                    bekräftelseBehövs = false;
                    break;

                case "Adress":
                    labelNytt.Text = "Din nya adress";
                    this.uppdatera = "adress";
                    bekräftelseBehövs = false;
                    break;

                case "Email":
                    labelGamla.Text = "Din nuvarande email";
                    labelBekräfta.Text = "Bekräfta din email";
                    labelNytt.Text = "Din nya email";
                    labelBekLosen.Text = "Dtt lösenord för att ändra emailen";
                    this.uppdatera = "email";
                    bekräftelseBehövs = true;
                    break;

                case "Losen":
                    labelGamla.Text = "Ditt nuvarande lösenord";
                    labelBekräfta.Text = "Bekräfta ditt lösenord";
                    labelNytt.Text = "Ditt nya lösenord";
                    this.uppdatera = "losen";
                    bekräftelseBehövs = true;
                    break;

                case "Tfn":
                    labelGamla.Text = "Ditt nuvarande nummer";
                    labelBekräfta.Text = "Bekräfta ditt telefonnummer";
                    labelNytt.Text = "Ditt nya telefonnummer";
                    labelBekLosen.Text = "Ditt lösenord för att ändra telefonnummer";
                    this.uppdatera = "tfn";
                    bekräftelseBehövs = true;
                    break;

                // Om namnet på labeln inte är något av ovanstående ge ett felmeddelande och avsluta
                default:
                    if (DEBUG)
                    {
                        labelNytt.Text = "Det blev något fel, det här är inte en giltig ändringslänk";
                        labelNytt.Text += "Denna label heter " + startLabel.Name;
                    }
                    return;
            }

            // Om man behöver bekräftelse
            if (bekräftelseBehövs)
            {
                labelBekLosen.Show();
                maskedTextBoxBekräfta.Show();
                maskedTextBoxGamla.Show();
                maskedTextBoxBekLosen.Show();
                labelGamla.Show();
                labelBekräfta.Show();
            }

            label7.Text = "";
            maskedTextBoxNytt.Show();
            labelNytt.Show();
            buttonRedigera.Show();
        }

        /// <summary>
        /// Funktion som körs när datumet ändras i kalendern. Extraherar den valda datetimen och
        /// gör om det till en sträng med bara datumet
        /// </summary>
        /// <param name="sender">The button that called the event</param>
        /// <param name="e"></param>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dag = monthCalendar1.SelectionStart.Date.ToString();
            // Tar bort de onödiga och totalt förstörande sista nollorna efter datumet
            dag = dag.Substring(0, dag.IndexOf(' '));
            panelTider.Show();
        }

        /// <summary>
        /// Utför redigeringen, kollar upp vilket uppdatering som ska utföras och uppdaterar sedan
        /// uppdatering är en global privat strängvariabel som måste vara deklarerad innan denna funktion körs
        /// </summary>
        /// <param name="sender">Knappenobjektet som startade eventet</param>
        /// <param name="e"></param>
        private void buttonRedigera_Click(object sender, EventArgs e)
        {
            string losen = maskedTextBoxBekLosen.Text;
            int result;

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
                    // Kolla om allting är rätt
                    if (losen != anvandare.GetLosen())
                    {
                        label7.Text = "Du skrev in fel lösenord för att kunna ändra din email.";
                        break;
                    }
                    if (email2 != anvandare.GetEmail())
                    {
                        label7.Text = "Den emailen du skrev är inte samma som din gamla";
                        break;
                    }
                    if (email != email1)
                    {
                        label7.Text = "Dina email-adresser stämmer inte överens";
                        break;
                    }

                    result = anvandare.SetEmail(email1);
                    if (result == 0)
                    {
                        label7.Text = "Du har nu bytt email-adress";
                        labelEmail.Text = anvandare.GetEmail();
                    }
                    else
                    {
                        if (DEBUG)
                        {
                            if (result == 1)
                                foreach (string msg in anvandare.GetTmpMsgs())
                                    label7.Text += msg;
                            label7.Text = "Det blev något fel någonstans...";
                        }
                    }
                    DoljAndringar();
                    break;

                case "tfn":
                    string tfn = maskedTextBoxNytt.Text;
                    string tfn1 = maskedTextBoxBekräfta.Text;
                    string tfn2 = maskedTextBoxGamla.Text;

                    if (losen != anvandare.GetLosen())
                    {
                        label7.Text = "Du skrev in fel lösenord för att kunna ändra ditt telefonnummer.";
                        break;
                    }

                    if (tfn2 != anvandare.GetTfn())
                    {
                        label7.Text = "Dina telefonnummer stämmer inte ihop";
                        break;
                    }

                    if (tfn == tfn1)
                    {
                        result = anvandare.SetTfn(tfn);
                        if (result == 0)
                        {
                            label7.Text = "Du har nu bytt telefonnummer";
                            labelTfn.Text = anvandare.GetTfn();
                        }
                        else
                        {
                            label7.Text = "Det blev något fel någonstans...";
                        }
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

                    if (losen1 != anvandare.GetLosen())
                    {
                        label7.Text = "Ditt lösenord stämmer inte ihop med det du skrev nu";
                        break;
                    }
                    if (losen2 != losen3)
                    {
                        label7.Text = "Det bekräftande lösenordet stämmer inte ihop med det ny du skrev";
                        break;
                    }

                    result = anvandare.SetLosen(losen2);
                    if (result == 0)
                    {
                        label7.Text = "Du har nu bytt lösenord";
                    }
                    else
                    {
                        label7.Text = "Det blev något fel någonstans...";
                    }
                    DoljAndringar();
                    break;

                default:
                    if (DEBUG)
                        label7.Text = "Denna ändring är inte ännu implementerad i Redigeringsfunktionen";
                    break;
            }
        }

        /// <summary>
        /// Räcknar fram vilken slutdagen är
        /// </summary>
        /// <param name="sender">Knappenobjektet som startade eventet</param>
        /// <param name="e"></param>
        private void buttonDagar_Click(object sender, EventArgs e)
        {
            string dagar = maskedTextBoxDagar.Text;
            DateTime dagDate = DateTime.Parse(dag);
            dagDate = dagDate.AddDays(Convert.ToDouble(dagar));
            slutdag = dagDate.Date.ToString();
            slutdag = slutdag.Substring(0, slutdag.IndexOf(' '));

            string meddelande ="\n" + dag + " och " + slutdag;
            richTextBoxMeddelandenHyra.Text += meddelande;
        }

        /// <summary>
        /// Hyrfunktionen, hyr fordon på den valda dagen till.
        /// </summary>
        /// <param name="sender">Den knappen som startade eventet</param>
        /// <param name="e"></param>
        private void buttonHyr_Click(object sender, EventArgs e)
        {
            Hyrnings_objekt hyrning = new Hyrnings_objekt(new SqlCeDatabase(), this.anvandare);
            input inmatning = new input();

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    string fordon = checkedListBox1.Items[i] as string;
                    //string objectText = string.Format("{0}, \n", fordon);

                    if (hyrning.hyra(this.anvandare, dag, slutdag, fordon))
                    {
                        richTextBoxMeddelandenHyra.Text = "Bokningen genomfördes utan problem.";
                        richTextBoxMeddelandenHyra.Text += "\nDu har nu hyrt;\n" + fordon + "\nOch startdagen:" + dag + "\nSlutdagen:" + slutdag;
                    }
                    else
                    {
                        richTextBoxMeddelandenHyra.Text = "Det blev något fel med hyrningen";
                        string[] felmeddelande = hyrning.GetTmpMsgs();
                        if (DEBUG)
                        {
                            richTextBoxMeddelandenHyra.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
                            richTextBoxMeddelandenHyra.Text += "\n**** FELMEDDELANDE ****";
                            foreach (string fel in felmeddelande)
                                richTextBoxMeddelandenHyra.Text += "\n" + fel + "\n";
                        }
                    }
                }
        }

        /// <summary>
        /// Skriver ut vilka fordon kunden vill hyra
        /// </summary>
        /// <param name="sender">Knappobjektet som startade eventet</param>
        /// <param name="e"></param>
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hyrFordon = "Detta är de fordon du vill hyra:\n";
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    string vald = checkedListBox1.Items[i] as string;
                    string objectText = string.Format("{0}, \n", vald);
                    hyrFordon += objectText;
                }
            richTextBoxMeddelandenHyra.Text = hyrFordon;
        }

        /// <summary>
        /// Funktion som skriver ut vilka fordon man har hyrt och vilka datum det gäller
        /// </summary>
        private void fyllHyrningar()
        {
            Hyrnings_objekt hyrning = new Hyrnings_objekt(new SqlCeDatabase(), this.anvandare);
            Array[] HyrningsResultat = hyrning.hamtaMinaHyrningar();

            if (HyrningsResultat.Length < 1)
            {
                this.tableLayoutPanelHyrning.Hide();
                this.labelHyrningMeddelande.Text = "Du har inga hyrda fordon";
                this.labelHyrningMeddelande.Show();
            }

            if (this.tableLayoutPanelHyrning.Visible)
            {
                int length = HyrningsResultat.Length;
                for (int i = 0; i < length; i++)
                {
                    string[] hyrningsString = HyrningsResultat[i] as string[];
                    Label labelHyrningHyrning = new Label(), labelHyrningStartDatum = new Label(), labelHyrningSlutDatum = new Label(), labelHyrningFordon = new Label(), labelTabortHyrningar = new Label();
                    Label[] labelHyrning = {labelHyrningHyrning, labelHyrningStartDatum, labelHyrningSlutDatum, labelHyrningFordon, labelTabortHyrningar };
                    for (int o = 0; o < 5; o++)
                    {
                        if (o != 0)
                            if (o % 4 == 0)
                                hyrningsString[o] = "x";

                        labelHyrning[o].Text = hyrningsString[o];
                        this.tableLayoutPanelHyrning.Controls.Add(labelHyrning[o]);
                    }
                }
            }
        }
    }
}
