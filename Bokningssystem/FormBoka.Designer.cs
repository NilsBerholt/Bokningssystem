namespace Bokningssystem
{
    partial class FormBoka
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
            this.dateTimeDatum = new System.Windows.Forms.DateTimePicker();
            this.buttonNyBoka = new System.Windows.Forms.Button();
            this.buttonMinBok = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonBoka = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxReg = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.richTextBoxMeddelandenBoka = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panelNyBil = new System.Windows.Forms.Panel();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelMarke = new System.Windows.Forms.Label();
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.labelArsmodell = new System.Windows.Forms.Label();
            this.textBoxArsModell = new System.Windows.Forms.TextBox();
            this.textBoxMarke = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMeny = new System.Windows.Forms.TabPage();
            this.richTextBoxBokningMeny = new System.Windows.Forms.RichTextBox();
            this.tabPageNyBok = new System.Windows.Forms.TabPage();
            this.tabPageMinBok = new System.Windows.Forms.TabPage();
            this.panelMinBok = new System.Windows.Forms.Panel();
            this.tabPageProfil = new System.Windows.Forms.TabPage();
            this.buttonRedigera = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelEditLosen = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEditAdress = new System.Windows.Forms.Label();
            this.labelEditTfn = new System.Windows.Forms.Label();
            this.labelEditEmail = new System.Windows.Forms.Label();
            this.labelEditNamn = new System.Windows.Forms.Label();
            this.labelNamn = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelTfn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelNyBil.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMeny.SuspendLayout();
            this.tabPageNyBok.SuspendLayout();
            this.tabPageMinBok.SuspendLayout();
            this.tabPageProfil.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeDatum
            // 
            this.dateTimeDatum.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDatum.Location = new System.Drawing.Point(532, 31);
            this.dateTimeDatum.Name = "dateTimeDatum";
            this.dateTimeDatum.Size = new System.Drawing.Size(172, 26);
            this.dateTimeDatum.TabIndex = 2;
            // 
            // buttonNyBoka
            // 
            this.buttonNyBoka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNyBoka.Location = new System.Drawing.Point(254, 210);
            this.buttonNyBoka.Name = "buttonNyBoka";
            this.buttonNyBoka.Size = new System.Drawing.Size(105, 29);
            this.buttonNyBoka.TabIndex = 28;
            this.buttonNyBoka.Text = "Ny bokning";
            this.buttonNyBoka.UseVisualStyleBackColor = true;
            this.buttonNyBoka.Click += new System.EventHandler(this.buttonNyBoka_Click);
            // 
            // buttonMinBok
            // 
            this.buttonMinBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinBok.Location = new System.Drawing.Point(29, 210);
            this.buttonMinBok.Name = "buttonMinBok";
            this.buttonMinBok.Size = new System.Drawing.Size(126, 29);
            this.buttonMinBok.TabIndex = 29;
            this.buttonMinBok.Text = "Mina bokningar";
            this.buttonMinBok.UseVisualStyleBackColor = true;
            this.buttonMinBok.Click += new System.EventHandler(this.buttonMinBok_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regnr:";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 29);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 31;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // buttonBoka
            // 
            this.buttonBoka.Location = new System.Drawing.Point(172, 341);
            this.buttonBoka.Name = "buttonBoka";
            this.buttonBoka.Size = new System.Drawing.Size(75, 23);
            this.buttonBoka.TabIndex = 30;
            this.buttonBoka.Text = "Boka";
            this.buttonBoka.UseVisualStyleBackColor = true;
            this.buttonBoka.Click += new System.EventHandler(this.buttonBoka_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum:";
            // 
            // comboBoxReg
            // 
            this.comboBoxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReg.FormattingEnabled = true;
            this.comboBoxReg.Location = new System.Drawing.Point(92, 196);
            this.comboBoxReg.Name = "comboBoxReg";
            this.comboBoxReg.Size = new System.Drawing.Size(145, 28);
            this.comboBoxReg.TabIndex = 2;
            this.comboBoxReg.SelectedIndexChanged += new System.EventHandler(this.comboBoxReg_SelectedIndexChanged);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelError.Location = new System.Drawing.Point(13, 193);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(31, 17);
            this.labelError.TabIndex = 27;
            this.labelError.Text = "asd";
            // 
            // richTextBoxMeddelandenBoka
            // 
            this.richTextBoxMeddelandenBoka.AcceptsTab = true;
            this.richTextBoxMeddelandenBoka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxMeddelandenBoka.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMeddelandenBoka.Location = new System.Drawing.Point(3, 16);
            this.richTextBoxMeddelandenBoka.Name = "richTextBoxMeddelandenBoka";
            this.richTextBoxMeddelandenBoka.ReadOnly = true;
            this.richTextBoxMeddelandenBoka.Size = new System.Drawing.Size(168, 135);
            this.richTextBoxMeddelandenBoka.TabIndex = 28;
            this.richTextBoxMeddelandenBoka.TabStop = false;
            this.richTextBoxMeddelandenBoka.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxMeddelandenBoka);
            this.splitContainer1.Panel1.Controls.Add(this.labelError);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelNyBil);
            this.splitContainer1.Panel2.Controls.Add(this.comboBoxReg);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.buttonBoka);
            this.splitContainer1.Panel2.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(468, 366);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 33;
            // 
            // panelNyBil
            // 
            this.panelNyBil.Controls.Add(this.labelModell);
            this.panelNyBil.Controls.Add(this.labelMarke);
            this.panelNyBil.Controls.Add(this.textBoxModell);
            this.panelNyBil.Controls.Add(this.labelArsmodell);
            this.panelNyBil.Controls.Add(this.textBoxArsModell);
            this.panelNyBil.Controls.Add(this.textBoxMarke);
            this.panelNyBil.Location = new System.Drawing.Point(7, 230);
            this.panelNyBil.Name = "panelNyBil";
            this.panelNyBil.Size = new System.Drawing.Size(240, 105);
            this.panelNyBil.TabIndex = 32;
            // 
            // labelModell
            // 
            this.labelModell.AutoSize = true;
            this.labelModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModell.Location = new System.Drawing.Point(-4, 9);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(59, 20);
            this.labelModell.TabIndex = 16;
            this.labelModell.Text = "Modell:";
            // 
            // labelMarke
            // 
            this.labelMarke.AutoSize = true;
            this.labelMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarke.Location = new System.Drawing.Point(-4, 43);
            this.labelMarke.Name = "labelMarke";
            this.labelMarke.Size = new System.Drawing.Size(57, 20);
            this.labelMarke.TabIndex = 14;
            this.labelMarke.Text = "Märke:";
            // 
            // textBoxModell
            // 
            this.textBoxModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxModell.Location = new System.Drawing.Point(85, 6);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.Size = new System.Drawing.Size(145, 26);
            this.textBoxModell.TabIndex = 15;
            // 
            // labelArsmodell
            // 
            this.labelArsmodell.AutoSize = true;
            this.labelArsmodell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArsmodell.Location = new System.Drawing.Point(-4, 78);
            this.labelArsmodell.Name = "labelArsmodell";
            this.labelArsmodell.Size = new System.Drawing.Size(83, 20);
            this.labelArsmodell.TabIndex = 19;
            this.labelArsmodell.Text = "Årsmodell:";
            // 
            // textBoxArsModell
            // 
            this.textBoxArsModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArsModell.Location = new System.Drawing.Point(85, 75);
            this.textBoxArsModell.Name = "textBoxArsModell";
            this.textBoxArsModell.Size = new System.Drawing.Size(145, 26);
            this.textBoxArsModell.TabIndex = 18;
            // 
            // textBoxMarke
            // 
            this.textBoxMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarke.Location = new System.Drawing.Point(85, 38);
            this.textBoxMarke.Name = "textBoxMarke";
            this.textBoxMarke.Size = new System.Drawing.Size(145, 26);
            this.textBoxMarke.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMeny);
            this.tabControl1.Controls.Add(this.tabPageNyBok);
            this.tabControl1.Controls.Add(this.tabPageMinBok);
            this.tabControl1.Controls.Add(this.tabPageProfil);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 412);
            this.tabControl1.TabIndex = 29;
            // 
            // tabPageMeny
            // 
            this.tabPageMeny.Controls.Add(this.richTextBoxBokningMeny);
            this.tabPageMeny.Controls.Add(this.buttonMinBok);
            this.tabPageMeny.Controls.Add(this.buttonNyBoka);
            this.tabPageMeny.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeny.Name = "tabPageMeny";
            this.tabPageMeny.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeny.Size = new System.Drawing.Size(477, 386);
            this.tabPageMeny.TabIndex = 0;
            this.tabPageMeny.Text = "Meny";
            this.tabPageMeny.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBokningMeny
            // 
            this.richTextBoxBokningMeny.AcceptsTab = true;
            this.richTextBoxBokningMeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxBokningMeny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBokningMeny.Location = new System.Drawing.Point(29, 25);
            this.richTextBoxBokningMeny.Name = "richTextBoxBokningMeny";
            this.richTextBoxBokningMeny.ReadOnly = true;
            this.richTextBoxBokningMeny.Size = new System.Drawing.Size(168, 135);
            this.richTextBoxBokningMeny.TabIndex = 30;
            this.richTextBoxBokningMeny.TabStop = false;
            this.richTextBoxBokningMeny.Text = "";
            // 
            // tabPageNyBok
            // 
            this.tabPageNyBok.Controls.Add(this.splitContainer1);
            this.tabPageNyBok.Location = new System.Drawing.Point(4, 22);
            this.tabPageNyBok.Name = "tabPageNyBok";
            this.tabPageNyBok.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNyBok.Size = new System.Drawing.Size(477, 386);
            this.tabPageNyBok.TabIndex = 1;
            this.tabPageNyBok.Text = "Ny bokning";
            this.tabPageNyBok.UseVisualStyleBackColor = true;
            // 
            // tabPageMinBok
            // 
            this.tabPageMinBok.Controls.Add(this.panelMinBok);
            this.tabPageMinBok.Location = new System.Drawing.Point(4, 22);
            this.tabPageMinBok.Name = "tabPageMinBok";
            this.tabPageMinBok.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMinBok.Size = new System.Drawing.Size(477, 386);
            this.tabPageMinBok.TabIndex = 2;
            this.tabPageMinBok.Text = "Mina bokningar";
            this.tabPageMinBok.UseVisualStyleBackColor = true;
            // 
            // panelMinBok
            // 
            this.panelMinBok.Location = new System.Drawing.Point(3, 6);
            this.panelMinBok.Name = "panelMinBok";
            this.panelMinBok.Size = new System.Drawing.Size(471, 384);
            this.panelMinBok.TabIndex = 0;
            // 
            // tabPageProfil
            // 
            this.tabPageProfil.Controls.Add(this.buttonRedigera);
            this.tabPageProfil.Controls.Add(this.maskedTextBox1);
            this.tabPageProfil.Controls.Add(this.labelEditLosen);
            this.tabPageProfil.Controls.Add(this.tableLayoutPanel1);
            this.tabPageProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageProfil.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfil.Name = "tabPageProfil";
            this.tabPageProfil.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfil.Size = new System.Drawing.Size(477, 386);
            this.tabPageProfil.TabIndex = 3;
            this.tabPageProfil.Text = "Profil";
            this.tabPageProfil.UseVisualStyleBackColor = true;
            // 
            // buttonRedigera
            // 
            this.buttonRedigera.Location = new System.Drawing.Point(339, 323);
            this.buttonRedigera.Name = "buttonRedigera";
            this.buttonRedigera.Size = new System.Drawing.Size(75, 23);
            this.buttonRedigera.TabIndex = 12;
            this.buttonRedigera.Text = "Redigera";
            this.buttonRedigera.UseVisualStyleBackColor = true;
            this.buttonRedigera.Click += new System.EventHandler(this.buttonRedigera_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(31, 305);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(115, 20);
            this.maskedTextBox1.TabIndex = 11;
            // 
            // labelEditLosen
            // 
            this.labelEditLosen.AutoSize = true;
            this.labelEditLosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditLosen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelEditLosen.Location = new System.Drawing.Point(357, 213);
            this.labelEditLosen.Name = "labelEditLosen";
            this.labelEditLosen.Size = new System.Drawing.Size(74, 15);
            this.labelEditLosen.TabIndex = 10;
            this.labelEditLosen.Text = "Byt lösenord";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.labelEditAdress, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelEditTfn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEditEmail, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelEditNamn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelNamn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelEmail, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelAdress, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelTfn, 1, 2);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(465, 204);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEditAdress
            // 
            this.labelEditAdress.AutoSize = true;
            this.labelEditAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditAdress.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelEditAdress.Location = new System.Drawing.Point(351, 153);
            this.labelEditAdress.Name = "labelEditAdress";
            this.labelEditAdress.Size = new System.Drawing.Size(37, 15);
            this.labelEditAdress.TabIndex = 9;
            this.labelEditAdress.Text = "Edit...";
            // 
            // labelEditTfn
            // 
            this.labelEditTfn.AutoSize = true;
            this.labelEditTfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditTfn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelEditTfn.Location = new System.Drawing.Point(351, 102);
            this.labelEditTfn.Name = "labelEditTfn";
            this.labelEditTfn.Size = new System.Drawing.Size(37, 15);
            this.labelEditTfn.TabIndex = 8;
            this.labelEditTfn.Text = "Edit...";
            // 
            // labelEditEmail
            // 
            this.labelEditEmail.AutoSize = true;
            this.labelEditEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditEmail.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelEditEmail.Location = new System.Drawing.Point(351, 51);
            this.labelEditEmail.Name = "labelEditEmail";
            this.labelEditEmail.Size = new System.Drawing.Size(37, 15);
            this.labelEditEmail.TabIndex = 7;
            this.labelEditEmail.Text = "Edit...";
            // 
            // labelEditNamn
            // 
            this.labelEditNamn.AutoSize = true;
            this.labelEditNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditNamn.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelEditNamn.Location = new System.Drawing.Point(351, 0);
            this.labelEditNamn.Name = "labelEditNamn";
            this.labelEditNamn.Size = new System.Drawing.Size(37, 15);
            this.labelEditNamn.TabIndex = 6;
            this.labelEditNamn.Text = "Edit...";
            this.labelEditNamn.Click += new System.EventHandler(this.labelEditNamn_Click);
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Location = new System.Drawing.Point(119, 0);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(46, 18);
            this.labelNamn.TabIndex = 1;
            this.labelNamn.Text = "label8";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(119, 51);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 18);
            this.labelEmail.TabIndex = 2;
            this.labelEmail.Text = "label9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Epost-adress:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 36);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon nummer:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 18);
            this.label6.TabIndex = 3;
            this.label6.Text = "Adress:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namn:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(119, 153);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(54, 18);
            this.labelAdress.TabIndex = 4;
            this.labelAdress.Text = "label11";
            // 
            // labelTfn
            // 
            this.labelTfn.AutoSize = true;
            this.labelTfn.Location = new System.Drawing.Point(119, 102);
            this.labelTfn.Name = "labelTfn";
            this.labelTfn.Size = new System.Drawing.Size(54, 18);
            this.labelTfn.TabIndex = 3;
            this.labelTfn.Text = "label10";
            // 
            // FormBoka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 436);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dateTimeDatum);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBoka";
            this.Text = "Bokning";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelNyBil.ResumeLayout(false);
            this.panelNyBil.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMeny.ResumeLayout(false);
            this.tabPageNyBok.ResumeLayout(false);
            this.tabPageMinBok.ResumeLayout(false);
            this.tabPageProfil.ResumeLayout(false);
            this.tabPageProfil.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeDatum;
        private System.Windows.Forms.Button buttonNyBoka;
        private System.Windows.Forms.Button buttonMinBok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonBoka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxReg;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.RichTextBox richTextBoxMeddelandenBoka;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panelNyBil;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.Label labelMarke;
        private System.Windows.Forms.TextBox textBoxModell;
        private System.Windows.Forms.Label labelArsmodell;
        private System.Windows.Forms.TextBox textBoxArsModell;
        private System.Windows.Forms.TextBox textBoxMarke;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMeny;
        private System.Windows.Forms.TabPage tabPageNyBok;
        private System.Windows.Forms.TabPage tabPageMinBok;
        private System.Windows.Forms.RichTextBox richTextBoxBokningMeny;
        private System.Windows.Forms.Panel panelMinBok;
        private System.Windows.Forms.TabPage tabPageProfil;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEditLosen;
        private System.Windows.Forms.Label labelEditAdress;
        private System.Windows.Forms.Label labelEditTfn;
        private System.Windows.Forms.Label labelEditEmail;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelTfn;
        private System.Windows.Forms.Label labelEditNamn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button buttonRedigera;
    }
}