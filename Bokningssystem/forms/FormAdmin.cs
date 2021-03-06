﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bokningssystem
{
    public partial class FormAdmin : Form
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        administrator admin;

        public FormAdmin(administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        /// <summary>
        /// En funktion som switchar på namnet av ToolStripMenuItemet som startar den.
        /// Om man ändrar namnet på menuItem eller lägger till en ny får man lägga till dem här.
        /// Kommer skriva ut i en Messagebox om det inte finns någon implementerad funktion för det namnet (och om DEBUG = true).
        /// </summary>
        /// <param name="sender">ToolStripMenuItem som startade eventet, om det inte är en ToolStripMenuItem som startar så kommer funktionen säga det</param>
        /// <param name="e">EventArgs</param>
        private void MenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            SortedList<string, Panel> panels = new SortedList<string, Panel>();
            panels["visaBokningar"] = panelVisaBok; panels["läggTillHyrfordon"] = panelNyHyrfordon; panels["nyHyrning"] = panelNyHyr;
            // Kollar att det var en ToolStripMenuItem som startade eventet
            if (item == null)
            {
                string Msgs = string.Format("{0} är inte en ToolStripMenuItem och därför kan inte denna funktion fortsätta. \n" +
                                               "Var vänlig kontakta ansvarig för programmet", sender.ToString());
                MessageBox.Show(Msgs);
                return;
            }

            foreach (string key in panels.Keys)
                panels[key].Hide();

            switch (item.Name)
            {
                case "visaBokningar":
                    panels[item.Name].Show();
                    panelVisaBok.Enabled = true;
                    break;

                case "läggTillHyrfordon":
                    panels[item.Name].Show();
                    panelNyHyrfordon.Enabled = true;
                    break;
                
                case "omOss":
                    FormOmOss omOssForm = new FormOmOss(admin);
                    this.Hide();
                    omOssForm.ShowDialog();
                    this.Show();
                    break;

                case "nyHyrning":
                    panels[item.Name].Show();
                    panelNyHyr.Enabled = true;
                    break;

                case "visaHyrning":
                    MessageBox.Show("Ej implementerad ännu..");
                    break;
                // Skapa ett felmeddelande för alla case som inte uppfylls av något ovan
                default:
                    if (DEBUG)
                    {
                        string Msgs = string.Format("Det finns ingen implementerad funktion för {0}, var vänlig kontakta ansvarig för programmet.", item.Text);
                        MessageBox.Show(Msgs);
                    }
                    break;
            }
        }

        /// <summary>
        /// Eventhanterare för när monthCalendarBokning ändrar dag.
        /// Kommer aktivera panelBokdag och köra lite funktioner
        /// </summary>
        /// <param name="sender">monthCalendar som startade eventet</param>
        /// <param name="e">DateRangeEventArgs som skickas med Eventet</param>
        private void monthCalendarBokning_ChangedDays(object sender, DateRangeEventArgs e)
        {
            DateTime dag = e.Start;
            bokningar(dag);
            richTextBoxInfoBil.Hide();
            panelNyBok.Hide();
        }

        /// <summary>
        /// Hämtar alla bokningar under en viss dag
        /// </summary>
        private void bokningar(DateTime dag)
        {
            boknings_objekt bokningar = new boknings_objekt(new SqlCeDatabase(), this.admin);
            SortedList<string,string>[] allaBokningar;
            Label[] tider = { labelTid08, labelTid10, labelTid14, labelTid16 };
            
            allaBokningar = bokningar.hamtaAllaBokningar(dag.ToShortDateString());
            for (int i = 0; i < 4; i++)
            {
                tider[i].Click -= fordonsInfo;
                tider[i].Click -= label_Click;
                if (allaBokningar[i] == null)
                {                    
                    tider[i].Text = "Ledig";
                    tider[i].Click -= fordonsInfo;
                    tider[i].Click += new EventHandler(label_Click);
                    tider[i].Cursor = Cursors.Hand;
                }
                else
                {
                    tider[i].Text = allaBokningar[i]["bil"];
                    tider[i].Click += new EventHandler(fordonsInfo);
                    tider[i].Cursor = Cursors.Hand;
                }
                if (DEBUG)
                    richTextBoxFormAdminMsgs.Lines = bokningar.GetTmpMsgs();
                labelNyBokDag.Text = dag.ToShortDateString();
                labelDag.Text = string.Format("Det valda datumet är {0}", dag.ToShortDateString());
                panelBokDag.Show();
            }
        }

        /// <summary>
        /// Visar panelen för ny bokning
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            try
            {
                RichTextBox richLabel = (RichTextBox)sender;
                if (richLabel != null)
                {
                    if (richLabel.Name == "richTextBoxInfoBil")
                    {
                        string anvandare = richLabel.Lines[4].Substring(7);
                        FormProfil profil = new FormProfil(anvandare);
                        this.Hide();
                        profil.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch (System.InvalidCastException ex)
            {
                Label label = (Label)sender;
                if (label.Text == "Ledig")
                {
                    string tid = label.Name.Substring(8);
                    labelNyBokTid.Text = tid + ":00";
                    panelNyBok.Enabled = true;
                    this.panelNyBok.Show();
                }
            }               
        }

        /// <summary>
        /// Funktion som använder sig av hamtaValtFordon för att hämta information och sen skriver den fordonets information i richTextBoxInfoBil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void fordonsInfo(object sender, EventArgs e)
        {
            bil_objekt fordon = new bil_objekt();
            Label labelSender = sender as Label;
            string reg = labelSender.Text;

            SortedList<string, string> fetch = fordon.hamtaValtFordon(reg);
            string[] lines = { "Regnummer: " + fetch["reg"], "Märke: " + fetch["marke"],
                                 "Modell: " + fetch["modell"], "Årsmodell: " + fetch["arsmodell"], "Ägare: " + fetch["agare"] };
            richTextBoxInfoBil.Lines = lines;
            richTextBoxInfoBil.Show();
        }

        /// <summary>
        /// Bokar fordonet för kunden som är inskrivna i panelNyBok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBoka_Click(object sender, EventArgs e)
        {
            boknings_objekt bokningar = new boknings_objekt(new SqlCeDatabase(), this.admin);
            input nyKund = new input();
            string namn, tfn, persnnr, adress, email, reg, marke, modell, arsmodell, beskr, datum;
            namn = maskedTextBoxNamn.Text;
            tfn = maskedTextBoxTfn.Text;
            persnnr = maskedTextBoxPersnnr1.Text;
            adress = maskedTextBoxAdress1.Text;
            email = maskedTextBoxEmail1.Text;
            reg = maskedTextBoxReg.Text;
            marke = maskedTextBoxMarke.Text;
            modell = maskedTextBoxModell.Text;
            arsmodell = maskedTextBoxArsmodell.Text;
            beskr = richTextBoxBokMeddelande.Text;
            datum = labelNyBokDag.Text + " " + labelNyBokTid.Text;

            // Om något av de obligatoriska fälten är tomma avbryt
            if (namn == string.Empty | tfn == string.Empty | persnnr == string.Empty | adress == string.Empty | email == string.Empty | reg == string.Empty | marke == string.Empty | modell == string.Empty | arsmodell == string.Empty)
            {
                MessageBox.Show("Du måste fylla i alla fälten");
                return;
            }

            //Kollar om kundvärderna kan stämma
            MaskedTextBox[] inmatningsBoxar = { maskedTextBoxNamn, maskedTextBoxPersnnr1, maskedTextBoxEmail1, maskedTextBoxAdress1, maskedTextBoxTfn };
            string[] inmatVärden = nyKund.kollaInmatning(inmatningsBoxar);
            if (DEBUG && nyKund.GetTmpMsgs().Length > 0)
                {
                    string[] errorMsgs = nyKund.GetTmpMsgs();

                    foreach (string meddelande in errorMsgs)
                        richTextBoxMeddelanden.Text += meddelande + "\n";
                }

            int regResultat = nyKund.ReggaAdminKund(inmatVärden);
            if (regResultat == 0)
            {
                richTextBoxMeddelanden.Text = "Kunden registrerades utan problem!";
            }
            else
            {
                string[] felmeddelande = nyKund.GetTmpMsgs();
                if (felmeddelande.Contains("a duplicate value"))
                    richTextBoxMeddelanden.Text = "Det finns redan ett konto med denna emailadress eller med detta personnummer. " +
                        "\nKontrollera att du inte redan skapat ett konto.\n";
                else
                {
                   if (DEBUG)
                       richTextBoxMeddelanden.Text += felmeddelande[1]; // Index utanför matrixen... 
                   else
                       richTextBoxMeddelanden.Text += "Det blev ett fel när du skulle registreras.\nFörsök gärna lite senare.";
                }
            }

            string fnamn, enamn;
            if (namn.Contains(' '))
            {
                fnamn = namn.Substring(0,namn.IndexOf(' '));
                enamn = namn.Substring(namn.IndexOf(' '));
            }
            else
            {
                fnamn = namn;
                enamn = "";
            }
            if (bokningar.boka(fnamn, enamn, tfn, reg, datum, marke, modell, arsmodell, namn, beskr))
                richTextBoxFormAdminMsgs.Text = "Bokningen utfördes utan problem!";
            else
            {
                if (DEBUG)
                    richTextBoxFormAdminMsgs.Lines = bokningar.GetTmpMsgs();
                else
                    richTextBoxFormAdminMsgs.Text = "Det blev något fel med bokningen";
            }
            richTextBoxFormAdminMsgs.Show();
        }

        /// <summary>
        /// Lägger till hyrfordon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLäggTillFordon_Click(object sender, EventArgs e)
        {
            bil_objekt fordon = new bil_objekt();
            string reg, marke, modell, arsmodell, typ;
            reg = TextBoxReg.Text;
            marke = TextBoxMarke.Text;
            modell = TextBoxModell.Text;
            arsmodell = TextBoxArsmodell.Text;
            typ = checkedListBoxFordonsTyp.CheckedItems[0].ToString();

            int insertStatus = fordon.insertHyrFordon(reg, modell, arsmodell, marke, typ);
            if (insertStatus == 0)
                richTextBoxFormAdminMsgs.Text = "Fordonet lades till";
            else
            {
                string msgs = "Det blev ett fel när fordonet lades till";
                if (!DEBUG)
                    richTextBoxFormAdminMsgs.Text = msgs;
                else
                {
                    List<string> debugMsgs = new List<string>();
                    debugMsgs.Add(msgs);
                    debugMsgs.AddRange(fordon.GetTmpMsgs());
                    richTextBoxFormAdminMsgs.Lines = debugMsgs.ToArray();
                }
                richTextBoxFormAdminMsgs.Show();
            }          
        }
    }
}
