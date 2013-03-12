using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    class foretag
    {
        private string namn, email, oppetider, tfn, adress, postadr;
        private SqlCeDatabase db;
        private string[] tmpMsgs;

        /// <summary>
        /// Företagkonstruktör, tar namnet på företaget som parameter och hämtar information ifrån
        /// tabellen Företag.
        /// </summary>
        /// <param name="namn">Det fulla namnet på företaget</param>
        public foretag(string namn)
        {
            this.db = new SqlCeDatabase();

            string selectQuery = "SELECT Namn, Email, Oppetider, Telefon, Adress, PostAdress" +
                                  " FROM Företag WHERE Namn='?x?'";
            string[] args = { namn };

            int queryResultat = db.query(selectQuery, args);
            if (queryResultat != 0)
                throw new Exception("Det blev något fel med frågan, konsultera db.getTmpMsgs()");

            string[] fetchResultat = db.fetch();
            if (fetchResultat.Length == 0)
                throw new Exception("Önskat företag fanns inte i registret, programmet kan inte fortsätta.");

            this.namn = fetchResultat[0];
            this.email = fetchResultat[1];
            this.oppetider = fetchResultat[2];
            this.tfn = fetchResultat[3];
            this.adress = fetchResultat[4];
            this.postadr = fetchResultat[5];
        }

        /// <summary>
        /// Företagskonstruktör, tar företagets nummeridentitet som parameter och hämtar information ifrån
        /// tabellen Företag
        /// </summary>
        /// <param name="id">Företagets identitet (en int)</param>
        public foretag(int id)
        {
            this.db = new SqlCeDatabase();

            string selectQuery = "SELECT Namn, Email, Oppetider, Telefon, Adress, PostAdress" +
                                  " FROM Företag WHERE id=?x?";
            string[] args = { namn };

            int queryResultat = db.query(selectQuery, args);
            if (queryResultat != 0)
                throw new Exception("Det blev något fel med frågan, konsultera db.getTmpMsgs()");

            string[] fetchResultat = db.fetch();
            if (fetchResultat.Length == 0)
                throw new Exception("Önskat företag fanns inte i registret, programmet kan inte fortsätta.");

            this.namn = fetchResultat[0];
            this.email = fetchResultat[1];
            this.oppetider = fetchResultat[2];
            this.tfn = fetchResultat[3];
            this.adress = fetchResultat[4];
            this.postadr = fetchResultat[5];
        }

        /// <summary>
        /// Hämtar företagets namn
        /// </summary>
        /// <returns>Namnet på företaget</returns>
        public string GetNamn()
        {
            return this.namn;
        }
        
        /// <summary>
        /// Hämtar företagets email
        /// </summary>
        /// <returns>E-postadressen för kontakt av företaget</returns>
        public string GetEmail()
        {
            return this.email;
        }

        /// <summary>
        /// Hämtar företagets öppetider
        /// </summary>
        /// <returns>Öppetiderna för företaget</returns>
        public string GetOppetider()
        {
            return this.oppetider;
        }

        /// <summary>
        /// Hämtar företagets telefonnummer
        /// </summary>
        /// <returns>Telefonnumret för företaget</returns>
        public string GetTfn()
        {
            return this.tfn;
        }

        /// <summary>
        /// Hämtar företagets adress
        /// </summary>
        /// <returns>Adressen för företaget</returns>
        public string GetAdress()
        {
            return this.adress;
        }

        /// <summary>
        /// Hämtar företagets postadress
        /// </summary>
        /// <returns>Postadressen för företaget</returns>
        public string GetPostAdr()
        {
            return this.postadr;
        }

        /// <summary>
        /// Ändrar namnet på företaget
        /// </summary>
        /// <param name="namn">Det nya namnet till företaget</param>
        /// <returns>Returnkod som int-värde
        /// 0 - Funktionen utfördes utan problem
        /// Övrigt, fel</returns>
        public int SetNamn(string namn)
        {
            string updateNamn = "UPDATE Företag SET Namn='?x?' WHERE Namn='?x?'";
            string[] args = { namn, this.namn };

            int queryRes = db.query(updateNamn, args);
            if (queryRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return queryRes;
            }
            
            int opRes = db.operation();
            if (opRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return opRes;
            }

            return 0;
        }

        /// <summary>
        /// Ändrar e-postadressen på företaget
        /// </summary>
        /// <param name="email">Den nya e-postadressen till företaget</param>
        /// <returns>Returnkod som int-värde
        /// 0 - Funktionen utfördes utan problem
        /// Övrigt, fel</returns>
        public int SetEmail(string email)
        {
            string updateEmail = "UPDATE Företag SET Email='?x?' WHERE Namn='?x?'";
            string[] args = { email, this.namn };

            int queryRes = db.query(updateEmail, args);
            if (queryRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return queryRes;
            }

            int opRes = db.operation();
            if (opRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return opRes;
            }

            return 0;
        }

        /// <summary>
        /// Ändrar telefonnumret på företaget
        /// </summary>
        /// <param name="Tfn">Det nya telefonnumret till företaget</param>
        /// <returns>Returnkod som int-värde
        /// 0 - Funktionen utfördes utan problem
        /// Övrigt, fel</returns>
        public int SetTfn(string Tfn)
        {
            string updateTfn = "UPDATE Företag SET Telefon='?x?' WHERE Namn='?x?'";
            string[] args = { Tfn, this.namn };

            int queryRes = db.query(updateTfn, args);
            if (queryRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return queryRes;
            }

            int opRes = db.operation();
            if (opRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return opRes;
            }

            return 0;
        }

        /// <summary>
        /// Ändrar adressen för företaget
        /// </summary>
        /// <param name="adress">Den nya adressen till företaget</param>
        /// <returns>Returnkod som int-värde
        /// 0 - Funktionen utfördes utan problem
        /// Övrigt, fel</returns>
        public int SetAdress(string adress)
        {
            string updateAdress = "UPDATE Företag SET Adress='?x?' WHERE Namn='?x?'";
            string[] args = { adress, this.namn };

            int queryRes = db.query(updateAdress, args);
            if (queryRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return queryRes;
            }

            int opRes = db.operation();
            if (opRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return opRes;
            }

            return 0;
        }

        /// <summary>
        /// Ändrar något informationsfält för företaget i registret
        /// </summary>
        /// <param name="falt">Det fältet som ska ändras</param>
        /// <param name="varde">Värdet som fältet ska ändras till</param>
        /// <returns>Returnkod som int-värde
        /// 0 - Funktionen utfördes utan problem
        /// Övrigt, fel</returns>
        public int SetFalt(string falt, string varde)
        {
            string updateFalt = "UPDATE Företag SET '?x?'='?x?' WHERE Namn='?x?'";
            string[] args = { falt, varde, this.namn };

            int queryRes = db.query(updateFalt, args);
            if (queryRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return queryRes;
            }

            int opRes = db.operation();
            if (opRes != 0)
            {
                this.tmpMsgs = db.GetTmpMsgs();
                return opRes;
            }

            return 0;
        }
    }
}
