using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    class Hyrnings_objekt
    {
        private bool DEBUG = Properties.Settings.Default.Debug;
        private SqlCeDatabase db;
        private kund anvandare;
        private string[] tmpMsgs;
        private Array[] tmpMsgsArray = null;

        /// <summary>
        /// Kontruktören för boknings_objekt, tar en SqlCeDatabase och en kund som parametrar
        /// </summary>
        /// <param name="db">SqlCeDatabase som ska användas för databasen</param>
        /// <param name="anvandare">kunden som bokar</param>
        public Hyrnings_objekt(SqlCeDatabase db, kund anvandare)
        {
            this.anvandare = anvandare;
            this.db = db;
        }

        /// <summary>
        /// Denna funktion hämtar alla meddelanden som finns lagrade i sträng-arrayen tmpMsgs
        /// </summary>
        /// <returns>Skickar arrayen om den har något innehåll, annars en array med ett element som säger att det är tomt.</returns>
        public string[] GetTmpMsgs()
        {
            if (this.tmpMsgs != null)
                return this.tmpMsgs;
            else
            {
                string[] meddelande = { };
                return meddelande;
            }
        }

        /// <summary>
        /// Denna funktion hämtar alla meddelanden som finns lagrade i sträng-arrayen tmpMsgs
        /// </summary>
        /// <returns>Skickar arrayen om den har något innehåll, annars en array med ett element som säger att det är tomt.</returns>
        public Array[] GetTmpMsgs( bool array )
        {
            if (this.tmpMsgs != null)
                return this.tmpMsgsArray;
            else
            {
                Array[] meddelande = { };
                return meddelande;
            }
        }

        public bool hyra(kund anvandare, string startdag, string slutdag, string fordon)
        {
            List<string> errorMsgs = new List<string>();
            SqlCeDatabase db = new SqlCeDatabase();
            string agare = anvandare.GetEmail();

            string query = "INSERT INTO Hyrning " +
               "(Fordon, Startdag, Slutdag, Kund) " +
               "VALUES  ('?x?','?x?','?x?','?x?')";
            string[] args = new string[4] { fordon, startdag, slutdag, agare  };

            if (db.query(query, args) == 0)
            {
                int opResultat = db.operation();
                if (opResultat == 0)
                    return true;
                else
                {
                    errorMsgs.Add("Det blev något fel när din bokning skulle processeras. Kontakta ansvarig för programmet");
                    if (DEBUG)
                        errorMsgs.AddRange(this.db.GetTmpMsgs());
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel vid skapandet av frågan. Kontakta ansvarig för programmet.");
                if (DEBUG)
                    errorMsgs.AddRange(this.db.GetTmpMsgs());
            }

            if (errorMsgs.Count > 0)
            {
                this.tmpMsgs = errorMsgs.ToArray();
            }
            return false;
        }

        /// <summary>
        /// Hämtar hyrningarna för kunden som är registrerad i Hyrnings_objektetet.
        /// Hämtar värdena startdatum,  i den ordningen
        /// </summary>
        /// <returns>Returnerar en string[] med alla träffar, om det inte fanns några träffar skickar den </returns>
        public Array[] hamtaMinaHyrningar()
        {
            List<string> errorMsgs = new List<string>();
            Array[] fetch;
            string queryHamtaHyrningar = "SELECT Hyrning, Startdag, Fordon, Slutdag, Kund " +
            "FROM Hyrning WHERE (Kund = '?x?')";
            string[] args = { this.anvandare.GetEmail() };

            int queryRes = this.db.query(queryHamtaHyrningar, args);
            if (queryRes == 0)
            {
                fetch = this.db.fetchAll();
                if (fetch.Length > 0)
                    return fetch;
            }
            errorMsgs.AddRange(db.GetTmpMsgs());
            this.tmpMsgs = errorMsgs.ToArray();
            Array[] res = { };
            return res;
        }

        /// <summary>
        /// Hämtar hyrningarna för kunden som är registrerad i Hyrnings_objektetet.
        /// Hämtar värdena startdatum,  i den ordningen
        /// </summary>
        /// <returns>Returnerar en string[] med alla träffar, om det inte fanns några träffar skickar den </returns>
        public Array[] tabortMinaHyrningar(int hyrning)
        {
            string Hyrning = Convert.ToString(hyrning);
            List<string> errorMsgs = new List<string>();
            Array[] fetch;
            string queryTabortHyrningar = "DELETE * " +
            "FROM Hyrning WHERE (Hyrning = '?x?')";
            string[] args = { Hyrning };

            int queryRes = this.db.query(queryTabortHyrningar, args);
            if (queryRes == 0)
            {
                fetch = this.db.fetchAll();
                if (fetch.Length > 0)
                    return fetch;
            }
            errorMsgs.AddRange(db.GetTmpMsgs());
            this.tmpMsgs = errorMsgs.ToArray();
            Array[] res = { };
            return res;
        }
    }
}
