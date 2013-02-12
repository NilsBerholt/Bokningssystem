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

        public bool hyra(kund anvandare, DateTime startdag, DateTime slutdag, string fordon)
        {

        }
    }
}
