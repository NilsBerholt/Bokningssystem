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
        private string uppdatera = null;
        private string dag = "";
        private string tid = "";

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
        
        public void DoljBokningar()
        {
            timeButton_08.Checked = false;
            timeButton_10.Checked = false;
            timeButton_14.Checked = false;
            timeButton_16.Checked = false;
            panelTider.Hide();
            buttonBoka.Hide();
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

            // Initiera profilvariablerna från kund objektet
            labelNamn.Text = anvandare.GetNamn();
            labelEmail.Text = anvandare.GetEmail();
            labelTfn.Text = anvandare.GetTfn();
            labelAdress.Text = anvandare.GetAdress();

            // Fixar så man bara kan välja ett datum i monthCalendar1.
            monthCalendar1.MaxSelectionCount = 1;
            DoljAndringar();
            panelTider.Hide();
            buttonBoka.Hide();

            richTextBoxBokningMeny.Text = "Tryck på Ny bokning för att göra en ny bokning.\nTryck på Mina Bokningar för att se vad du har bokat och när.";
            if (DEBUG)
            {
                richTextBoxBokningMeny.Text += "\nNamn: " + anvandare.GetNamn();
                richTextBoxBokningMeny.Text += "\nEmail: " + anvandare.GetEmail();
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

            if (dag != "" & tid != "")
            {
                // Formatterar datumet och hämtar regnumret
                string datum = dag + " " + tid;
                string regnr = comboBoxReg.Text;
                // Om det är en reggad bil som är markerad, boka bara bilen på datumet och tiden
                if (this.kundHarReggadBil)
                {
                    if (bokning.boka(this.anvandare, regnr, datum))
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
                    if (bokning.boka(this.anvandare, regnr, datum, marke, modell, arsmodell))
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
            string namn = tabButton.Name;
            namn = namn.Substring(6);

            switch (namn)
            {
                case "NyBoka":
                    tabControl1.SelectTab(tabPageNyBok);
                    monthCalendar1.SelectionStart = DateTime.Today;
                    richTextBoxMeddelandenBoka.Text = "Du måste välj datum och tid innan du kan boka.";
                    DoljBokningar();
                    break;

                case "MinBok":
                    labelBilarMeddelande.Text = "";
                    labelBokningarMeddelande.Text = "";
                    tabControl1.SelectTab(tabPageMinBok);
                    tableLayoutPanelBilar.Controls.Clear();
                    tableLayoutPanelBokningar.Controls.Clear();
                    this.fyllBokningar_bilar();
                    break;

                case "Profil":
                    tabControl1.SelectTab(tabPageProfil);
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

        private void fyllBokningar_bilar()
        {
            boknings_objekt bokningar = new boknings_objekt(new SqlCeDatabase(), anvandare);
            bil_objekt fordon = new bil_objekt();

            Array[] bokningsResultat = bokningar.hamtaMinaBokningar();
            int bilResultat = fordon.kollaKundsBilar(anvandare);

            if (bilResultat != 0)
            {
                this.tableLayoutPanelBilar.Hide();
                this.labelBilarMeddelande.Text = "Det finns inga bilar registrerade i systemet tryck på registrera för att registrera en bil";
                this.labelBilarMeddelande.Show();
            }

            if (bokningsResultat.Length < 1)
            {
                this.tableLayoutPanelBokningar.Hide();
                this.labelBokningarMeddelande.Text = "Du har inga bokade tider";
                this.labelBokningarMeddelande.Show();
            }

            if (this.tableLayoutPanelBilar.Visible)
            {
                Array[] fordonLista = fordon.GetTmpMsgs(true);
                int length = fordonLista.Length;
                for (int i = 0; i < length; i++)
                {
                    string[] fordonsfält = fordonLista[i] as string[];
                    Label labelBilarReg = new Label(), labelBilarMarke = new Label(), labelBilarModell = new Label(), labelBilarArsmodell = new Label();
                    Label[] labelBilar = { labelBilarReg, labelBilarMarke, labelBilarModell, labelBilarArsmodell };
                    for (int o = 0; o < 4; o++)
                    {
                        labelBilar[o].Text = fordonsfält[o];
                        this.tableLayoutPanelBilar.Controls.Add(labelBilar[o]);
                    }
                }
            }
            if (this.tableLayoutPanelBokningar.Visible)
            {
                int length = bokningsResultat.Length;
                for (int i = 0; i < length; i++)
                {
                    string[] bokningsString = bokningsResultat[i] as string[];
                    Label labelBokningDatum = new Label(), labelBokningTid = new Label(), labelBokningFordon = new Label();
                    Label[] labelBokning = { labelBokningDatum, labelBokningTid, labelBokningFordon };
                    for (int o = 0; o < 3; o++)
                    {
                        labelBokning[o].Text = bokningsString[o];
                        this.tableLayoutPanelBokningar.Controls.Add(labelBokning[o]);
                    }
                }
            }
        }
    }
}