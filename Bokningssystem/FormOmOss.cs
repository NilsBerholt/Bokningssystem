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
            TextBox[] textboxar = { textBoxNamn, textBoxEmail, textBoxTelefon, textBoxOppetider, textBoxPostAdress };
            this.admin = admin;
            initFormOmOss();

            richTextBoxOmOss.ReadOnly = false;
            richTextBoxOmOss.Cursor = Cursors.IBeam;
            foreach (TextBox textbox in textboxar)
            {
                textbox.Enabled = true;
                textbox.ReadOnly = false;
                textbox.Cursor = Cursors.IBeam;
                textbox.KeyPress += new KeyPressEventHandler(this.textBoxKnapptryck);
                textbox.Multiline = false;
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
            TextBox[] textboxar = { textBoxNamn, textBoxEmail, textBoxTelefon, textBoxOppetider, textBoxPostAdress };
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
        }

        /// <summary>
        /// KeyPressEventHandler som tar hand om keyPressEvents.
        /// Denna är gjord för att spara informationen som matas in i textboxarnas fält av en administratör
        /// </summary>
        /// <param name="sender">TextBoxen (eller annan control som har keyPressEvent) som startade eventet</param>
        /// <param name="e">Intressant info som genereras av eventet</param>
        private void textBoxKnapptryck(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return)
                return;

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
                MessageBox.Show(string.Format("Du har nu uppdaterat företagets {0} från {1} till {2}",namn.ToLower(),gammaltVarde,nyttVarde));
            else
            {
                // Gör om string-arrayen till en enda lång string
                string[] tmpMsgs = företag.GetTmpMsgs();
                string allaMsgs = string.Empty;
                foreach (string msg in tmpMsgs)
                    allaMsgs += msg + "\n";

                // Visa felmeddelandena / t i en MessageBox
                MessageBox.Show(string.Format("Uppdateringen av fält {0} lyckades inte, nedan finns mer information. "+
                                            "Detaljer: {1}",namn.ToLower(), allaMsgs));
            }

            // Ta bort fula nyrader
            initFormOmOss();
        }
    }
}
