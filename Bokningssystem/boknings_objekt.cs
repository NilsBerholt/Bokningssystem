using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    class boknings_objekt
    {
        private bool DEBUG = Properties.Settings.Default.Debug;
        private SqlCeDatabase db;
        private kund anvandare;
        private string[] tmpMsgs;

        /// <summary>
        /// Kontruktören för boknings_objekt, tar en SqlCeDatabase och en kund som parametrar
        /// </summary>
        /// <param name="db">SqlCeDatabase som ska användas för databasen</param>
        /// <param name="anvandare">kunden som bokar</param>
        public boknings_objekt(SqlCeDatabase db, kund anvandare)
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
        /// Bokar tid för fordonet i databasen, bokar in fordonet som endast registreringsnummer så denna
        /// funktion förutsätter att bilen är registrerad.
        /// Lämnar kvar felmeddelande i tmpMsgs-arrayen.
        /// </summary>
        /// <param name="anvandare">Kunden / administratörens kundobjekt</param>
        /// <param name="regnr">Fordonets registreringsnummer</param>
        /// <param name="datum">Datumet som bokningen gäller</param>
        /// <returns>Returnerar true om allt gick som det skulle eller falskt annars.</returns>
        public bool boka(kund anvandare, string regnr, string datum)
        {
            List<string> errorMsgs = new List<string>();
            SqlCeDatabase db = new SqlCeDatabase();
            string agare = anvandare.GetEmail();

            string namn = anvandare.GetNamn();
            string fnamn = namn.Substring(0, namn.IndexOf(' '));
            string enamn = namn.Substring(namn.IndexOf(' ') + 1);
            string tfn = anvandare.GetTfn();

            string query = "INSERT INTO Bokning " +
               "(datum, fnamn, enamn, bil, email, tfn) " +
               "VALUES  ('?x?','?x?','?x?','?x?', '?x?', '?x?')";
            string[] args = new string[6] { datum, fnamn, enamn, regnr, agare, tfn };

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
        /// Bokar tid för fordonet i databasen, bokar in fordonet och registrerar samtidigt bilen med den 
        /// nuvarande kunden som ägare. Lämplig att använda om bilen inte är registrerad.
        /// Lämnar kvar felmeddelande i tmpMsgs-arrayen.
        /// </summary>
        /// <param name="anvandare">Kunden / administratörens kundobjekt</param>
        /// <param name="regnr">Fordonets registreringsnummer</param>
        /// <param name="datum">Datumet som bokningen gäller</param>
        /// <param name="marke">Märket på fordonet</param>
        /// <param name="modell">Modellen på fordonet</param>
        /// <param name="arsmodell">Årsmodellen på fordonet</param>
        /// <returns>Returnerar true om allt gick som det ska eller falskt annars</returns>
        public bool boka(kund anvandare, string regnr, string datum, string marke, string modell, string arsmodell)
        {
            List<string> errorMsgs = new List<string>();
            SqlCeDatabase db = new SqlCeDatabase();
            bil_objekt bil = new bil_objekt();
            string agare = anvandare.GetEmail();

            string namn = anvandare.GetNamn();
            string fnamn = namn.Substring(0, namn.IndexOf(' '));
            string enamn = namn.Substring(namn.IndexOf(' ') + 1);
            string tfn = anvandare.GetTfn();

            int kod = bil.insertFordon(regnr, modell, arsmodell, marke, anvandare);
            if (kod == 0)
            {
                string query = "INSERT INTO Bokning " +
                   "(datum, fnamn, enamn, bil, email, tfn) " +
                   "VALUES  ('?x?','?x?','?x?','?x?', '?x?', '?x?')";
                string[] args = new string[6] { datum, fnamn, enamn, regnr, agare, tfn };

                if (db.query(query, args) == 0)
                {
                    int opResultat = db.operation();
                    if (opResultat == 0)
                        return true;
                    else
                    {
                        errorMsgs.Add("Det blev något fel när din bokning skulle processeras. Kontakta systemansvarig");
                        if (DEBUG)
                            errorMsgs.AddRange(db.GetTmpMsgs());
                    }
                }
                else
                {
                    errorMsgs.Add("Det blev ett fel vid skapandet av frågan. Kontakta ansvarig för programmet.");
                    if (DEBUG)
                        errorMsgs.AddRange(db.GetTmpMsgs());
                }
            }
            else
            {
                if (DEBUG)
                    errorMsgs.AddRange(bil.GetTmpMsgs());
                else
                    errorMsgs.Add("Det blev något fel när ditt fordon skulle registreras");
            }
            if (errorMsgs.Count > 0)
            {
                this.tmpMsgs = errorMsgs.ToArray();
            }
            return false;
        }

        /// <summary>
        /// Hämtar bokningarna för kunden som är registrerad i boknings_objektetet.
        /// Hämtar värdena datumet, bilen, fordonsmodellen, fordonets årsmodell och märket i den ordningen
        /// </summary>
        /// <returns>Returnerar en string[] med alla träffar, om det inte fanns några träffar skickar den </returns>
        public string[] hamtaMinaBokningar()
        {
            string email = this.anvandare.GetEmail();
            List<string> errorMsgs = new List<string>();
            string[] fetch;
            string queryHamtaBokningar = "SELECT B.datum, B.bil, F.modell, F.arsmodell, F.marke " +
            "FROM Bokning AS B INNER JOIN Fordon AS F ON B.bil = F.reg WHERE (B.email = '?x?')";
            string[] args = { email };

            int queryRes = this.db.query(queryHamtaBokningar, args);
            if (queryRes == 0)
            {
                fetch = this.db.fetchAll();
                if (fetch.Length > 0)
                    return fetch;
            }
            errorMsgs.AddRange(db.GetTmpMsgs());
            this.tmpMsgs = errorMsgs.ToArray();
            string[] res = { };
            return res;
        }
    }
}
