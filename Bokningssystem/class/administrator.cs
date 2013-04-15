using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    public class administrator : user
    {
        /// <summary>
        /// Konstruktören för klassen administratör.
        /// Använder sig av databasen med tabellen kunder och hämtar fältvärden som email, förnamn, enamn, telefonnummer
        /// </summary>
        /// <param name="username">Användarnamnet som ska användas</param>
        /// <param name="losen">Lösenordet, som en säkerhetsåtgärd</param>
        /*public administrator(string username, string losen)
            : base()
        {
            List<string> errorMsg = new List<string>();
            string query = "Select email, fnamn, enamn, losen, tfn, adress from Administratörer where användarnamn='?x?' and losen='?x?'";
            string[] args = { username, losen };
            if (db.query(query, args) != 0)
                errorMsg.AddRange(db.GetTmpMsgs());
            else
            {
                string[] resultat = db.fetch();
                string[] properties = { this.email, this.fnamn, this.enamn, this.losenord, this.tfn, this.adress };

                if (resultat.Length == 0)
                    throw new Exception("Lösenordet och e-postadressen stämde inte överens med någon kund i registret");

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

                if (resultat[4] != string.Empty)
                    this.tfn = resultat[4];
                else
                    errorMsg.Add("Fältet för telefonnummret är tomt");

                if (resultat[5] != string.Empty)
                    this.adress = resultat[5];
                else
                    errorMsg.Add("Fältet för adressen är tomt");

                this.readOnly = false;
            }
            this.tmpMsgs = errorMsg.ToArray();
        }
        */
        /// <summary>
        /// Konstruktören för klassen administratör.
        /// Använder sig av databasen med tabellen kunder och hämtar fältvärden som email, förnamn, enamn, telefonnummer
        /// </summary>
        /// <param name="email">Emailadressen som ska användas</param>
        /// <param name="losen">Lösenordet, som en säkerhetsåtgärd</param>
        public administrator(string email, string losen)
            : base()
        {
            List<string> errorMsg = new List<string>();
            string query = "Select email, fnamn, enamn, losen, tfn, adress from Administratörer where email='?x?' and losen='?x?'";
            string[] args = { email, losen };
            if (db.query(query, args) != 0)
                errorMsg.AddRange(db.GetTmpMsgs());
            else
            {
                string[] resultat = db.fetch();
                string[] properties = { this.email, this.fnamn, this.enamn, this.losenord, this.tfn, this.adress };

                if (resultat.Length == 0)
                    throw new Exception("Lösenordet och e-postadressen stämde inte överens med någon kund i registret");

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

                if (resultat[4] != string.Empty)
                    this.tfn = resultat[4];
                else
                    errorMsg.Add("Fältet för telefonnummret är tomt");

                if (resultat[5] != string.Empty)
                    this.adress = resultat[5];
                else
                    errorMsg.Add("Fältet för adressen är tomt");

                this.readOnly = false;
            }
            this.tmpMsgs = errorMsg.ToArray();
        }
    }
}
    