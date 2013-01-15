using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data.SqlServerCe;

namespace Bokningssystem
{
    /// <summary>
    /// En klass som sköter allt som har med SQL Server Compact Edition att göra.
    /// Klassen tar hand om frågeformering, select-frågor och uppdateringsfrågor.
    /// </summary>
    public class SqlCeDatabase
    {
        /// <summary>
        /// Deklarerar variabler som sparas i instansen
        /// </summary>
        static SqlCeConnection connection = new SqlCeConnection();
        private SqlCeCommand cmd = connection.CreateCommand();

        /// <summary>
        /// Konstruktorn, sätter parametern ConnectionString till SQLCeConnection-variabeln connection.
        /// </summary>
        static SqlCeDatabase()
        {
            string connectionstring = Properties.Settings.Default.Database1ConnectionString;
            connection.ConnectionString = connectionstring;
        }

        /// <summary>
        /// Frågeformateringsfunktion Database.query()
        /// Kontrollerar att frågan som ska skickas till databasen är rätt formaterad.
        /// Om det finns några ?x? är det platshållare för variabler och det måste finnas lika många
        /// platshållare som variabler i arrayen annars returneras ett fel.
        /// 
        /// När frågan är komplett anges den som SQLCeCommand-variabeln cmd's CommandText-egenskap
        /// </summary>
        /// <param name="query">Frågan som ska skickas till frågan, med platshållare för variabler i form av strängen ?x?</param>
        /// <param name="array">En array med alla variabler i den ordning de dyker upp i frågan, ersätter varje ?x? i frågan med motsvarande variabel</param>
        /// <returns>Returnerar en array med 2 string-element, det första elementet är en huruvida funktionen utfördes utan problem, 1 eller 0.
        /// Det andra elementet är eventuella felmeddelande. Om det finns fler möjliga felkällor kommer arrayen ha mer än två element, fast med samma syntax.</returns>
        public String[] query(string query, string[] array)
        {
            List<string> resultat = new List<string>();
            int numArgs = array.Length;
            int places = 0;
            foreach (Match match in Regex.Matches(query, @"\?x\?"))         // Vid varje matchning av ?x? i frågan
            {
                places += 1;                                                // Lägg till ett i platshållarräknaren.
            }
            if (places == numArgs)
            {
                if (numArgs > 0)
                    foreach (string args in array)
                    {
                        int length = query.Length;
                        string strBeginning = query.Substring(0, query.IndexOf(@"?x?"));
                        string strEnd = query.Substring(query.IndexOf(@"?x?") + 3, length - (strBeginning.Length + 3));
                        query = strBeginning + args + strEnd;
                    }

                this.cmd.CommandText = query;
                resultat.Add("1");
                resultat.Add("Frågan innehöll inga syntaxfel.\nFrågan: " + query);
            }
            else
            {
                resultat.Add("0");
                resultat.Add("Det var inte lika många variabler som platser för variabler i frågan");
            }
            return resultat.ToArray();
        }

        /// <summary>
        /// Database.fetchAll()
        /// Funktion som skickar SELECT-frågor till databasen och returnerar en array
        /// som innehåller svaren som frågan utvalt.
        /// 
        /// Kan vara lite fishy, håll uppsikt över denna funktion.
        /// </summary>
        /// <returns> Returnerar en array med fältnamnen från varje fråga, arrayens element är i sig arrayer på fälten, inte raderna.</returns>
        public string[] fetchAll()
        {
            connection.Open();

            SqlCeTransaction transaction = connection.BeginTransaction();
            List<string> errorMsg = new List<string>();
            List<string> resultat = new List<string>();

            this.cmd.Transaction = transaction;
            SqlCeResultSet result;
            result = this.cmd.ExecuteResultSet(ResultSetOptions.Scrollable);
            
            int length = result.VisibleFieldCount;
            while (result.Read())
            {
                for (int i = 0; i < length; i++)
                {
                    if (result[i] != DBNull.Value)
                        resultat.Add(result[i].ToString());
                    else
                        errorMsg.Add("Det fanns inget värde i fältet " + result.GetName(i));
                }
            }
            result.Close();
            connection.Close();

            if (resultat.Count == 0)
            {
                errorMsg.Add("Det fanns inga värden i databasen för denna fråga.");
            }

            if (errorMsg.Count > 0)
            {
                errorMsg.Insert(0, "fel");
                return errorMsg.ToArray();
            }
            else
                return resultat.ToArray();
        }

        /// <summary>
        /// Database.Operation()
        /// Funktion som hanterar all uppdatering av databasen. Alltså alla frågor som inte väljer ut något värde.
        /// Ex. Uppdatera värden, ändra databasens struktur, ta bort poster/värden osv.
        /// 
        /// För att denna metod ska kunna köras måste instansen ha egenskaperna ConnectionString vara satt och databasen måste ha ett kommando med CommandText.
        /// </summary>
        /// <returns>Returnerar en array med 2 string-element, det första elementet är en huruvida funktionen utfördes utan problem, 1 eller 0.
        /// Det andra elementet är eventuella felmeddelande. Om det finns fler möjliga felkällor kommer arrayen ha mer än två element, fast med samma syntax.</returns>
        public string[] operation()
        {
            List<string> resultat = new List<string>();
            try
            {
                connection.Open();
            }
            catch (SqlCeException ex)
            {
                string connError = string.Format("Kunde inte ansluta till databasen, {0}\n Meddelande: {1}", ex.GetType(), ex.Message);
                resultat.Add(connError);
            }
            if (cmd.CommandText != "")
            {
                cmd.Connection = connection;
                SqlCeTransaction transaction = connection.BeginTransaction();
                cmd.Transaction = transaction;
                try
                {
                    cmd.ExecuteNonQuery();
                    transaction.Commit();
                    connection.Close();
                    resultat.Add("1");
                    resultat.Add("Operationen utfördes utan problem");
                }
                catch (SqlCeException ex)
                {
                    connection.Close();
                    string errorText = string.Format("Ett fel av typen {0} har inträffat.\nMeddelande: {1}", ex.GetType(), ex.Message);
                    resultat.Add("0");
                    resultat.Add(errorText);
                }
            }
            else
            {
                resultat.Add("0");
                resultat.Add("Kunde inte slutföra åtgärden.\nDet finns inget kommando associerat med detta objekt");
            }
            return resultat.ToArray();
        }
    }
}

                
