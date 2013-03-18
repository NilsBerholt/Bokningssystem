namespace Bokningssystem
{
    partial class FormHyra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMeny = new System.Windows.Forms.TabPage();
            this.richTextBoxBokningMeny = new System.Windows.Forms.RichTextBox();
            this.tabPageNyHyr = new System.Windows.Forms.TabPage();
            this.panelTyp = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanelTyp = new System.Windows.Forms.TableLayoutPanel();
            this.labelFordonsTyp = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelTyp = new System.Windows.Forms.Label();
            this.labelSlut = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.richTextBoxMeddelandenHyra = new System.Windows.Forms.RichTextBox();
            this.buttonHyr = new System.Windows.Forms.Button();
            this.tabPageMinHyr = new System.Windows.Forms.TabPage();
            this.panelHyrning = new System.Windows.Forms.Panel();
            this.labelHyrningMeddelande = new System.Windows.Forms.Label();
            this.tableLayoutPanelHyrning = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonOmOss = new System.Windows.Forms.Button();
            this.buttonProfil = new System.Windows.Forms.Button();
            this.buttonMinHyr = new System.Windows.Forms.Button();
            this.buttonNyHyr = new System.Windows.Forms.Button();
            this.buttonMeny = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageMeny.SuspendLayout();
            this.tabPageNyHyr.SuspendLayout();
            this.panelTyp.SuspendLayout();
            this.tabPageMinHyr.SuspendLayout();
            this.panelHyrning.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMeny);
            this.tabControl1.Controls.Add(this.tabPageNyHyr);
            this.tabControl1.Controls.Add(this.tabPageMinHyr);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 489);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPageMeny
            // 
            this.tabPageMeny.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMeny.Controls.Add(this.richTextBoxBokningMeny);
            this.tabPageMeny.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeny.Name = "tabPageMeny";
            this.tabPageMeny.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeny.Size = new System.Drawing.Size(604, 463);
            this.tabPageMeny.TabIndex = 0;
            this.tabPageMeny.Text = "Meny";
            // 
            // richTextBoxBokningMeny
            // 
            this.richTextBoxBokningMeny.AcceptsTab = true;
            this.richTextBoxBokningMeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxBokningMeny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBokningMeny.Location = new System.Drawing.Point(29, 74);
            this.richTextBoxBokningMeny.Name = "richTextBoxBokningMeny";
            this.richTextBoxBokningMeny.ReadOnly = true;
            this.richTextBoxBokningMeny.Size = new System.Drawing.Size(168, 135);
            this.richTextBoxBokningMeny.TabIndex = 30;
            this.richTextBoxBokningMeny.TabStop = false;
            this.richTextBoxBokningMeny.Text = "";
            // 
            // tabPageNyHyr
            // 
            this.tabPageNyHyr.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNyHyr.Controls.Add(this.panelTyp);
            this.tabPageNyHyr.Controls.Add(this.labelFordonsTyp);
            this.tabPageNyHyr.Controls.Add(this.dateTimePicker2);
            this.tabPageNyHyr.Controls.Add(this.dateTimePicker1);
            this.tabPageNyHyr.Controls.Add(this.labelTyp);
            this.tabPageNyHyr.Controls.Add(this.labelSlut);
            this.tabPageNyHyr.Controls.Add(this.labelStart);
            this.tabPageNyHyr.Controls.Add(this.checkedListBox1);
            this.tabPageNyHyr.Controls.Add(this.richTextBoxMeddelandenHyra);
            this.tabPageNyHyr.Controls.Add(this.buttonHyr);
            this.tabPageNyHyr.Location = new System.Drawing.Point(4, 22);
            this.tabPageNyHyr.Name = "tabPageNyHyr";
            this.tabPageNyHyr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNyHyr.Size = new System.Drawing.Size(604, 463);
            this.tabPageNyHyr.TabIndex = 1;
            this.tabPageNyHyr.Text = "Ny hyrning";
            // 
            // panelTyp
            // 
            this.panelTyp.AutoScroll = true;
            this.panelTyp.Controls.Add(this.label1);
            this.panelTyp.Controls.Add(this.tableLayoutPanelTyp);
            this.panelTyp.Location = new System.Drawing.Point(281, 30);
            this.panelTyp.Name = "panelTyp";
            this.panelTyp.Size = new System.Drawing.Size(319, 302);
            this.panelTyp.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            this.label1.Visible = false;
            // 
            // tableLayoutPanelTyp
            // 
            this.tableLayoutPanelTyp.AutoSize = true;
            this.tableLayoutPanelTyp.ColumnCount = 5;
            this.tableLayoutPanelTyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelTyp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 319F));
            this.tableLayoutPanelTyp.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelTyp.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTyp.Name = "tableLayoutPanelTyp";
            this.tableLayoutPanelTyp.RowCount = 1;
            this.tableLayoutPanelTyp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelTyp.Size = new System.Drawing.Size(319, 0);
            this.tableLayoutPanelTyp.TabIndex = 0;
            // 
            // labelFordonsTyp
            // 
            this.labelFordonsTyp.AutoSize = true;
            this.labelFordonsTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFordonsTyp.Location = new System.Drawing.Point(425, 3);
            this.labelFordonsTyp.Name = "labelFordonsTyp";
            this.labelFordonsTyp.Size = new System.Drawing.Size(34, 20);
            this.labelFordonsTyp.TabIndex = 39;
            this.labelFordonsTyp.Text = "Typ";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(10, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 38;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.datum);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 37;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.datum);
            // 
            // labelTyp
            // 
            this.labelTyp.AutoSize = true;
            this.labelTyp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTyp.Location = new System.Drawing.Point(9, 92);
            this.labelTyp.Name = "labelTyp";
            this.labelTyp.Size = new System.Drawing.Size(93, 20);
            this.labelTyp.TabIndex = 36;
            this.labelTyp.Text = "Fordons typ";
            // 
            // labelSlut
            // 
            this.labelSlut.AutoSize = true;
            this.labelSlut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlut.Location = new System.Drawing.Point(8, 46);
            this.labelSlut.Name = "labelSlut";
            this.labelSlut.Size = new System.Drawing.Size(90, 20);
            this.labelSlut.TabIndex = 35;
            this.labelSlut.Text = "Slut datum:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStart.Location = new System.Drawing.Point(8, 3);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(97, 20);
            this.labelStart.TabIndex = 34;
            this.labelStart.Text = "Start datum:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Bil (2 pers)",
            "Bil (5 pers)",
            "Bil (7 pers)",
            "Bil (9 pers)",
            "Lastbil",
            "Motorcykel",
            "Skåpbil"});
            this.checkedListBox1.Location = new System.Drawing.Point(10, 112);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(149, 109);
            this.checkedListBox1.TabIndex = 33;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemCheck);
            // 
            // buttonHyr
            // 
            this.buttonHyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHyr.Location = new System.Drawing.Point(176, 358);
            this.buttonHyr.Name = "buttonHyr";
            this.buttonHyr.Size = new System.Drawing.Size(86, 33);
            this.buttonHyr.TabIndex = 32;
            this.buttonHyr.Text = "Hyr";
            this.buttonHyr.UseVisualStyleBackColor = true;
            this.buttonHyr.Click += new System.EventHandler(this.buttonHyr_Click);
            // 
            // richTextBoxMeddelandenHyra
            // 
            this.richTextBoxMeddelandenHyra.AcceptsTab = true;
            this.richTextBoxMeddelandenHyra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxMeddelandenHyra.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMeddelandenHyra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMeddelandenHyra.Location = new System.Drawing.Point(9, 240);
            this.richTextBoxMeddelandenHyra.Name = "richTextBoxMeddelandenHyra";
            this.richTextBoxMeddelandenHyra.ReadOnly = true;
            this.richTextBoxMeddelandenHyra.Size = new System.Drawing.Size(238, 164);
            this.richTextBoxMeddelandenHyra.TabIndex = 28;
            this.richTextBoxMeddelandenHyra.TabStop = false;
            this.richTextBoxMeddelandenHyra.Text = "";
            // 
            // buttonHyr
            // 
            this.buttonHyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHyr.Location = new System.Drawing.Point(514, 371);
            this.buttonHyr.Name = "buttonHyr";
            this.buttonHyr.Size = new System.Drawing.Size(86, 33);
            this.buttonHyr.TabIndex = 32;
            this.buttonHyr.Text = "Hyr";
            this.buttonHyr.UseVisualStyleBackColor = true;
            this.buttonHyr.Click += new System.EventHandler(this.buttonHyr_Click);
            // 
            // tabPageMinHyr
            // 
            this.tabPageMinHyr.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMinHyr.Controls.Add(this.panelHyrning);
            this.tabPageMinHyr.Controls.Add(this.label8);
            this.tabPageMinHyr.Location = new System.Drawing.Point(4, 22);
            this.tabPageMinHyr.Name = "tabPageMinHyr";
            this.tabPageMinHyr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMinHyr.Size = new System.Drawing.Size(604, 463);
            this.tabPageMinHyr.TabIndex = 2;
            this.tabPageMinHyr.Text = "Mina hyrningar";
            // 
            // panelHyrning
            // 
            this.panelHyrning.AutoScroll = true;
            this.panelHyrning.Controls.Add(this.labelHyrningMeddelande);
            this.panelHyrning.Controls.Add(this.tableLayoutPanelHyrning);
            this.panelHyrning.Location = new System.Drawing.Point(55, 34);
            this.panelHyrning.Name = "panelHyrning";
            this.panelHyrning.Size = new System.Drawing.Size(478, 370);
            this.panelHyrning.TabIndex = 5;
            // 
            // labelHyrningMeddelande
            // 
            this.labelHyrningMeddelande.AutoSize = true;
            this.labelHyrningMeddelande.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelHyrningMeddelande.Location = new System.Drawing.Point(0, 0);
            this.labelHyrningMeddelande.Name = "labelHyrningMeddelande";
            this.labelHyrningMeddelande.Size = new System.Drawing.Size(0, 13);
            this.labelHyrningMeddelande.TabIndex = 1;
            this.labelHyrningMeddelande.Visible = false;
            // 
            // tableLayoutPanelHyrning
            // 
            this.tableLayoutPanelHyrning.AutoSize = true;
            this.tableLayoutPanelHyrning.ColumnCount = 4;
            this.tableLayoutPanelHyrning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHyrning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHyrning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHyrning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelHyrning.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelHyrning.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelHyrning.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHyrning.Name = "tableLayoutPanelHyrning";
            this.tableLayoutPanelHyrning.RowCount = 1;
            this.tableLayoutPanelHyrning.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelHyrning.Size = new System.Drawing.Size(478, 0);
            this.tableLayoutPanelHyrning.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Hyrningar";
            // 
            // buttonOmOss
            // 
            this.buttonOmOss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOmOss.Location = new System.Drawing.Point(616, 261);
            this.buttonOmOss.Name = "buttonOmOss";
            this.buttonOmOss.Size = new System.Drawing.Size(90, 30);
            this.buttonOmOss.TabIndex = 33;
            this.buttonOmOss.Text = "Om Oss";
            this.buttonOmOss.UseVisualStyleBackColor = true;
            this.buttonOmOss.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonProfil
            // 
            this.buttonProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfil.Location = new System.Drawing.Point(616, 225);
            this.buttonProfil.Name = "buttonProfil";
            this.buttonProfil.Size = new System.Drawing.Size(90, 30);
            this.buttonProfil.TabIndex = 31;
            this.buttonProfil.Text = "Profil";
            this.buttonProfil.UseVisualStyleBackColor = true;
            this.buttonProfil.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonMinHyr
            // 
            this.buttonMinHyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinHyr.Location = new System.Drawing.Point(616, 172);
            this.buttonMinHyr.Name = "buttonMinHyr";
            this.buttonMinHyr.Size = new System.Drawing.Size(90, 47);
            this.buttonMinHyr.TabIndex = 29;
            this.buttonMinHyr.Text = "Mina hyrningar";
            this.buttonMinHyr.UseVisualStyleBackColor = true;
            this.buttonMinHyr.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonNyHyr
            // 
            this.buttonNyHyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNyHyr.Location = new System.Drawing.Point(616, 136);
            this.buttonNyHyr.Name = "buttonNyHyr";
            this.buttonNyHyr.Size = new System.Drawing.Size(90, 30);
            this.buttonNyHyr.TabIndex = 28;
            this.buttonNyHyr.Text = "Ny hyrning";
            this.buttonNyHyr.UseVisualStyleBackColor = true;
            this.buttonNyHyr.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonMeny
            // 
            this.buttonMeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeny.Location = new System.Drawing.Point(616, 100);
            this.buttonMeny.Name = "buttonMeny";
            this.buttonMeny.Size = new System.Drawing.Size(90, 30);
            this.buttonMeny.TabIndex = 6;
            this.buttonMeny.Text = "Menyn";
            this.buttonMeny.UseVisualStyleBackColor = true;
            this.buttonMeny.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // FormHyra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 484);
            this.Controls.Add(this.buttonOmOss);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonProfil);
            this.Controls.Add(this.buttonMeny);
            this.Controls.Add(this.buttonMinHyr);
            this.Controls.Add(this.buttonNyHyr);
            this.Name = "FormHyra";
            this.Text = "Hyra";
            this.tabControl1.ResumeLayout(false);
            this.tabPageMeny.ResumeLayout(false);
            this.tabPageNyHyr.ResumeLayout(false);
            this.tabPageNyHyr.PerformLayout();
            this.panelTyp.ResumeLayout(false);
            this.panelTyp.PerformLayout();
            this.tabPageMinHyr.ResumeLayout(false);
            this.tabPageMinHyr.PerformLayout();
            this.panelHyrning.ResumeLayout(false);
            this.panelHyrning.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMeny;
        private System.Windows.Forms.Button buttonProfil;
        private System.Windows.Forms.RichTextBox richTextBoxBokningMeny;
        private System.Windows.Forms.Button buttonMinHyr;
        private System.Windows.Forms.Button buttonNyHyr;
        private System.Windows.Forms.TabPage tabPageNyHyr;
        private System.Windows.Forms.RichTextBox richTextBoxMeddelandenHyra;
        private System.Windows.Forms.TabPage tabPageMinHyr;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonHyr;
        private System.Windows.Forms.Panel panelHyrning;
        private System.Windows.Forms.Label labelHyrningMeddelande;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHyrning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonMeny;
        private System.Windows.Forms.Button buttonOmOss;
        private System.Windows.Forms.Panel panelTyp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTyp;
        private System.Windows.Forms.Label labelFordonsTyp;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label labelTyp;
        private System.Windows.Forms.Label labelSlut;
        private System.Windows.Forms.Label labelStart;
    }
}