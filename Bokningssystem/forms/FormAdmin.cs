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

            // Kollar att det var en ToolStripMenuItem som startade eventet
            if (item == null)
            {
                string Msgs = string.Format("{0} är inte en ToolStripMenuItem och därför kan inte denna funktion fortsätta. \n" +
                                               "Var vänlig kontakta ansvarig för programmet", sender.ToString());
                MessageBox.Show(Msgs);
                return;
            }

            switch (item.Name)
            {
                case "visaBokningar":
                    panelVisaBok.Enabled = true;
                    panelVisaBok.Show();
                    break;

                case "läggTillHyrfordon":
                    panelNyHyrfordon.Enabled = true;
                    panelNyHyrfordon.Show();
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
        }

        /// <summary>
        /// Hämtar alla bokningar under en viss dag
        /// </summary>
        private void bokningar(DateTime dag)
        {
            boknings_objekt bokningar = new boknings_objekt(new SqlCeDatabase(), this.admin);
            Array[] allaBokningar;
            Label[] tider = { labelTid08, labelTid10, labelTid14, labelTid16 };

            allaBokningar = bokningar.hamtaAllaBokningar(dag.ToShortDateString());
            if (allaBokningar.Length == 1)
            {
                if (DEBUG)
                    richTextBoxFormAdminMsgs.Lines = bokningar.GetTmpMsgs();
                foreach (Label label in tider)
                {
                    label.Text = "Ledig";
                    label.Click += new EventHandler(label_Click);
                    label.Cursor = Cursors.Hand;
                }
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
            Label label = (Label)sender;
            string tid = label.Name.Substring(8);
            labelNyBokTid.Text = tid + ":00";
            panelNyBok.Enabled = true;
            this.panelNyBok.Show();
        }

        /// <summary>
        /// Bokar fordonet för kunden som är inskrivna i panelNyBok
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBoka_Click(object sender, EventArgs e)
        {
            boknings_objekt bokningar = new boknings_objekt(new SqlCeDatabase(), this.admin);
            string namn, tfn, reg, marke, modell, arsmodell, beskr, datum;
            namn = maskedTextBoxNamn.Text;
            tfn = maskedTextBoxTfn.Text;
            reg = maskedTextBoxReg.Text;
            marke = maskedTextBoxMarke.Text;
            modell = maskedTextBoxModell.Text;
            arsmodell = maskedTextBoxArsmodell.Text;
            beskr = richTextBoxBokMeddelande.Text;
            datum = labelNyBokDag.Text + " " + labelNyBokTid.Text;

            // Om något av de obligatoriska fälten är tomma avbryt
            if (namn == string.Empty | tfn == string.Empty | reg == string.Empty | marke == string.Empty | modell == string.Empty | arsmodell == string.Empty)
            {
                MessageBox.Show("Du måste fylla i alla fälten");
                return;
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
            if (bokningar.boka(fnamn, enamn, tfn, reg, datum, marke, modell, arsmodell, namn))
                richTextBoxFormAdminMsgs.Text = "Bokningen utfördes utan problem!";
            else
            {
                if (DEBUG)
                    richTextBoxFormAdminMsgs.Lines = bokningar.GetTmpMsgs();
                else
                    richTextBoxFormAdminMsgs.Text = "Det blev något fel med bokningen";
                
                richTextBoxFormAdminMsgs.Show();
            }
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
