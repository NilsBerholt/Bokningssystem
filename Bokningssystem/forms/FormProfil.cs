using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bokningssystem.forms
{
    public partial class FormProfil : Form
    {
        private bool DEBUG = Properties.Settings.Default.Debug;
        private string uppdatera, nyttvarde;
        kund anvandare;

        /// <summary>
        /// Tom konstruktör
        /// </summary>
        public FormProfil()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Konstruktör för användare
        /// </summary>
        /// <param name="anvandare">Kundobjektet för vilken denna profil skapas</param>
        public FormProfil(kund anvandare)
        {
            this.anvandare = anvandare;
            InitializeComponent();
            initProfil();
        }

        /// <summary>
        /// Konstruktör för administratörer
        /// </summary>
        /// <param name="admin">Administratörsobjeketet för vilken denna profil skapas</param>
        public FormProfil(administrator admin)
        {
            this.anvandare = (kund)admin;
            InitializeComponent();
            initProfil();
        }

        /// <summary>
        /// Eventhandler som uför alla ändringar i profilen
        /// Om textboxen som startade eventet heter textBoxBekräfta kommer profilen uppdateras
        /// </summary>
        /// <param name="sender">Textboxen som startade eventet</param>
        /// <param name="e">Genererad eventinformation</param>
        private void textboxKeyEvent(object sender, KeyEventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (e.KeyCode != Keys.Return)
                return;

            // Se till att enterknappen inte skapar skumma karaktärer i texten
            e.SuppressKeyPress = true;

            string namn = textbox.Name.Substring(7);

            /* Om det inte var Bekräfta-Textboxen som startade eventet 
             * spara informationen i variabler och visa bekräfta-textboxen
             */
            if (namn != "Bekräfta")
            {
                this.uppdatera = namn;
                labelAvbryt.Visible = true;
                labelBekräfta.Visible = true;
                textBoxBekräfta.Visible = true;
                textBoxBekräfta.Focus();
                this.nyttvarde = textbox.Text;
                return;
            }
            /* Om det var bekräfta-textboxen som startade eventet */

            if (textbox.Text != anvandare.GetLosen())
            {
                label7.Visible = true;
                label7.Text = "Lösenorden stämde inte överens";
                return;
            }

            switch (this.uppdatera)
            {
                case "Namn":
                    if (anvandare.SetNamn(nyttvarde) == 0)
                        label7.Text = "Du har uppdaterat namnet";
                    else
                        label7.Text = "Det blev något fel vid uppdateringen av namnet";
                    break;

                case "Adress":
                    if (anvandare.SetAdress(nyttvarde) == 0)
                        label7.Text = "Du har uppdaterat adressen";
                    else
                        label7.Text = "Det blev något fel vid uppdateringen av adressen";
                    break;

                case "Email":
                    if (anvandare.SetEmail(nyttvarde) == 0)
                        label7.Text = "Du har uppdaterat e-postadressen";
                    else
                        label7.Text = "Det blev något fel vid uppdateringen av e-postadressen";
                    break;

                case "Tfn":
                    if (anvandare.SetTfn(nyttvarde) == 0)
                        label7.Text = "Du har uppdaterat telefonnumret";
                    else
                        label7.Text = "Det blev något fel vid uppdateringen av telefonnumret";
                    break;

                case "Losen":
                    if (anvandare.SetLosen(nyttvarde) == 0)
                        label7.Text = "Du har uppdaterat lösenordet";
                    else
                        label7.Text = "Det blev något fel vid uppdateringen av lösenordet";
                    break;

                default:
                    label7.Text = "Denna funktion har inte stöd för att ta emot inmatning från denna textbox";
                    break;
            }
            // Visa meddelanden
            label7.Visible = true;

            // Städa upp saker 
            initProfil();
        }

        /// <summary>
        /// Funktion som fyller textboxarna med profilens information
        /// </summary>
        public void initProfil()
        {
            textBoxNamn.Text = anvandare.GetNamn();
            textBoxEmail.Text = anvandare.GetEmail();
            textBoxAdress.Text = anvandare.GetAdress();
            textBoxTfn.Text = anvandare.GetTfn();

            textBoxBekräfta.Clear();
            textBoxBekräfta.Hide();
            labelBekräfta.Hide();
            labelAvbryt.Hide();
            panelRed.Hide();
            buttonBytLösen.Hide();
        }

        /// <summary>
        /// Aktiverar textboxarna för att byta lösenord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void initChangeLosen(object sender, EventArgs e)
        {
            panelRed.Show();
            buttonBytLösen.Show();

            maskedTextBoxGamla.Text = "Ditt gamla lösenord";
            maskedTextBoxGamla.UseSystemPasswordChar = true;
            maskedTextBoxGamla.Show();

            maskedTextBoxNytt.Text = "Ditt nya lösenord";
            maskedTextBoxNytt.UseSystemPasswordChar = true;
            maskedTextBoxNytt.Show();
        }

        /// <summary>
        /// Uppdaterar lösenordet till kunden, om man skrivit in rätt lösenord
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBytLösen_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            if (maskedTextBoxNytt.Text != string.Empty | maskedTextBoxGamla.Text != string.Empty)
            {
                string gammalt = anvandare.GetLosen();
                if (maskedTextBoxGamla.Text != gammalt)
                    return;

                if (anvandare.SetLosen(maskedTextBoxNytt.Text) == 0)
                {
                    label7.Text = "Du har uppdaterat ditt lösenord";
                    initProfil();
                }
            }
            else
                label7.Text = "Du måste fylla i både ditt gamla och ditt nya lösenord";
            label7.Visible = true;
        }

        /// <summary>
        /// Wrapper för buttonBytLösen_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void maskedTextBoxNyttKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                buttonBytLösen_Click((object)buttonBytLösen, new EventArgs());
        }

        /// <summary>
        /// Avbryter uppdateringenpå profilen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelAvbryt_Click(object sender, EventArgs e)
        {
            initProfil();
        }
    }
}
