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
    public partial class FormBoka : Form
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        private kund anvandare;
        private bool kundHarReggadBil;

        public FormBoka(kund anvandare)
        {
            InitializeComponent();
            SqlCeDatabase db = new SqlCeDatabase();
            this.anvandare = anvandare;

            string regQuery = "SELECT reg FROM fordon WHERE agare='?x?'";
            string[] args = { anvandare.GetEmail() };

            string[] queryResultat = db.query(regQuery, args);
            if (queryResultat[0] == "1")
            {
                string[] ny = { "Ny bil" };
                string[] fetchResultat = db.fetchAll();
                if (fetchResultat[0] != "fel")
                {
                    List<string> kundBilar = fetchResultat.ToList();
                    kundBilar.Add("Ny bil...");
                    kundHarReggadBil = true;
                    comboBoxReg.DataSource = kundBilar;
                }
                else
                {
                    kundHarReggadBil = false;
                    comboBoxReg.DataSource = ny;
                }
            }

            splitContainer1.Panel2Collapsed = true;
            richTextBoxMeddelandenBoka.Text = "Tryck på Ny bokning för att göra en ny bokning.\nTryck på Mina Bokningar för att se vad du har bokat och när.";
            if (DEBUG)
            {
                richTextBoxMeddelandenBoka.Text += "\nNamn: " + anvandare.GetNamn();
                richTextBoxMeddelandenBoka.Text += "\nEmail: " + anvandare.GetEmail();
            }
            
        }

        public void buttonBoka_Click(object sender, EventArgs e)
        {
            input inmatning = new input();
            
            DateTime datum = DateTime.Now;
            string regnr = comboBoxReg.Text;
            if (kundHarReggadBil)
            {
                if (inmatning.boka(this.anvandare, regnr, datum))
                    richTextBoxMeddelandenBoka.Text = "Bokningen genomfördes utan problem";
                else
                {
                    richTextBoxMeddelandenBoka.Text = "Det blev något fel med bokningen";
                    string[] felmeddelande = inmatning.GetTmpMsgs();
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
            else
            {
                string modell = textBoxModell.Text;
                string marke = textBoxMarke.Text;
                string arsmodell = textBoxArsModell.Text;
                if (inmatning.boka(this.anvandare, regnr, datum, marke, modell, arsmodell))
                    richTextBoxMeddelandenBoka.Text = "Bokningen genomfördes utan problem";
                else
                {
                    richTextBoxMeddelandenBoka.Text = "Det blev något fel med bokningen";
                    string[] felmeddelande = inmatning.GetTmpMsgs();
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
        }

        private void buttonNyBoka_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = false;
            if (kundHarReggadBil)
                panelNyBil.Hide();
        }

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
    }
}
