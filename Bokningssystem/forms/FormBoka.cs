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
        private bool kundHarReggadBil = false;
        private string dag = "";
        private string tid = "";

        /// <summary>
        /// Funktion som döljer och tömmer strängarna i labels och textboxar
        /// </summary>
        public void DoljBokningar()
        {
            timeButton_08.Checked = false;
            timeButton_10.Checked = false;
            timeButton_14.Checked = false;
            timeButton_16.Checked = false;
            panelTider.Hide();
            buttonBoka.Hide();
        }
        public void Meddelande()
        {
            labelSpec.Hide();
            richTextBoxMeddelandenBoka.ReadOnly = true;
            richTextBoxMeddelandenBoka.Cursor = Cursors.Default;
            richTextBoxMeddelandenBoka.TabStop = false;
            richTextBoxMeddelandenBoka.BorderStyle = BorderStyle.None;
        }
        public void Problem()
        {
            labelSpec.Show();
            richTextBoxMeddelandenBoka.ReadOnly = false;
            richTextBoxMeddelandenBoka.Cursor = Cursors.IBeam;
            richTextBoxMeddelandenBoka.TabStop = true;
            richTextBoxMeddelandenBoka.BorderStyle = BorderStyle.Fixed3D;
            richTextBoxMeddelandenBoka.Text = "";
        }

        /// <summary>
        /// Konstruktören för FormBoka-formen, här börjar koden från FormBoka.
        /// Här initalieras alla komponenter och kund objektet sparas som global variabel för formen.
        /// 
        /// Här tas även bilarna fram och sparas i Listan kundbilar.
        /// </summary>
        /// <param name="anvandare">Kund objektet för den som bokar</param>
        public FormBoka(kund anvandare)
        {
            InitializeComponent();
            SqlCeDatabase db = new SqlCeDatabase();
            bil_objekt bil = new bil_objekt();
            this.anvandare = anvandare;
            List<string> kundBilar = new List<string>();

            // Kolla efter bilar registrerade till kunden / användaren.
            if (bil.kollaKundsBilar(anvandare,"reg") == 2)
            {
                if (DEBUG)
                    richTextBoxBokningMeny.Text = "Något är fel med kollaKundsBilar-funktionen i bil_objekt.cs";
            }
            else if (bil.kollaKundsBilar(anvandare) == 0)
            {
                kundBilar.AddRange(bil.GetTmpMsgs());
                this.kundHarReggadBil = true;
            }

            // Lägg till en rad "Ny bil..." och lägg till bilarna till regnr-comboboxens datasource
            kundBilar.Add("Ny bil...");
            comboBoxReg.DataSource = kundBilar;

            // Fixar så man bara kan välja ett datum i monthCalendar1.
            monthCalendar1.MaxSelectionCount = 1;
            panelTider.Hide();
            buttonBoka.Hide();

            richTextBoxBokningMeny.Text = "Tryck på Ny bokning för att göra en ny bokning.\nTryck på Mina Bokningar för att se vad du har bokat och när.";
            if (DEBUG)
            {
                richTextBoxBokningMeny.Text += "\nNamn: " + anvandare.GetNamn();
                richTextBoxBokningMeny.Text += "\nEmail: " + anvandare.GetEmail();
                richTextBoxBokningMeny.Text += "\nPersonnummer: " + anvandare.GetPersonnummer();
            }
        }

        /// <summary>
        /// Bokafunktionen, bokar in bilen på den valda tiden och datumet.
        /// Funktionen kollar om man bokar en registrerad bil eller om man registrerar en ny och kommer i så fall registrera den nya bilen hos kunden.
        /// </summary>
        /// <param name="sender">Den knappen som startade eventet</param>
        /// <param name="e"></param>
        public void buttonBoka_Click(object sender, EventArgs e)
        {
            boknings_objekt bokning = new boknings_objekt(new SqlCeDatabase(), this.anvandare);
            input inmatning = new input();
            Meddelande();

            if (dag != "" & tid != "")
            {
                // Formatterar datumet och hämtar regnumret
                string datum = dag + " " + tid;
                string regnr = comboBoxReg.Text;
                string spec = richTextBoxMeddelandenBoka.Text;
                // Om det är en reggad bil som är markerad, boka bara bilen på datumet och tiden
                if (this.kundHarReggadBil)
                {
                    if (bokning.boka(this.anvandare, regnr, datum, spec))
                    {
                        richTextBoxMeddelandenBoka.Text = "Bokningen genomfördes utan problem.";
                        richTextBoxMeddelandenBoka.Text += "\nDatumet är " + this.dag + " och tiden " + this.tid;
                    }
                    else
                    {
                        richTextBoxMeddelandenBoka.Text = "Det blev något fel med bokningen";
                        string[] felmeddelande = bokning.GetTmpMsgs();
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
                // Om bilen inte är registrerad så registrera bilen först och sen boka in bilen på datument och tiden
                else
                {
                    string modell = textBoxModell.Text;
                    string marke = textBoxMarke.Text;
                    string arsmodell = textBoxArsModell.Text;
                    if (bokning.boka(this.anvandare, regnr, datum, marke, modell, arsmodell, spec))
                    {
                        richTextBoxMeddelandenBoka.Text = "Bokningen genomfördes utan problem.";
                        richTextBoxMeddelandenBoka.Text += "\nDatumet är " + this.dag + " och tiden " + this.tid;
                    }
                    else
                    {
                        richTextBoxMeddelandenBoka.Text = "Det blev något fel med bokningen";
                        string[] felmeddelande = bokning.GetTmpMsgs();
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
                DoljBokningar();
            }
            // Om tiden eller datument är tomt visa felmeddelandet
            else
            {
                richTextBoxMeddelandenBoka.Text = "Du har inte valt vilket datum och vilken tid du vill utföra din bokning";
                if (DEBUG)
                    richTextBoxMeddelandenBoka.Text += "\nDatumet är " + dag + " och tiden är " + tid;
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
                case "NyBoka":
                    tabControl1.SelectTab(tabPageNyBok);
                    monthCalendar1.SelectionStart = DateTime.Today;
                    Problem();
                    DoljBokningar();
                    break;

                case "MinBok":
                    labelBokningarMeddelande.Text = "";
                    tabControl1.SelectTab(tabPageMinBok);
                    tableLayoutPanelBokningar.Controls.Clear();
                    this.fyllBokningar_bilar();
                    break;

                case "MinFordon":
                    labelBilarMeddelande.Text = "";
                    tableLayoutPanelBilar.Controls.Clear();
                    tabControl1.SelectTab(tabPageMinFordon);
                    this.fyllBokningar_bilar();
                    break;

                case "Profil":
                    FormProfil profil = new FormProfil(anvandare);
                    this.Hide();
                    profil.ShowDialog();
                    this.Show();
                    break;

                case "OmOss":
                    FormOmOss omOss = new FormOmOss(anvandare);
                    this.Hide();
                    omOss.ShowDialog();
                    this.Show();
                    break;

                case "Meny":
                    tabControl1.SelectTab(tabPageMeny);
                    tableLayoutPanelBilar.Controls.Clear();
                    tableLayoutPanelBokningar.Controls.Clear();
                    DoljBokningar();
                    break;

                default:
                    if (DEBUG)
                        richTextBoxBokningMeny.Text = "Denna åtgärd är ännu inte implementerad i bytaTabPage\nKnappnamnet: " + namn;
                    break;
            }
        }

        /// <summary>
        /// Regnummersväljaren, om regnummrets värde är Ny bil visa fälten för bilinformation och sätt kundHarReggadBil till false
        /// Detta gör att när bokningen sen startas kommer man registrera bilen och sen boka den.
        /// 
        /// Om inte värdet är Ny bil så sätt kundHarReggadBil till true så att bokningen bara bokar bilen
        /// </summary>
        /// <param name="sender">Knapp-objekt som startade eventet</param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Funktion som körs när datumet ändras i kalendern. Extraherar den valda datetimen och
        /// gör om det till en sträng med bara datumet och skickar det till funktionen inti_panelTider
        /// </summary>
        /// <param name="sender">The button that called the event</param>
        /// <param name="e"></param>
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            dag = monthCalendar1.SelectionStart.Date.ToString();
            // Tar bort de onödiga och totalt förstörande sista nollorna efter datumet
            dag = dag.Substring(0, dag.IndexOf(' '));
            init_panelTider(dag);
        }
        
        /// <summary>
        /// Funktion som kontrollerar vilka tider som redan är upptagna i en speciell dag
        /// </summary>
        /// <param name="dag">Datumet som en sträng</param>
        private void init_panelTider(string dag)
        {
            input inmatning = new input();
            bool någonLedigTid = false;
            // Kolla om tiderna är bokade redan och gör alternativen ovalbara
            // Om ingen tid finns ledig, skriv det i meddelande-rutan
            if (!inmatning.kollaTidLedig(dag, "08:00 - 10:00"))
                timeButton_08.Enabled = false;
            else
            {
                någonLedigTid = true;
                timeButton_08.Enabled = true;
            }
            if (!inmatning.kollaTidLedig(dag, "10:00 - 12:00"))
                timeButton_10.Enabled = false;
            else
            {
                någonLedigTid = true;
                timeButton_10.Enabled = true;
            }
            if (!inmatning.kollaTidLedig(dag, "14:00 - 16:00"))
                timeButton_14.Enabled = false;
            else
            {
                någonLedigTid = true;
                timeButton_14.Enabled = true;
            }
            if (!inmatning.kollaTidLedig(dag, "16:00 - 18:00"))
                timeButton_16.Enabled = false;
            else
            {
                timeButton_16.Enabled = true;
                någonLedigTid = true;
            }
            if (!någonLedigTid)
            {
                if (DEBUG)
                    richTextBoxMeddelandenBoka.Text += "Tyvärr, det finns inga lediga tider på din valda dag. Var god välj en ny dag";
                else
                    richTextBoxMeddelandenBoka.Text = "Tyvärr, det finns inga lediga tider på din valda dag. Var god välj en ny dag";
            }
            panelTider.Show();
        }

        /// <summary>
        /// Väljer tiden ifrån tidspanelen och sätter den som en global variabel
        /// </summary>
        /// <param name="sender">Knappobjektet som startade eventet</param>
        /// <param name="e"></param>
        private void buttonValjTid_Click(object sender, EventArgs e)
        {
            if (timeButton_08.Checked)
                this.tid = "08:00";
            if (timeButton_10.Checked)
                this.tid = "10:00";
            if (timeButton_14.Checked)
                this.tid = "14:00";
            if (timeButton_16.Checked)
                this.tid = "16:00";
            buttonBoka.Show();
        }

        /// <summary>
        /// Funktin som fyller bokningarna och kundens fordon
        /// </summary>
        private void fyllBokningar_bilar()
        {
            boknings_objekt bokningar = new boknings_objekt(new SqlCeDatabase(), anvandare);
            bil_objekt fordon = new bil_objekt();

            SortedList<string, string>[] bokningsResultat = bokningar.hamtaMinaBokningar();
            int bilResultat = fordon.kollaKundsBilar(anvandare);

            if (bilResultat != 0)
            {
                this.tableLayoutPanelBilar.Hide();
                this.labelBilarMeddelande.Text = "Det finns inga bilar registrerade i systemet tryck på registrera för att registrera en bil";
                this.labelBilarMeddelande.Show();
            }

            if (bokningsResultat.Length == 0)
            {
                this.tableLayoutPanelBokningar.Hide();
                this.labelBokningarMeddelande.Text = "Du har inga bokade tider";
                this.labelBokningarMeddelande.Show();
            }

            if (this.tableLayoutPanelBilar.Visible)
            {
                SortedList<string, string>[] fordonLista = fordon.GetTmpMsgs(true);
                int length = fordonLista.Length;
                for (int i = 0; i < length; i++)
                {
                    SortedList<string, string> fordonsfält = fordonLista[i] as SortedList<string, string>;
                    Label labelBilarReg = new Label(), labelBilarMarke = new Label(), labelBilarModell = new Label(), labelBilarArsmodell = new Label();
                    Label[] labelBilar = { labelBilarReg, labelBilarMarke, labelBilarModell, labelBilarArsmodell };
                    for (int o = 0; o < 4; o++)
                    {
                        labelBilar[o].Text = fordonsfält[fordonsfält.Keys[o]];
                        this.tableLayoutPanelBilar.Controls.Add(labelBilar[o]);
                    }
                }
            }

            int lengthRes = bokningsResultat.Length;
            for (int i = 0; i < lengthRes; i++)
            {
                SortedList<string, string> bokningsString = bokningsResultat[i] as SortedList<string, string>;
                Label labelBokningDatum = new Label(), labelBokningBil = new Label(), labelBokningId = new Label();
                Label[] labelBokning = { labelBokningDatum, labelBokningBil, labelBokningId };
                for (int o = 0; o < 3; o++)
                {
                    switch (o)
                    {
                        case 0:
                            labelBokning[o].Text = bokningsString["datum"];
                            break;

                        case 1:
                            labelBokning[o].Text = bokningsString["bil"];
                            break;

                        case 2:
                            labelBokning[o].Text = "Ta bort";
                            labelBokning[o].Name = "Tabort_" + bokningsString["id"];
                            labelBokning[o].Cursor = System.Windows.Forms.Cursors.Hand;
                            labelBokning[o].Click += new System.EventHandler(this.TaBort);
                            break;
                    }
                    this.tableLayoutPanelBokningar.Controls.Add(labelBokning[o]);
                }
                this.tableLayoutPanelBokningar.Show();
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
            int bokning;
            if (!int.TryParse(namn, out bokning))
                MessageBox.Show("Detta är inget id: " + namn);
            else
            {
                boknings_objekt tabort = new boknings_objekt(new SqlCeDatabase(), this.anvandare);
                int TabortBokningar = tabort.tabortMinaBokningar(bokning);

                tableLayoutPanelBokningar.Controls.Clear();
                fyllBokningar_bilar();
            }
        }
    }
}