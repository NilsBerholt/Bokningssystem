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

        public FormAdmin(administrator admin)
        {
            InitializeComponent();
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

        }
        private void bokningar()
        {


            
        }
    }
}
