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
    public partial class Form1 : Form
    {
        private int[] idLista;
        public Form1(string typ, Array lista)
        {
            InitializeComponent();
            this.idLista = lista as int[];

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
