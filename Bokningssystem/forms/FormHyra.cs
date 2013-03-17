using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bokningssystem.forms;

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
        /// Funktion som tömmer checkboxen och resetar kalendern
        /// </summary>
        public void DoljHyr()
        {
          for (int i = 0; i < checkedListBox1.Items.Count; i++)
               if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
               {
                   checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
               }

           maskedTextBoxDagar.Text = "";
           panelTider.Hide();
           buttonHyr.Hide();
           monthCalendar1.SelectionStart = DateTime.Today;
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

            // Fixar så man bara kan välja ett datum i monthCalendar1.
            monthCalendar1.MaxSelectionCount = 30;
            
            DoljHyr();
            fyllHyrningar();

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
            string namn = tabButton.Name.Substring(6);

            switch (namn)
            {
                case "NyHyr":
                    tabControl1.SelectTab(tabPageNyHyr);
                    DoljHyr();
                    checkedListBox1.SetItemCheckState(1, CheckState.Indeterminate);
                    richTextBoxMeddelandenHyra.Text = "Du måste välj datum och hur många dagar du vill hyra ett fordon innan du kan hyra.";
                    break;

                case "MinHyr":
                    tableLayoutPanelHyrning.Controls.Clear();
                    labelHyrningMeddelande.Text = "";
                    tabControl1.SelectTab(tabPageMinHyr);
                    fyllHyrningar();
                    break;

                case "Profil":
                    FormProfil profil = new FormProfil(anvandare);
                    this.Hide();
                    profil.ShowDialog();
                    this.Show();
                    break;

                case "OmOss":
                    this.Hide();
                    FormOmOss Om = new FormOmOss(anvandare);
                    Om.ShowDialog();
                    this.Show();
                    break;

                case "Meny":
                    tabControl1.SelectTab(tabPageMeny);
                    tableLayoutPanelHyrning.Controls.Clear();
                    break;

                default:
                    if (DEBUG)
                        richTextBoxBokningMeny.Text = "Denna åtgärd är ännu inte implementerad i bytaTabPage\nKnappnamnet: " + namn;
                    break;
            }
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
        /// Räknar fram vilken slutdagen är
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

            buttonHyr.Show();
            
            if (DEBUG)
            {
                string meddelande = "\n" + dag + " och " + slutdag;
                richTextBoxMeddelandenHyra.Text += meddelande;
            }
        }

        /// <summary>
        /// Hyrfunktionen, hyr fordon på den valda dagen till.
        /// </summary>
        /// <param name="sender">Den knappen som startade eventet</param>
        /// <param name="e"></param>
        private void buttonHyr_Click(object sender, EventArgs e)
        {
            hyrnings_objekt hyrning = new hyrnings_objekt(new SqlCeDatabase(), this.anvandare);
            bil_objekt fordonregister = new bil_objekt();
            input inmatning = new input();
            int antalTyper = checkedListBox1.Items.Count;
            int antalValdaTyper = checkedListBox1.CheckedItems.Count;
            string valdaFordon = string.Empty;
            string reg;
            for (int i = 0; i < antalTyper; i++)
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                //foreach (string fordon in checkedListBox1.CheckedItems)
                {
                    string fordon = checkedListBox1.Items[i] as string;
                    valdaFordon += ", " + fordon;
                    if (fordonregister.kollaLedigaHyrFordon(fordon, dag, slutdag) == 0)
                    {
                        reg = fordonregister.GetTmpMsgs()[0];

                        if (hyrning.hyra(this.anvandare, dag, slutdag, reg))
                        {
                            richTextBoxMeddelandenHyra.Text = "Bokningen genomfördes utan problem.";
                            richTextBoxMeddelandenHyra.Text += "\n\nDu har nu hyrt en;\n" + valdaFordon.Substring(2) + "\nRegnummer: "+ reg +"\nStartdagen: " + dag + "\nSlutdagen: " + slutdag;
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
                    else
                        richTextBoxMeddelandenHyra.Text = "Tyvärr finns inga fordon lediga att hyras av den önskade typen";
                    DoljHyr();
                }
        }

        /// <summary>
        /// Eventhandler som ser till att items som inte ska gå att checka inte heller går att checka
        /// </summary>
        /// <param name="sender">Den checklisten eller checkboxen som triggade eventet</param>
        /// <param name="e">Argument som genereas av formen</param>
        private void ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.CurrentValue == CheckState.Indeterminate)
                e.NewValue = CheckState.Indeterminate;
        }

        /// <summary>
        /// Skriver ut vilka fordon kunden vill hyra
        /// </summary>
        /// <param name="sender">Knappobjektet som startade eventet</param>
        /// <param name="e"></param>
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DEBUG)
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
        }
        
        /// <summary>
        /// Funktion som skriver ut vilka fordon man har hyrt och vilka datum det gäller
        /// </summary>
        private void fyllHyrningar()
        {
            hyrnings_objekt hyrning = new hyrnings_objekt(new SqlCeDatabase(), this.anvandare);
            Array[] HyrningsResultat = hyrning.hamtaMinaHyrningar();

            if (HyrningsResultat.Length == 0)
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
                    Label labelHyrningStartDatum = new Label(), labelHyrningSlutDatum = new Label(), labelHyrningFordon = new Label(), labelTabortHyrningar = new Label();
                    Label[] labelHyrning = { labelHyrningStartDatum, labelHyrningSlutDatum, labelHyrningFordon, labelTabortHyrningar };
                    for (int o = 0; o < 4; o++)
                    {
                        if (o == 3)
                        {
                            labelHyrning[o].Text = "Ta bort";
                            labelHyrning[o].Name = "Tabort_" + hyrningsString[6];
                            labelHyrning[o].Cursor = Cursors.Hand;
                            labelHyrning[o].Click += new System.EventHandler(this.TaBort);
                        }
                        else
                            labelHyrning[o].Text = hyrningsString[o];
                        this.tableLayoutPanelHyrning.Controls.Add(labelHyrning[o]);
                    }
                }
            }
        }

        /// <summary>
        /// En funktion som tar bort en hyrning, använder namnet på den label som kallade funktionen.
        /// Kräver att labelns namn är Tabort_ID, där ID är ett nummer som stämmer överens med identiteten
        /// </summary>
        /// <param name="sender">Den labeln som kallade funktionen</param>
        /// <param name="e">Oanvänd parameter för denna funktion, följer med ClickOnEvent</param>
        private void TaBort(object sender, EventArgs e)
        {
            Label Tabort = sender as Label;
            string namn = Tabort.Name.Substring(7);
            int hyrningar;
            if (!int.TryParse(namn, out hyrningar))
                MessageBox.Show("Detta är inget id: " + namn);
            else
            {
                hyrnings_objekt hyrning = new hyrnings_objekt(new SqlCeDatabase(), this.anvandare);
                int TabortHyrning = hyrning.tabortMinaHyrningar(hyrningar);

                tableLayoutPanelHyrning.Controls.Clear();
                fyllHyrningar();
            }

        }
    }
}
