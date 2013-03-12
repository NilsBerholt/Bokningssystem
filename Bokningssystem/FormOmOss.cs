using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bokningssystem
{
    public partial class FormOmOss : Form
    {
        public bool DEBUG = Properties.Settings.Default.Debug;
        private kund anvandare;
        private administrator admin;
        private foretag företag;

        public FormOmOss(administrator admin)
        {
            InitializeComponent();
            this.admin = admin;
            initFormOmOss();

            richTextBoxOmOss.ReadOnly = false;
            richTextBoxOmOss.Cursor = Cursors.IBeam;
            
        }

        public FormOmOss(kund användare)
        {
            InitializeComponent();
            this.anvandare = användare;
            initFormOmOss();

            richTextBoxOmOss.ReadOnly = true;
            richTextBoxOmOss.Cursor = Cursors.Default;

        }

        private void initFormOmOss()
        {
            företag = new foretag("TestFöretag AB");
            textBoxNamn.Text = företag.GetNamn();
            textBoxEmail.Text = företag.GetEmail();
            textBoxOppetider.Text = företag.GetOppetider();
            textBoxPostAdress.Text = företag.GetPostAdr();
            textBoxTfn.Text = företag.GetTfn();
            textBoxAdress.Text = företag.GetAdress();
        }

    }
}
