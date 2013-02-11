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
            buttonLogga.Hide();
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
            List<string> errorMsg = new List<string>();
            input inmatning = new input();
            if (textBoxEmailLogin.Text == "" | textBoxLosenLogin.Text == "")
                errorMsg.Add("Du måste skriva in både email och lösenord för att logga in.");
            else
            {
                if (inmatning.loggaIn(textBoxEmailLogin.Text, textBoxLosenLogin.Text))
                {
                    kund anvandare = new kund(textBoxEmailLogin.Text, textBoxLosenLogin.Text);
                    FormBoka minBokning = new FormBoka(anvandare);
                    FormHyra minHyrning = new FormHyra(anvandare);
                    minBokning.Enabled = true;
                    this.Hide();
                    if (radioButtonLaga.Checked)
                        minBokning.ShowDialog();
                    else
                        minHyrning.ShowDialog();
                    this.Show();
                }
                else
                {
                    string[] felmeddelande = inmatning.GetTmpMsgs();
                    foreach (string msg in felmeddelande)
                        richTextBoxMeddelanden1.Text += msg;
                }
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
                if (DEBUG && inmatning.GetTmpMsgs().Length > 0)
                {
                    string[] errorMsgs = inmatning.GetTmpMsgs();

                    foreach (string meddelande in errorMsgs)
                        richTextBoxMeddelanden.Text += meddelande + "\n";
                }
                int regResultat = inmatning.ReggaKund(inmatVärden);
                if (regResultat == 0)
                {
                    if (DEBUG)
                        richTextBoxMeddelanden.Text += "Ditt konto registrerades utan problem!\nDu kan nu logga in.";
                    else
                        richTextBoxMeddelanden1.Text = "Ditt konto registrerades utan problem!\nDu kan nu logga in.";
                    splitContainer1.Panel2Collapsed = true;
                }
                else
                {
                    string[] felmeddelande = inmatning.GetTmpMsgs();
                    if (felmeddelande.Contains("a duplicate value"))
                        richTextBoxMeddelanden.Text = "Det finns redan ett konto med denna emailadress eller med detta personnummer. " +
                            "\nKontrollera att du inte redan skapat ett konto.\n";
                    else
                    {
                        if (DEBUG)
                            richTextBoxMeddelanden.Text += felmeddelande[1];
                        else
                            richTextBoxMeddelanden.Text += "Det blev ett fel när du skulle registreras.\nFörsök gärna lite senare.";
                    }
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

            int kollaQuery = db.query(queryVisa, args);
            if (kollaQuery != 0)
            {
                string[] läsResultat = db.fetch();

                if (läsResultat.Length > 0)
                {
                    string FullResultat = string.Empty;
                    foreach (string resultat in läsResultat)
                        FullResultat += resultat + "\n";
                    MessageBox.Show(FullResultat);
                }
            }
            else
                richTextBoxMeddelanden.Text = db.GetTmpMsgs()[0];
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

        private void radioButtonHyra_CheckedChanged(object sender, EventArgs e)
        {
            buttonLogga.Show();
        }

        private void radioButtonLaga_CheckedChanged(object sender, EventArgs e)
        {
            buttonLogga.Show();
        }
    }
}