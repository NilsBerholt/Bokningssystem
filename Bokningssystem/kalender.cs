using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bokningssystem
{
    public partial class kalender : UserControl
    {
        public SqlCeDatabase db = null;
        private string date;
        private int month, day, year;
        public string valdTid;

        public kalender(DateTime date, SqlCeDatabase database)
        {
            InitializeComponent();

            this.date = date.Date.ToString();
            db = database;
        }

        public void Initiate()
        {
            FlowLayoutPanel panel = new FlowLayoutPanel();
            input inmatning = new input();
            panel.Size = this.Size;

            string[] tider = { "8:00 - 10:00", "10:00 - 12:00", "14:00 - 16:00", "16:00 - 18:00" };
            foreach (string tid in tider)
            {
                Label tidLabel = new Label();
                tidLabel.Text = tid;
                tidLabel.AutoSize = true;
                panel.Controls.Add(tidLabel);
                Label färgLabel = new Label();
                färgLabel.Text = "";

                if (inmatning.kollaTidLedig(date,tid))
                    färgLabel.BackColor = Color.Green;
                else 
                    färgLabel.BackColor = Color.Red;
                panel.Controls.Add(färgLabel);

            }
        }
    }
}
