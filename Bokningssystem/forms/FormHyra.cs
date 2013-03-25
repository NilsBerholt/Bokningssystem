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
        private string startdag = "";
        private string slutdag = "";

        /// <summary>
        /// Funktion som tömmer checkboxen och resetar kalendern
        /// </summary>
        public void DoljHyr()
        {
          for (int i = 0; i < checkedListBox1.Items.Count; i++)
               if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                    checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
           
            labelFordonsTyp.Hide();
            panelTyp.Hide();
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
                    if (fordonregister.kollaLedigaHyrFordon(fordon, startdag, slutdag) == 0)
                    {
                        reg = fordonregister.GetTmpMsgs()[0];

                        if (hyrning.hyra(this.anvandare, startdag, slutdag, reg))
                        {
                            richTextBoxMeddelandenHyra.Text = "Bokningen genomfördes utan problem.";
                            richTextBoxMeddelandenHyra.Text += "\n\nDu har nu hyrt en;\n" + valdaFordon.Substring(2) + "\nRegnummer: "+ reg +"\nStartdagen: " + startdag + "\nSlutdagen: " + slutdag;
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
        /// Väljer startdag och slutdag
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void datum(object sender, EventArgs e)
        {
            if (sender == dateTimePicker1)
            {
                startdag = dateTimePicker1.Value.ToShortDateString();
            }

            if (sender == dateTimePicker2)
            {
                slutdag = dateTimePicker2.Value.ToShortDateString();
            }

            richTextBoxMeddelandenHyra.Text = "";
            string[] lines = new string[2];
            if (this.startdag != "")
                lines[0] = "Startdag: " + startdag;
            if (this.slutdag != "")
                lines[1] = "Slutdag: " + slutdag;
            richTextBoxMeddelandenHyra.Lines = lines;
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
            if (e.CurrentValue == CheckState.Unchecked)
            {
                for (int i = 0; i < checkedListBox1.Items.Count; i++)
                    if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                        checkedListBox1.SetItemCheckState(i, CheckState.Unchecked);
                e.NewValue = CheckState.Checked;
            }
        }

        /// <summary>
        /// Väljer datumena och vilken fordonstyp kunden vill hyra
        /// </summary>
        /// <param name="sender">Button</param>
        /// <param name="e"></param>
        private void buttonValj_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemCheckState(i) == CheckState.Checked)
                {
                    string fordon = checkedListBox1.Items[i] as string;
                    labelFordonsTyp.Text = fordon;

                    HyrablaFordon(fordon, startdag, slutdag);
                }

            labelFordonsTyp.Show();
            panelTyp.Show();
        }

        /// <summary>
        /// Skriver ut i en tabellayout med all iformation som är nödvändig för kunden
        /// </summary>
        /// <param name="typ">Vilken typ kunden vill ha</param>
        /// <param name="startdag">Startdagen för hyrningen</param>
        /// <param name="slutdag">Slutdagen för hyrningen</param>
        private void HyrablaFordon(string typ, string startdag, string slutdag)
        {
            bil_objekt hyrabel = new bil_objekt();

            int hyrabelStatus = hyrabel.kollaLedigaHyrFordon(typ, startdag, slutdag);
            if (hyrabelStatus == 10)
            {
                this.tableLayoutPanelTyp.Hide();
                this.labelFordonsTypMeddelande.Text = "Det finns inga lediga fordon utav denna typ under din önskade tid";
                this.labelFordonsTypMeddelande.Show();
            }
            else if (hyrabelStatus == 0)
            {
                if (this.tableLayoutPanelTyp.Visible)
                {
                    string[] ledigaFordon = hyrabel.GetTmpMsgs();
                    int length = ledigaFordon.Length;
                    for (int i = 0; i < length; i++)
                    {
                        Label labelLedigaFordonMarke = new Label(), labelLedigaFordonModell = new Label(), labelLedigaFordonArsmodell = new Label(), labelLedigaFordonReg = new Label(), labelLedigaFordonHyr = new Label();
                        Label[] labelFordon = { labelLedigaFordonReg, labelLedigaFordonMarke, labelLedigaFordonModell, labelLedigaFordonArsmodell, labelLedigaFordonHyr };
                        for (int o = 0; o < 5; o++)
                        {
                            if (o == 4)
                            {
                                labelFordon[o].Text = "Hyr";
                                labelFordon[o].Name = "Hyr_" + ledigaFordon[i];
                                labelFordon[o].Cursor = Cursors.Hand;
                                labelFordon[o].Click += new System.EventHandler(this.Hyr); 
                            }
                            else
                            {
                                labelFordon[o].Text = ledigaFordon[o];
                            }
                        }
                    }
                }
            }
        }
        
        /// <summary>
        /// Funktion som skriver ut vilka fordon man har hyrt och vilka datum det gäller
        /// </summary>
        private void fyllHyrningar()
        {
            hyrnings_objekt hyrning = new hyrnings_objekt(new SqlCeDatabase(), this.anvandare);
            SortedList<string, string>[] HyrningsResultat = hyrning.hamtaMinaHyrningar();

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
                    SortedList<string, string> hyrningsString = HyrningsResultat[i] as SortedList<string, string>;
                    Label labelHyrningStartDatum = new Label(), labelHyrningSlutDatum = new Label(), labelHyrningFordon = new Label(), labelTabortHyrningar = new Label();
                    Label[] labelHyrning = { labelHyrningStartDatum, labelHyrningSlutDatum, labelHyrningFordon, labelTabortHyrningar };
                    for (int o = 0; o < 4; o++)
                    {
                        if (o == 3)
                        {
                            labelHyrning[o].Text = "Ta bort";
                            labelHyrning[o].Name = "Tabort_" + hyrningsString["Hyrning"];
                            labelHyrning[o].Cursor = Cursors.Hand;
                            labelHyrning[o].Click += new System.EventHandler(this.TaBort);
                        }
                        else
                            labelHyrning[o].Text = hyrningsString[hyrningsString.Keys[o]];
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

        /// <summary>
        /// Funktion som hyr det valda fordonet
        /// </summary>
        /// <param name="sender">label</param>
        /// <param name="e"></param>
        private void Hyr(object sender, EventArgs e)
        {
            hyrnings_objekt hyrning = new hyrnings_objekt(new SqlCeDatabase(), this.anvandare);
            bil_objekt hyrabel = new bil_objekt();
            Label hyr = sender as Label;

            string reg = hyr.Name.Substring(4);

            if (hyrning.hyra(this.anvandare, startdag, slutdag, reg))
            {
                richTextBoxMeddelandenHyra.Text = "Bokningen genomfördes utan problem.";
                richTextBoxMeddelandenHyra.Text += "\n\nDu har nu hyrt en;\n" + typ + "\nRegnummer: " + reg + "\nStartdagen: " + startdag + "\nSlutdagen: " + slutdag;
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
}
