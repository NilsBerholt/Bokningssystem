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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.buttonHyr = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMeddelandenHyra = new System.Windows.Forms.RichTextBox();
            this.panelTider = new System.Windows.Forms.Panel();
            this.maskedTextBoxDagar = new System.Windows.Forms.MaskedTextBox();
            this.labelDagar = new System.Windows.Forms.Label();
            this.buttonDagar = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelTider.SuspendLayout();
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
            this.tabPageNyHyr.Controls.Add(this.splitContainer1);
            this.tabPageNyHyr.Location = new System.Drawing.Point(4, 22);
            this.tabPageNyHyr.Name = "tabPageNyHyr";
            this.tabPageNyHyr.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNyHyr.Size = new System.Drawing.Size(604, 463);
            this.tabPageNyHyr.TabIndex = 1;
            this.tabPageNyHyr.Text = "Ny hyrning";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkedListBox1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonHyr);
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxMeddelandenHyra);
            this.splitContainer1.Panel2.Controls.Add(this.panelTider);
            this.splitContainer1.Size = new System.Drawing.Size(584, 394);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 33;
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
            this.checkedListBox1.Location = new System.Drawing.Point(44, 204);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(149, 109);
            this.checkedListBox1.TabIndex = 33;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.ItemCheck);
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
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
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(44, 30);
            this.monthCalendar1.MaxSelectionCount = 99999999;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 31;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum:";
            // 
            // richTextBoxMeddelandenHyra
            // 
            this.richTextBoxMeddelandenHyra.AcceptsTab = true;
            this.richTextBoxMeddelandenHyra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxMeddelandenHyra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMeddelandenHyra.Location = new System.Drawing.Point(30, 208);
            this.richTextBoxMeddelandenHyra.Name = "richTextBoxMeddelandenHyra";
            this.richTextBoxMeddelandenHyra.ReadOnly = true;
            this.richTextBoxMeddelandenHyra.Size = new System.Drawing.Size(238, 164);
            this.richTextBoxMeddelandenHyra.TabIndex = 28;
            this.richTextBoxMeddelandenHyra.TabStop = false;
            this.richTextBoxMeddelandenHyra.Text = "";
            // 
            // panelTider
            // 
            this.panelTider.Controls.Add(this.maskedTextBoxDagar);
            this.panelTider.Controls.Add(this.labelDagar);
            this.panelTider.Controls.Add(this.buttonDagar);
            this.panelTider.Location = new System.Drawing.Point(17, 5);
            this.panelTider.Name = "panelTider";
            this.panelTider.Size = new System.Drawing.Size(275, 187);
            this.panelTider.TabIndex = 30;
            // 
            // maskedTextBoxDagar
            // 
            this.maskedTextBoxDagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxDagar.Location = new System.Drawing.Point(13, 55);
            this.maskedTextBoxDagar.Name = "maskedTextBoxDagar";
            this.maskedTextBoxDagar.Size = new System.Drawing.Size(129, 26);
            this.maskedTextBoxDagar.TabIndex = 2;
            // 
            // labelDagar
            // 
            this.labelDagar.AutoSize = true;
            this.labelDagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDagar.Location = new System.Drawing.Point(9, 13);
            this.labelDagar.Name = "labelDagar";
            this.labelDagar.Size = new System.Drawing.Size(133, 20);
            this.labelDagar.TabIndex = 1;
            this.labelDagar.Text = "Hur många dagar";
            // 
            // buttonDagar
            // 
            this.buttonDagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDagar.Location = new System.Drawing.Point(165, 52);
            this.buttonDagar.Name = "buttonDagar";
            this.buttonDagar.Size = new System.Drawing.Size(86, 33);
            this.buttonDagar.TabIndex = 0;
            this.buttonDagar.Text = "Välj dagar";
            this.buttonDagar.UseVisualStyleBackColor = true;
            this.buttonDagar.Click += new System.EventHandler(this.buttonDagar_Click);
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
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelTider.ResumeLayout(false);
            this.panelTider.PerformLayout();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxMeddelandenHyra;
        private System.Windows.Forms.Panel panelTider;
        private System.Windows.Forms.TabPage tabPageMinHyr;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button buttonHyr;
        private System.Windows.Forms.Label labelDagar;
        private System.Windows.Forms.Button buttonDagar;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDagar;
        private System.Windows.Forms.Panel panelHyrning;
        private System.Windows.Forms.Label labelHyrningMeddelande;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHyrning;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonMeny;
        private System.Windows.Forms.Button buttonOmOss;
    }
}