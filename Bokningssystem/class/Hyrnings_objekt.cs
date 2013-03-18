using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    class hyrnings_objekt
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
        public hyrnings_objekt(SqlCeDatabase db, kund anvandare)
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

        /// <summary>
        /// Funktion som skapar en hyrning efter parametrarna, 
        /// den bokar första lediga fordon av rätt typ till användaren under de valda dagarna.
        /// </summary>
        /// <param name="anvandare">Kunden som begärt hyrningen</param>
        /// <param name="startdag">Datumet då hyrningen börjar</param>
        /// <param name="slutdag">Datumet då hyrningen slutar</param>
        /// <param name="fordon">Regnumret till fordonet som hyrts</param>
        /// <returns></returns>
        public bool hyra(kund anvandare, string startdag, string slutdag, string fordon)
        {
            List<string> errorMsgs = new List<string>();
            SqlCeDatabase db = new SqlCeDatabase();
            string kund = anvandare.GetEmail();

            string query = "INSERT INTO Hyrning " +
               "(Fordon, Startdag, Slutdag, Kund) " +
               "VALUES  ('?x?','?x?','?x?','?x?')";
            string[] args = new string[4] { fordon, startdag, slutdag, kund  };

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
        public SortedList<string,string>[] hamtaMinaHyrningar()
        {
            List<string> errorMsgs = new List<string>();
            SortedList<string, string>[] fetch;
            string queryHamtaHyrningar = "SELECT H.Startdag, H.Fordon, H.Slutdag, F.typ, F.marke, F.modell, H.Hyrning " +
            "FROM Hyrning as H INNER JOIN HyrFordon as F ON H.Fordon = F.regnr WHERE (H.Kund = '?x?')";
            string[] args = { this.anvandare.GetEmail() };

            int queryRes = this.db.query(queryHamtaHyrningar, args);
            if (queryRes == 0)
            {
                fetch = this.db.fetchAllList();
                if (fetch.Length > 0)
                    return fetch;
            }
            errorMsgs.AddRange(db.GetTmpMsgs());
            this.tmpMsgs = errorMsgs.ToArray();
            SortedList<string, string>[] res = { };
            return res;
        }

        /// <summary>
        /// Tar bort hyrningar med identiteten hyrning
        /// </summary>
        /// <param name="hyrning">Hyrningens identitet</param>
        /// <returns>Statuskod för funktionen
        /// 0 - funktionen utfördes utan problem
        /// Allt annat - fel</returns>
        public int tabortMinaHyrningar(int hyrning)
        {
            string Hyrning = Convert.ToString(hyrning);
            List<string> errorMsgs = new List<string>();
            //Array[] fetch;
            string queryTabortHyrningar = "DELETE " +
            "FROM Hyrning WHERE (Hyrning = '?x?')";
            string[] args = { Hyrning };

            int queryRes = this.db.query(queryTabortHyrningar, args);
            if (queryRes == 0)
            {
                if (db.operation() == 0)
                {
                    int resultat = 0;
                    return resultat;
                }
                else
                {
                    return db.operation();
                }
            }
            else
                return db.query(queryTabortHyrningar, args);
        }
    }
}
