using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Bokningssystem
{
    class input
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        private string[] tmpMsgs;

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
                string[] meddelande = { "Det finns inget att skicka" };
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
            string[] kollaBilRes = db.fetchAll();
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
        /// <returns>Returnerar en array med strängar. Arrayen har minst två element; det första är statuskoden för funktionen 1 = framgång, 0 = misslyckande.
        /// Det andra elementet är ett meddelande. Ibland kan ha fler än två element, men det är samma som innan, statuskod och meddelande.</returns>
        public bool insertFordon(string reg, string modell, string arsmodell, string marke, kund anvandare)
        {
            SqlCeDatabase db = new SqlCeDatabase();
            List<string> resultat = new List<string>();
            List<string> errorMsgs = new List<string>();
            string agare = anvandare.GetEmail();
            string queryNyBil = "INSERT INTO Fordon" +
                "(reg, modell, arsmodell, marke, agare) " +
                " values ('?x?','?x?','?x?','?x?','?x?')";
            
            string[] argsNyBil = new string[5] { reg, modell, arsmodell, marke, agare };
            string[] queryResultat = db.query(queryNyBil, argsNyBil);                   // Skapar en string-array av resultatet från db.query() för att kunna använda i jämförelser och returns
            if (queryResultat[0] == "1")
            {
                string[] operationResultat = db.operation();                            // Skapar en string-array av resultatet från db.operation() för att kunna använda i jämförelser och returns
                if (operationResultat[0] == "1")
                {
                    return true;
                }
                else
                {
                    errorMsgs.Add("Det blev ett fel när ditt fordon skulle registreras. Kontakta systemansvarig.");
                    if (DEBUG)
                        errorMsgs.AddRange(operationResultat);
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel med frågeformuleringen. Kontakta systemansvarig.");
                if (DEBUG)
                    errorMsgs.AddRange(queryResultat);
            }
            if (errorMsgs.Count > 0)
                this.tmpMsgs = errorMsgs.ToArray();
            return false;
        }

        /// <summary>
        /// Denna funktion kollar om det finns en bil i registret med detta id.
        /// </summary>
        /// <param name="id">Id:et på personen (första tre bokstäverna i förnamn och efternamn)</param>
        /// <returns>Returnerar ett bool-värde, sant om personen finns, annars falskt.</returns>
        public bool kollaPersonFinns(string id)
        {
            SqlCeDatabase db = new SqlCeDatabase();
            string queryKund = "SELECT fnamn,enamn,id from Kunder where id='?x?'";
            string[] kundArgs = { id };

            if (db.query(queryKund, kundArgs)[0] == "1")
            {
                string[] kollPersResultat = db.fetchAll();
                if (kollPersResultat[0] == null)
                    return false;
                else
                    return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Denna funktion lägger till personer till registret.
        /// Den använder sig av klassen SqlCeDatabase för att ansluta till en kompakt MSSQL-server/fil.
        /// </summary>
        /// <param name="args">En array med strängar som representerar värdena till kunden.
        /// Kan med fördel användas med kollaInmatnings funktionen</param>
        /// <returns>Returnerar en array med strängar. Arrayen har minst två element; det första är statuskoden för funktionen 1 = framgång, 0 = misslyckande.
        /// Det andra elementet är ett meddelande. Ibland kan ha fler än två element, men det är samma som innan, statuskod och meddelande.</returns>
        public string[] ReggaKund(string[] args)
        {
            SqlCeDatabase db = new SqlCeDatabase();
            string query = "Insert into Kunder" +
                            "(fnamn, enamn, email, tfn, adress, personnr, losen)" +
                            " values " +
                            "('?x?','?x?','?x?','?x?','?x?','?x?','?x?')";
            if (db.query(query, args)[0] == "1")
            {
                if (db.operation()[0] != "0")
                {
                    string[] resultat = { "1", "Ditt konto registrerades utan problem" };
                    return resultat;
                }
                else
                    return db.operation();
            }
            else
                return db.query(query, args);
        }

        /// <summary>
        /// Funktion som validerar inmatningarna i textboxarna.
        /// Textboxar vars namn är t ex textBoxEmail, textBoxNamn eller liknande
        /// kommer att få deras innehåll granskat på riktigt, exempelvis textBoxPersnr
        /// </summary>
        /// <param name="inmatningar">En array med alla textboxar, skriv dem i ordning, för annars blir det jobbigt.</param>
        /// <returns>Kommer att returnera en sträng array med alla godkända strängar.
        /// För att kunna debugga denna funktion, använd er av GetTmpMsgs() metoden till input.</returns>
        public string[] kollaInmatning(TextBox[] inmatningar)
        {
            List<string> args = new List<string>();
            List<string> errorMsg = new List<string>();
            foreach (TextBox textbox in inmatningar)
            {
                string textboxName = textbox.Name.Substring(7, textbox.Name.Length - 7);
                switch (textboxName)
                {
                    case "Email":
                        if (kollaEmail(textbox.Text))
                        {
                            args.Add(textbox.Text);
                        }
                        else
                        {
                            errorMsg.Add("Din emailadress är inte korrekt, kontrollera att du inte skrivit fel");
                            errorMsg.Add("Giltiga emailadresser innehåller ett användarnamn@domän(.com/se/nu) " +
                                "och får inte börja med något annat än siffror eller bokstäver");
                        }
                        break;

                    case "Namn":
                        string[] namn = kollaNamn(textbox.Text);
                        if (namn[0] != "0")
                            args.AddRange(namn);
                        else
                        {
                            errorMsg.Add("Ditt namn är inte fullständigt. " +
                                "Tänk på att skriva både förnamn och efternamn med ett mellanslag som separerar dem från varandra.");
                        }
                        break;

                    case "Persnr":
                        if (kollaPersnr(textbox.Text))
                            args.Add(textbox.Text);
                        else
                        {
                            errorMsg.Add("Ditt personnummer är inte giltigt, kontrollera att du inte skrivit fel någonstans.");
                            errorMsg.Add("Formatet är ÅÅMMDDXXXX");
                        }
                        break;

                    case "Telefon":
                        if (kollaTfnNummer(textbox.Text))
                            args.Add(textbox.Text);
                        else
                            errorMsg.Add("Ditt telefonnummer är inte giltigt, det får bara inneålla 9-10 siffror.\n" +
                                "Tänk på att skriva in riktnumret.");
                        break;

                    default:
                        string text = textbox.Name;
                        if (text.Contains("namn") | text.Contains("Namn"))
                        {
                            string[] kundNamn = kollaNamn(textbox.Text);
                            args.AddRange(kundNamn);
                            break;
                        }
                        if (text.Contains("mail"))
                            if (kollaEmail(textbox.Text))
                            {
                                args.Add(textbox.Text);
                                break;
                            }
                            else
                            {
                                errorMsg.Add("Din emailadress är inte en giltig adress.");
                                break;
                            }
                        else
                            args.Add(textbox.Text);
                        break;
                }
            }
            if (errorMsg.Count > 0)
                this.tmpMsgs = errorMsg.ToArray();
            return args.ToArray();
        }

        /// <summary>
        /// Funktion kontrollerar att emailadressen är korrekt, den kollar efter @ och att det slutar på en toppdomän
        /// och att det inte finns något annat siffror, bokstäver, underscores och bindestreck i, det får inte heller 
        /// börja på något annat än siffra eller bokstav.
        /// </summary>
        /// <param name="emailadress">Email-adressen som ska kontrolleras</param>
        /// <returns>Ett booleskt värde som indikerar om kontrollen var framgångsrik eller inte. </returns>
        public bool kollaEmail(string emailadress)
        {
            bool korrektEmail = false;
            if (emailadress.Contains('@'))
            {
                Regex chkTLD = new Regex(".[a-z]+$");
                Match match = chkTLD.Match(emailadress);
                if (match.Success)
                {
                    if (Char.IsLetterOrDigit(emailadress[0]))
                    {
                        bool innehållerIngaOgiltigaTecken = false;
                        foreach (char ch in emailadress)
                        {
                            if (Char.IsPunctuation(ch) | Char.IsLetterOrDigit(ch))
                                innehållerIngaOgiltigaTecken = true;
                            else if (ch.Equals('_') | ch.Equals('-'))
                                innehållerIngaOgiltigaTecken = true;
                        }
                        korrektEmail = innehållerIngaOgiltigaTecken;
                    }
                }
            }
            return korrektEmail;
        }

        /// <summary>
        /// Funktion som kollar att namnet innehåller ett förnamn och efternamn (att det innehåller ett mellanslag mellan 2 ord)
        /// delar upp namnet och returnerar förnamn och efternamn i en array med strängar.
        /// </summary>
        /// <param name="namn">Namnet som ska kontrolleras</param>
        /// <returns>En array med strängar som innehåller förnam och efternamn, innehåller en nolla om det blev fel längs vägen.</returns>
        public string[] kollaNamn(string namn)
        {
            string fnamn = "";
            string enamn = "";
            bool namnKorrekt = false;
            if (namn != string.Empty)
            {
                if (namn.Contains(' '))
                {
                    fnamn = namn.Substring(0, namn.IndexOf(' '));
                    enamn = namn.Substring(namn.IndexOf(' ') + 1, namn.Length - fnamn.Length - 1);
                    namnKorrekt = true;
                }
                if (namnKorrekt)
                {
                    string[] namnGrupp = { fnamn, enamn };
                    return namnGrupp;
                }
                else
                {
                    string[] msg = { "0" };
                    return msg;
                }
            }
            else
            {
                string[] msg = { "0" };
                return msg;
            }
        }

        /// <summary>
        /// Funktion som kontrollerar att personnumret är korrekt. Den kollar efter att dagarna och månaderna finns
        /// alltså så det inte är 31 dagar i april till exempel, håller koll på skottår också.
        /// Man kan mata in personnummer i två format, med eller utan kontrollsiffror.
        /// Om man matar in kontrollsiffrorna så kommer funktionen utföra en beräkning för att se att allt är korrekt.
        /// Om man inte matar in dem så gör funktionen inte den kollen och användaren får en varning om att det är mer osäkert.
        /// </summary>
        /// <param name="persnr">Personnumret som ska kontrolleras.</param>
        /// <returns>Ett booleskt värde som indikerar om det var framgångsrikt eller inte.</returns>
        public bool kollaPersnr(string persnr)
        {
            List<string> errorMsgs = new List<string>();
            bool ärKorrektPersnr = false;
            int length = persnr.Length;
            int FullY, Y, M, D;

            if (persnr.Substring(0, 2) == "19")
            {
                FullY = Convert.ToInt32(persnr.Substring(0, 2));
                Y = Convert.ToInt32(persnr.Substring(2, 2));
                M = Convert.ToInt32(persnr.Substring(4, 2));
                D = Convert.ToInt32(persnr.Substring(6, 2));
            }
            else
            {
                FullY = Convert.ToInt32("19" + persnr.Substring(0, 2));
                Y = Convert.ToInt32(persnr.Substring(0, 2));
                M = Convert.ToInt32(persnr.Substring(2, 2));
                D = Convert.ToInt32(persnr.Substring(4, 2));
            }
            if (Y <= 99)
            {
                if (M <= 12)
                {
                    switch (M)
                    {
                        case 1:
                        case 3:
                        case 5:
                        case 7:
                        case 8:
                        case 10:
                        case 12:
                            if (D <= 31)
                                ärKorrektPersnr = true;
                            break;
                        case 2:
                            bool skottår = false;     // FullY?? vad är det?
                            if (FullY % 400 == 0)
                                skottår = true;
                            else if (FullY % 100 == 0)
                                skottår = false;
                            else if (FullY % 4 == 0)
                                skottår = true;

                            if (skottår)
                            {
                                if (D <= 29)
                                    ärKorrektPersnr = true;
                            }
                            else
                                if (D <= 28)
                                    ärKorrektPersnr = true;
                            break;
                        case 4:
                        case 6:
                        case 9:
                        case 11:
                            if (D <= 30)
                                ärKorrektPersnr = true;
                            break;
                        default:
                            errorMsgs.Add("Det finns bara 12 månader under ett år, håll dig till dem");
                            break;
                    }
                }
            }
            if (ärKorrektPersnr)
            {
                if (length == 6 | length == 8)
                {
                    errorMsgs.Add("Ditt personnummer innehåller inte dina kontrollsiffror, du borde betänka att lägga till dina kontrollsiffror för ökad säkerhet.");
                    this.tmpMsgs = errorMsgs.ToArray();
                    return ärKorrektPersnr;
                }

                else if (length == 10 | length == 12)
                {
                    if (length == 12)
                        persnr = persnr.Substring(2,10);
                    long nummer = long.Parse(persnr);
                    int summa = new int();
                    for (int i = 0; i < 10; i++)
                    {
                        if (i % 2 == 0)
                        {
                            int num = int.Parse(persnr.Substring(i,1));
                            int doubleNum = num * 2;
                            if (doubleNum > 9)
                                summa += doubleNum - 9;
                            else
                                summa += doubleNum;
                        }
                        else
                            summa += int.Parse(persnr.Substring(i,1));
                    }
                    if (summa % 10 == 0)
                        ärKorrektPersnr = true;
                    else
                        ärKorrektPersnr = false;
                }
            }
            if (errorMsgs.Count > 0)
                this.tmpMsgs = errorMsgs.ToArray();
            return ärKorrektPersnr;
        }

        /// <summary>
        /// Funktion som kollar att telefonnumret är korrekt. Det kollar så att det bara är siffror
        /// i strängen och att det är rätt längd (9 på fasta telefoner och 10 på mobila telefoner).
        /// </summary>
        /// <param name="nummer">Telefonnumret som ska kontrolleras</param>
        /// <returns>Ett booleskt värde som indikerar om det var framgångsrikt eller inte.§</returns>
        public bool kollaTfnNummer(string nummer)
        {
            bool ärInteNummer = false;
            foreach (char ch in nummer)
                if (!Char.IsDigit(ch))  
                    ärInteNummer = true;
            if (nummer.Length == 9 | nummer.Length == 10)
                if (!ärInteNummer)
                    return true;
            return false;
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
        public bool boka(kund anvandare, string regnr, DateTime datum)
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
            string[] args = new string[6] { datum.ToString(), fnamn, enamn, regnr, agare, tfn };

            if (db.query(query, args)[0] == "1")
            {
                string[] opResultat = db.operation();
                if (opResultat[0] == "1")
                    return true;
                else
                {
                    errorMsgs.Add("Det blev något fel när din bokning skulle processeras. Kontakta ansvarig för programmet");
                    if (DEBUG)
                        errorMsgs.AddRange(opResultat);
                }
            }
            else
            {
                errorMsgs.Add("Det blev ett fel vid skapandet av frågan. Kontakta ansvarig för programmet.");
                if (DEBUG)
                    errorMsgs.AddRange(db.query(query, args));
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
        public bool boka(kund anvandare, string regnr, DateTime datum, string marke, string modell, string arsmodell)
        {
            List<string> errorMsgs = new List<string>();
            SqlCeDatabase db = new SqlCeDatabase();
            string agare = anvandare.GetEmail();

            string namn = anvandare.GetNamn();
            string fnamn = namn.Substring(0, namn.IndexOf(' '));
            string enamn = namn.Substring(namn.IndexOf(' ') + 1);
            string tfn = anvandare.GetTfn();

            if (insertFordon(regnr, modell, arsmodell, marke, anvandare))
            {
                string query = "INSERT INTO Bokning " +
                   "(datum, fnamn, enamn, bil, email, tfn) " +
                   "VALUES  ('?x?','?x?','?x?','?x?', '?x?', '?x?')";
                string[] args = new string[6] { datum.ToString(), fnamn, enamn, regnr, agare, tfn };

                if (db.query(query, args)[0] == "1")
                {
                    string[] opResultat = db.operation();
                    if (opResultat[0] == "1")
                        return true;
                    else
                    {
                        errorMsgs.Add("Det blev något fel när din bokning skulle processeras. Kontakta systemansvarig");
                        if (DEBUG)
                            errorMsgs.AddRange(opResultat);
                    }
                }
                else
                {
                    errorMsgs.Add("Det blev ett fel vid skapandet av frågan. Kontakta ansvarig för programmet.");
                    if (DEBUG)
                        errorMsgs.AddRange(db.query(query, args));
                }
            }
            else
            {
                if (DEBUG)
                    errorMsgs.AddRange(GetTmpMsgs());
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
        /// Kollar om tiden är ledig i bokningsdatabasen
        /// </summary>
        /// <param name="date">Datumet som bokningen gäller</param>
        /// <param name="tid">Tid intervallet ex. HH:MM</param>
        /// <returns>Sant om det är ledigt, falskt annars</returns>
        public bool kollaTidLedig (DateTime date, string tid)
        {
            SqlCeDatabase db = new SqlCeDatabase();

            string tid1 = tid.Substring(0, tid.IndexOf(' '));
            string tid2 = tid.Substring(tid.LastIndexOf(' '), 5);

            string date1 = date.Year.ToString() + date.Month.ToString() + date.Day.ToString() + " " + tid1;
            string date2 = date.Year.ToString() + date.Month.ToString() + date.Day.ToString() + " " + tid2;
            
            string queryTid = "SELECT * FROM Bokning WHERE datum BETWEEN '?x?' AND '?x?'";
            string[] args = { date1, date2 };
            if (db.query(queryTid, args)[0] == "1")
            {
                string[] resultat = db.fetchAll();
                if (resultat[0] == "fel")
                    return true;
            }
            return false;
        }
    }
}