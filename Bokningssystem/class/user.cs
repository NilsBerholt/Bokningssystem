using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    abstract class user
    {
        public bool DEBUG = Properties.Settings.Default.Debug;

        private string email, fnamn, enamn, losenord, tfn, adress;
        private string[] tmpMsgs;
        protected bool readOnly;
        private SqlCeDatabase db = null;

        /// <summary>
        /// Tom konstruktör
        /// </summary>
        public user()
        {
            this.db = new SqlCeDatabase();
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
        /// Funktion som hämtar lösenordet till kunden
        /// </summary>
        /// <returns>Lösenordet till personen / kunden</returns>
        public string GetLosen()
        {
            return this.losenord;
        }

        /// <summary>
        /// Funktion som hämtar adressen till kunden
        /// </summary>
        /// <returns>Adressen till personen / kunden</returns>
        public string GetAdress()
        {
            return this.adress;
        }

        /// <summary>
        /// Funktion som hämtar telefonnummret till kunden
        /// </summary>
        /// <returns>Telefonnummret till personen / kunden</returns>
        public string GetTfn()
        {
            return this.tfn;
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
        /// Om inget efternamn är angivet så skriver den efternamnet som tom sträng
        /// </summary>
        /// <param name="value">Namnet som det ska ändras till</param>
        public int SetNamn(string namn)
        {
            List<string> errorMsgs = new List<string>();
            string efternamn;
            string fornamn;

            if (namn.Contains(' '))
            {
                fornamn = namn.Substring(0, namn.IndexOf(' '));
                efternamn = namn.Substring(namn.IndexOf(' '));
            }
            else
            {
                fornamn = namn;
                efternamn = "";
            }

            string updateQuery = "UPDATE Kunder set fnamn='?x?', enamn='?x?' where email='?x?'";
            string[] args = { fornamn, efternamn, GetEmail() };
            int queryResultat = this.db.query(updateQuery, args);
            if (queryResultat == 0)
            {
                int operationResult = this.db.operation();
                if (operationResult != 0)
                {
                    errorMsgs.Add("Det blev ett fel med uppdateringen av din profil.");
                    if (DEBUG)
                        errorMsgs.AddRange(this.db.GetTmpMsgs());
                    return 1;
                }
                else
                {
                    this.fnamn = fornamn;
                    this.enamn = efternamn;
                    return 0;
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel med frågestrukturen. Kontakta systemansvarig");
                if (DEBUG)
                    errorMsgs.AddRange(this.db.GetTmpMsgs());
                return 2;
            }
        }

        /// <summary>
        /// Funktion som ändrar kundens telefonnummer
        /// Kombinera med getTmpMsgs()
        /// </summary>
        /// <param name="tfnnummer">Telefonnumret som string</param>
        /// <returns>0 är genomförd utan problem, allt annat är fel. 1 är fel med uppdateringen till databasen och 2 är fel med frågan</returns>
        public int SetTfn(string tfnnummer)
        {
            string querySetTfn = "UPDATE Kunder set tfn='?x?' where email='?x?'";
            string[] args = { tfnnummer, this.GetEmail() };

            int queryResult = this.db.query(querySetTfn, args);
            if (queryResult == 0)
            {
                int operationResult = this.db.operation();
                if (operationResult == 0)
                {
                    this.tfn = tfnnummer;
                    return 0;
                }
                else
                {
                    this.tmpMsgs = this.db.GetTmpMsgs();
                    return 1;
                }
            }
            else
            {
                this.tmpMsgs = this.db.GetTmpMsgs();
                return 2;
            }
        }

        /// <summary>
        /// Funktion som anger en ny adress till kunden
        /// </summary>
        /// <param name="adress">Adressen som string</param>
        /// <returns>0 är genomförd utan problem, allt annar är fel. 10 är fel med uppdateringen till databasen och 100 är fel med frågan</returns>
        public int SetAdress(string adress)
        {
            List<string> errorMsgs = new List<string>();
            string NyAdress = adress;

            string updateQuery = "UPDATE kunder set adress='?x?' where email='?x?'";
            string[] args = { NyAdress, GetEmail() };
            int queryResultat = this.db.query(updateQuery, args);
            if (queryResultat == 0)
            {
                int operationResult = this.db.operation();
                if (operationResult != 0)
                {
                    errorMsgs.Add("Det blev ett fel med uppdateringen av din profil.");
                    if (DEBUG)
                        errorMsgs.AddRange(db.GetTmpMsgs());
                    return 10;
                }
                else
                {
                    this.adress = NyAdress;
                    return 0;
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel med frågestrukturen. Kontakta systemansvarig");
                if (DEBUG)
                    errorMsgs.AddRange(db.GetTmpMsgs());
                return 100;
            }
        }

        /// <summary>
        /// Funktion som anger ett nytt lösenord till kunden 
        /// </summary>
        /// <param name="Losenord">Lösenordet som string</param>
        /// <returns>0 är genomförd utan problem, allt annar är fel. 10 är fel med uppdateringen till databasen och 100 är fel med frågan</returns>
        public int SetLosen(string Losenord)
        {
            List<string> errorMsgs = new List<string>();
            string NyttLosen = Losenord;

            string updateQuery = "UPDATE kunder set losen='?x?' where email='?x?'";
            string[] args = { NyttLosen, GetEmail() };
            int queryResultat = this.db.query(updateQuery, args);
            if (queryResultat == 0)
            {
                int operationResult = this.db.operation();
                if (operationResult != 0)
                {
                    errorMsgs.Add("Det blev ett fel med uppdateringen av din profil.");
                    if (DEBUG)
                        errorMsgs.AddRange(this.db.GetTmpMsgs());
                    return 10;
                }
                else
                {
                    this.losenord = NyttLosen;
                    return 0;
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel med frågestrukturen. Kontakta systemansvarig");
                if (DEBUG)
                    errorMsgs.AddRange(this.db.GetTmpMsgs());
                return 100;
            }
        }

        /// <summary>
        /// Funktion som anger en ny email till kunden
        /// </summary>
        /// <param name="Email">Emailen som string</param>
        /// <returns>0 är genomförd utan problem, allt annar är fel. 10 är fel med uppdateringen till databasen och 100 är fel med frågan</returns>
        public int SetEmail(string Email)
        {
            List<string> errorMsgs = new List<string>();
            string NyEmail = Email;

            string updateQuery = "UPDATE kunder set email='?x?' where email='?x?'";
            string[] args = { NyEmail, GetEmail() };
            int queryResultat = this.db.query(updateQuery, args);
            int returnkod;
            if (queryResultat == 0)
            {
                int operationResult = this.db.operation();
                if (operationResult != 0)
                {
                    errorMsgs.Add("Det blev ett fel med uppdateringen av din profil.");
                    if (DEBUG)
                        errorMsgs.AddRange(this.db.GetTmpMsgs());
                    returnkod = 1;
                }
                else
                {
                    this.email = NyEmail;
                    returnkod = 0;
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel med frågestrukturen. Kontakta systemansvarig");
                if (DEBUG)
                    errorMsgs.AddRange(this.db.GetTmpMsgs());
                returnkod = 2;
            }
            if (errorMsgs.Count > 0)
                this.tmpMsgs = errorMsgs.ToArray();
            return returnkod;
        }

        /// <summary>
        /// Returnerar huruvida objektet är readonly eller inte
        /// </summary>
        /// <returns>Sant eller falskt</returns>
        public bool isReadOnly()
        {
            return this.readOnly;
        }
    }
}
