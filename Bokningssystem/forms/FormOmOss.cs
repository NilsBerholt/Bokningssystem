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
    public partial class FormOmOss : Form
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        private kund anvandare;
        private administrator admin;
        private foretag företag;

        /// <summary>
        /// Konstruktör för FormOmOss när en admin skapar formen
        /// </summary>
        /// <param name="admin">Adminobjektet som skapade formuläret</param>
        public FormOmOss(administrator admin)
        {
            InitializeComponent();
            TextBox[] textboxar = { textBoxNamn, textBoxEmail, textBoxTelefon, textBoxOppetider, textBoxPostAdress, textBoxAdress };
            this.admin = admin;
            initFormOmOss();

            // RichTextBoxOmOss properties
            richTextBoxOmOss.ReadOnly = false;
            richTextBoxOmOss.Cursor = Cursors.IBeam;
            richTextBoxOmOss.BackColor = SystemColors.ControlLightLight;
            richTextBoxOmOss.BorderStyle = BorderStyle.Fixed3D;
            richTextBoxOmOss.KeyDown += new KeyEventHandler(this.richTextBoxKnappTryck);

            richTextBoxOmOssMsgs.Text = "För att ändra på något värde: \n1. Klicka i textrutan \n2. Ändra värdet \n3. Spara genom att trycka på ENTER";

            // Alla informations textboxar som alla har samma egenskaper
            foreach (TextBox textbox in textboxar)
            {
                textbox.BackColor = SystemColors.ControlLightLight;
                textbox.BorderStyle = BorderStyle.Fixed3D;
                textbox.Enabled = true;
                textbox.ReadOnly = false;
                textbox.Cursor = Cursors.IBeam;
                textbox.KeyDown += new KeyEventHandler(this.textBoxKnapptryck);
                textbox.Multiline = true;
                textbox.WordWrap = true;
            }
            
        }

        /// <summary>
        /// Konstruktör för FormOmOss när en kund skapar formen
        /// </summary>
        /// <param name="användare">Kundobjektet som skapade formuläret</param>
        public FormOmOss(kund användare)
        {
            InitializeComponent();
            TextBox[] textboxar = { textBoxNamn, textBoxEmail, textBoxTelefon, textBoxOppetider, textBoxPostAdress, textBoxAdress };
            this.anvandare = användare;
            initFormOmOss();

            richTextBoxOmOss.ReadOnly = true;
            richTextBoxOmOss.Cursor = Cursors.Default;

            foreach (TextBox textbox in textboxar)
            {
                textbox.Enabled = false;
                textbox.ReadOnly = true;
                textbox.Cursor = Cursors.Default;
                textbox.WordWrap = true;
            }

        }

        /// <summary>
        /// Initierar textboxarnas värden med information från företags-objektet
        /// </summary>
        private void initFormOmOss()
        {
            företag = new foretag(1);
            textBoxNamn.Text = företag.GetNamn();
            textBoxEmail.Text = företag.GetEmail();
            textBoxOppetider.Text = företag.GetOppetider();
            textBoxPostAdress.Text = företag.GetPostAdr();
            textBoxTelefon.Text = företag.GetTfn();
            textBoxAdress.Text = företag.GetAdress();
            richTextBoxOmOss.Text = företag.GetInfo();
        }

        /// <summary>
        /// KeyPressEventHandler som tar hand om keyPressEvents.
        /// Denna är gjord för att spara informationen som matas in i textboxarnas fält av en administratör
        /// </summary>
        /// <param name="sender">TextBoxen (eller annan control som har keyPressEvent) som startade eventet</param>
        /// <param name="e">Intressant info som genereras av eventet</param>
        private void textBoxKnapptryck(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Return)
                return;
            
            // Se till att inga nya rader skapas
            e.SuppressKeyPress = true;

            input inmatning = new input();
            TextBox textbox = sender as TextBox;
            if (textbox == null)
                throw new Exception("Objektet som startade eventet textBoxKnappTryck var inte en TextBox.");
            string namn = textbox.Name.Substring(7);
            string nyttVarde = null;
            string gammaltVarde = null;
            textbox.Text = textbox.Lines[0];

            switch (namn)
            {
                case "Namn":
                    nyttVarde = textbox.Lines[0];
                    gammaltVarde = företag.GetNamn();
                    break;

                case "Email":
                    if (inmatning.kollaEmail(textbox.Lines[0]))
                    {
                        nyttVarde = textbox.Lines[0];
                        gammaltVarde = företag.GetEmail();
                    }
                    break;

                case "Oppetider":
                    nyttVarde = textbox.Lines[0];
                    gammaltVarde = företag.GetOppetider();
                    break;

                case "Telefon":
                    if (inmatning.kollaTfnNummer(textbox.Lines[0]))
                    {
                        nyttVarde = textbox.Lines[0];
                        gammaltVarde = företag.GetTfn();
                    }
                    break;

                case "Adress":
                    nyttVarde = textbox.Lines[0];
                    gammaltVarde = företag.GetAdress();
                    break;

                case "Postadress":
                    nyttVarde = textbox.Lines[0];
                    gammaltVarde = företag.GetPostAdr();
                    break;

                default:
                    if (DEBUG)
                        MessageBox.Show(string.Format("Denna textbox är ännu inte implementerad i funktionen textBoxKnapptryck, kontakta programansvarig." +
                            " \nInformation: Textboxen {0} är inte implementerad i textBoxKnapptryck, eller så har den fel KeyEvent", textbox.Name));
                    return;
            }

            if (nyttVarde == gammaltVarde)
            {
                initFormOmOss();
                return;
            }

            // Uppdatera företaget med de nya värdena på fältet
            if (företag.SetFalt(namn,nyttVarde) == 0)
                richTextBoxOmOssMsgs.Text = string.Format("Du har nu uppdaterat företagets {0} från {1} till {2}",namn.ToLower(),gammaltVarde,nyttVarde);
            else
            {
                // Gör om string-arrayen till en enda lång string
                string[] tmpMsgs = företag.GetTmpMsgs();
                string allaMsgs = string.Empty;
                foreach (string msg in tmpMsgs)
                    allaMsgs += msg + "\n";

                // Visa felmeddelandena / t i en MessageBox
                richTextBoxOmOssMsgs.Text = string.Format("Uppdateringen av fält {0} lyckades inte, nedan finns mer information. "+
                                            "Detaljer: {1}",namn.ToLower(), allaMsgs);
            }

            // Ta bort fula nyrader
            initFormOmOss();
        }

        /// <summary>
        /// Aktiverar sparaknappen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void richTextBoxKnappTryck(object sender, KeyEventArgs e)
        {
            this.buttonSpara.Enabled = true;
            this.buttonSpara.Visible = true; 
        }

        /// <summary>
        /// Sparar informationen om företaget som skrivits in i richTextBoxOmOss
        /// </summary>
        /// <param name="sender">Objektet som startade eventet</param>
        /// <param name="e">Eventinformation som genereras a eventet</param>
        private void buttonSparaTryck(object sender, EventArgs e)
        {
            foretag företag = new foretag(1);

            string företagsInfo = företag.GetInfo();
            string nyInfo = richTextBoxOmOss.Text;

            // Gör inget om det inte har ändrats något
            if (företagsInfo == richTextBoxOmOss.Text)
                return;

            // Skriv ut eventuella felmeddelanden
            if (företag.SetFalt("Information", nyInfo) != 0)
            {
                richTextBoxOmOssMsgs.Lines = företag.GetTmpMsgs();
                return;
            }

            // Skriv ut att uppdateringen gick bra
            richTextBoxOmOssMsgs.Text = "Du har nu uppdaterat företagets information";

            // Döljer spara knappen
            this.buttonSpara.Enabled = false;
            this.buttonSpara.Visible = false; 

            // "Ladda om" vyn
            initFormOmOss();
        }
    }
}
