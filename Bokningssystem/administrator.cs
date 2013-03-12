using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bokningssystem
{
    public class administrator : kund
    {
        /// <summary>
        /// Konstruktören för klassen administratör.
        /// Använder sig av databasen med tabellen kunder och hämtar fältvärden som email, förnamn, enamn, telefonnummer
        /// </summary>
        /// <param name="email">Email-adressen som ska användas</param>
        /// <param name="losen">Lösenordet, som en säkerhetsåtgärd</param>
        public administrator(string email, string password) : base(email, password) {}

    }
}
