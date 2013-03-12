using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Bokningssystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            kund anvandare = new kund("jassob@live.se", "jonsson");
            administrator admin = new administrator("jassob@live.se","jonsson");
            Application.Run(new FormOmOss(admin));
        }
    }
}
