using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    class bil_objekt
    {
        string[] tmpMsgs;
        Array[] tmpMsgsArray;
        bool DEBUG = Properties.Settings.Default.Debug;

        /// <summary>
        /// Denna funktion hämtar alla meddelanden som finns lagrade i sträng-arrayen tmpMsgs
        /// </summary>
        /// <returns>Skickar arrayen om den har något innehåll, annars en tom array.</returns>
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
        /// Denna funktion hämtar alla meddelanden som finns lagrade i den flerdimensionella sträng-arrayen tmpMsgsArray
        /// </summary>
        /// <param name="array">bool som avgör att det blir en array</param>
        /// <returns></returns>
        public Array[] GetTmpMsgs(bool array)
        {
            if (this.tmpMsgsArray != null)
                return this.tmpMsgsArray;
            else
            {
                Array[] meddelande = { };
                return meddelande;
            }
        }

        /// <summary>
        /// Denna funktion kollar om det finns en bil i registret med detta regnummer.
        /// </summary>
        /// <param name="reg">Regnumret på bilen</param>
        /// <returns>Returnerar ett bool-värde, sant om bilen finns, annars falskt.</returns>
        public bool kollaBilFinns(string reg)
        {
            SqlCeDatabase db = new SqlCeDatabase();

            string queryCheckBil = "SELECT reg from Fordon where reg='?x?'";
            string[] argsCheckBil = new string[1] { reg };

            db.query(queryCheckBil, argsCheckBil);
            string[] kollaBilRes = db.fetch();
            if (kollaBilRes[0] == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Denna funktion lägger till ett fordon i registret. 
        /// Den använder sig av klassen SqlCeDatabase för att ansluta till en kompakt MSSQL-server/fil.
        /// </summary>
        /// <param name="reg">Regnumret på bilen.</param>
        /// <param name="fnamn">Förnamnet på ägaren.</param>
        /// <param name="enamn">Efternamnet på ägaren.</param>
        /// <param name="modell">Modellen på bilen</param>
        /// <param name="arsmodell">Årsmodellen på bilen</param>
        /// <param name="marke">Märket på bilen</param>
        /// <returns>Returnerar returnkod som int.
        /// 0 - Operationen slutfördes utan problem
        /// 1 - Fel vid fordonsregistreringen
        /// 2 - Fel vid frågeformuleringen</returns>
        public int insertFordon(string reg, string modell, string arsmodell, string marke, kund anvandare)
        {
            SqlCeDatabase db = new SqlCeDatabase();
            List<string> resultat = new List<string>();
            List<string> errorMsgs = new List<string>();
            string agare = anvandare.GetEmail();
            string queryNyBil = "INSERT INTO Fordon" +
                "(reg, modell, arsmodell, marke, agare) " +
                " values ('?x?','?x?','?x?','?x?','?x?')";

            string[] argsNyBil = new string[5] { reg, modell, arsmodell, marke, agare };
            int queryResultat = db.query(queryNyBil, argsNyBil);                   // Skapar en string-array av resultatet från db.query() för att kunna använda i jämförelser och returns
            int returnkod;
            if (queryResultat == 0)
            {
                int operationResultat = db.operation();                            // Skapar en string-array av resultatet från db.operation() för att kunna använda i jämförelser och returns
                if (operationResultat == 0)
                {
                    returnkod = 0;
                }
                else
                {
                    errorMsgs.Add("Det blev ett fel när ditt fordon skulle registreras. Kontakta systemansvarig.");
                    if (DEBUG)
                        errorMsgs.AddRange(db.GetTmpMsgs());
                    returnkod = 1;
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel med frågeformuleringen. Kontakta systemansvarig.");
                if (DEBUG)
                    errorMsgs.AddRange(db.GetTmpMsgs());
                returnkod = 2;
            }
            if (errorMsgs.Count > 0)
                this.tmpMsgs = errorMsgs.ToArray();
            return returnkod;
        }

        /// <summary>
        /// Hämtar alla bilar som är registrerade på kundens email och sparar dem i tmpMsgs.
        /// För att hämta arrayen med bilar kör getTmpMgsg.
        /// </summary>
        /// <param name="anvandare">Kunden som bilarna är registrerade på</param>
        /// <returns>Returnerar en returnkod som int-värde.
        /// 0 - Inga fel uppstod
        /// 1 - Inga bilar funna
        /// 2 - Fel vid frågeformuleringen</returns>
        public int kollaKundsBilar(kund anvandare)
        {
            SqlCeDatabase db = new SqlCeDatabase();

            string regQuery = "SELECT reg, marke, modell, arsmodell FROM fordon WHERE agare='?x?'";
            string[] args = { anvandare.GetEmail() };

            int queryResultat = db.query(regQuery, args);
            if (queryResultat == 0)
            {
                Array[] fetchResultat = db.fetchAll();

                if (fetchResultat.Length < 1)
                {
                    this.tmpMsgs = db.GetTmpMsgs();
                    return 1;
                }
                else
                {
                    this.tmpMsgsArray = fetchResultat;
                    return 0;
                }
            }
            this.tmpMsgs = db.GetTmpMsgs();
            return 2;
        }

        /// <summary>
        /// KollaKundsBilar: Kollar efter kunders bilar och returnerar bara regnumret
        /// </summary>
        /// <param name="anvandare">Kundens kundobjekt</param>
        /// <param name="what">Vad som ska frågas efter i Select-satsen</param>
        /// <returns>Returnerar ett intvärde
        /// 0 - om funktion slutfördes utan problem
        /// 1 - Inga bilar fanns
        /// 2 - Fel vid frågeformuleringen</returns>
        public int kollaKundsBilar(kund anvandare, string what)
        {
            SqlCeDatabase db = new SqlCeDatabase();

            string regQuery = "SELECT ?x? FROM fordon WHERE agare='?x?'";
            string[] args = { what, anvandare.GetEmail() };

            int queryResultat = db.query(regQuery, args);
            if (queryResultat == 0)
            {
                string[] fetchResultat = db.fetch();

                if (fetchResultat.Length < 1)
                {
                    this.tmpMsgs = db.GetTmpMsgs();
                    return 1;
                }
                else
                {
                    this.tmpMsgs = fetchResultat;
                    return 0;
                }
            }
            this.tmpMsgs = db.GetTmpMsgs();
            return 2;
        }
    }
}