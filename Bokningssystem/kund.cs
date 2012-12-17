﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    public class kund
    {
        public bool DEBUG = Properties.Settings.Default.Debug;

        private string email, fnamn, enamn, losenord, tfn;
        static bool isAdmin;
        private string[] tmpMsgs;

        /// <summary>
        /// Konstruktören för klassen kund.
        /// Använder sig av databasen med tabellen kunder och hämtar fältvärden som email, förnamn, enamn, telefonnummer
        /// och kollar om det är en administratör.
        /// </summary>
        /// <param name="email">Email-adressen som ska användas</param>
        /// <param name="losen">Lösenordet, som en säkerhetsåtgärd</param>
        public kund(string email, string losen)
        {
            SqlCeDatabase db = new SqlCeDatabase();

            List<string> errorMsg = new List<string>();
            string query = "Select email, fnamn, enamn, losen ,isAdmin, tfn from Kunder where email='?x?'";
            string[] args = { email };
            if (db.query(query, args)[0] != "1")
                errorMsg.Add(db.query(query, args)[1]);
            else
            {
                string[] resultat = db.fetchAll();
                string[] properties = { this.email, this.fnamn, this.enamn, this.losenord, this.tfn };

                if (resultat[0] != string.Empty)
                    this.email = resultat[0];
                else
                    errorMsg.Add("Fältet för email-adressen är tomt");
                if (resultat[1] != string.Empty)
                    this.fnamn = resultat[1];
                else
                    errorMsg.Add("Fältet för förnamnet är tomt");
                if (resultat[2] != string.Empty)
                    this.enamn = resultat[2];
                else
                    errorMsg.Add("Fältet för efternamnet är tomt");
                if (resultat[3] != string.Empty)
                    this.losenord = resultat[3];
                else
                    errorMsg.Add("Fältet för lösenordet är tomt");
                isAdmin = !resultat[4].Equals("0");
                if (resultat[5] != string.Empty)
                    this.tfn = resultat[5];
                else
                    errorMsg.Add("Fältet för telefonnummret är tomt");
            }
            this.tmpMsgs = errorMsg.ToArray();
        }

        /// <summary>
        /// Funktion som hämtar namnet på kunden
        /// </summary>
        /// <returns>Namnet på personen / kunden</returns>
        public string GetNamn()
        {
            string namn = this.fnamn + " " + this.enamn;
            return namn;
        }

        /// <summary>
        /// Funktion som hämtar emailadressen på kunden
        /// </summary>
        /// <returns>Emailadressen till personen / kunden</returns>
        public string GetEmail()
        {
            return this.email;
        }

        /// <summary>
        /// Funktion som hämtar temporära felmeddelanden som lämnas av andra funktioner/metoder
        /// </summary>
        /// <returns>En strängarray som innehåller felmeddelanden och statuskoder.</returns>
        public string[] GetTmpMsgs()
        {
            string[] msgs;
            if (this.tmpMsgs.Length > 0)
            {
                msgs = this.tmpMsgs;
                this.tmpMsgs.Initialize();
            }
            else
            {
                msgs = new string[1];
                msgs[0] = "Det fanns inget att skicka";
            }
            return msgs;
        }

        /// <summary>
        /// Funktion som anger ett nytt namn till kunden
        /// </summary>
        /// <param name="value">Namnet som det ska ändras till</param>
        public void SetNamn(string value)
        {
            List<string> errorMsgs = new List<string>();
            string namn = value;
            string fornamn = namn.Substring(0, namn.IndexOf(' '));
            string efternamn = namn.Substring(namn.IndexOf(' '));

            string updateQuery = "UPDATE Kunder set fnamn='?x?', enamn='?x?' where email='?x?'";
            string[] args = { fornamn, efternamn, GetEmail() };
            SqlCeDatabase db = new SqlCeDatabase();
            string[] queryResultat = db.query(updateQuery, args);
            if (queryResultat[0] == "1")
            {
                string[] operationResult = db.operation();
                if (operationResult[0] != "1")
                {
                    errorMsgs.Add("Det blev ett fel med uppdateringen av din profil.");
                    if (DEBUG)
                        errorMsgs.AddRange(operationResult);
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel med frågestrukturen. Kontakta systemansvarig");
                if (DEBUG)
                    errorMsgs.AddRange(queryResultat);
            }
            this.fnamn = fornamn;
            this.enamn = efternamn;
        }

        /// <summary>
        /// Funktion som hämtar telefonnummret till kunden
        /// </summary>
        /// <returns>Telefonnummret till personen / kunden</returns>
        public string GetTfn()
        {
            return this.tfn;
        }
    }
}

