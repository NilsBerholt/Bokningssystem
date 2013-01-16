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
        private DateTime date;
        private int month, day, year;
        public string valdTid;

        public kalender(DateTime date, SqlCeDatabase database)
        {
            InitializeComponent();

            this.date = date;
            db = database;

            // Initiera datumen
            this.month = this.date.Month;
            this.day = this.date.Day;
            this.year = this.date.Year;
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

    public partial class tidElement : UserControl
    {
        public bool ledig;
        private string date;

        public tidElement(DateTime date, string tid)
        {
            input inmatning = new input();

            this.date = date.Year.ToString() + date.Month.ToString() + date.Day.ToString();
            this.date += ":" + tid;

            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.AutoSize = true;

            Label text = new Label();
            text.Text = tid;
            text.AutoSize = true;
            panel.Controls.Add(text);

            Label färg = new Label();
            färg.Text = "";
            färg.Size = text.Size;

            if (inmatning.kollaTidLedig(date, tid))
                färg.BackColor = Color.Green;
            else
                färg.BackColor = Color.Red;
            panel.Controls.Add(färg);


        }
    }
}
