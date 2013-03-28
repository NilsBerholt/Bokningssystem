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
            this.buttonNyBoka = new System.Windows.Forms.Button();
            this.buttonMinBok = new System.Windows.Forms.Button();
            this.buttonProfil = new System.Windows.Forms.Button();
            this.buttonOmOss = new System.Windows.Forms.Button();
            this.buttonMinFordon = new System.Windows.Forms.Button();
            this.buttonMeny = new System.Windows.Forms.Button();
            this.tabPageMinFordon = new System.Windows.Forms.TabPage();
            this.panelBilar = new System.Windows.Forms.Panel();
            this.labelBilarMeddelande = new System.Windows.Forms.Label();
            this.tableLayoutPanelBilar = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPageMinBok = new System.Windows.Forms.TabPage();
            this.panelBokningar = new System.Windows.Forms.Panel();
            this.labelBokningarMeddelande = new System.Windows.Forms.Label();
            this.tableLayoutPanelBokningar = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPageNyBok = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonBoka = new System.Windows.Forms.Button();
            this.panelNyBil = new System.Windows.Forms.Panel();
            this.textBoxArsModell = new System.Windows.Forms.TextBox();
            this.labelModell = new System.Windows.Forms.Label();
            this.labelMarke = new System.Windows.Forms.Label();
            this.textBoxModell = new System.Windows.Forms.TextBox();
            this.labelArsmodell = new System.Windows.Forms.Label();
            this.textBoxMarke = new System.Windows.Forms.TextBox();
            this.comboBoxReg = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelSpec = new System.Windows.Forms.Label();
            this.richTextBoxMeddelandenBoka = new System.Windows.Forms.RichTextBox();
            this.panelTider = new System.Windows.Forms.Panel();
            this.timeButton_16 = new System.Windows.Forms.RadioButton();
            this.timeButton_14 = new System.Windows.Forms.RadioButton();
            this.timeButton_10 = new System.Windows.Forms.RadioButton();
            this.timeButton_08 = new System.Windows.Forms.RadioButton();
            this.buttonValjTid = new System.Windows.Forms.Button();
            this.tabPageMeny = new System.Windows.Forms.TabPage();
            this.richTextBoxBokningMeny = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMinFordon.SuspendLayout();
            this.panelBilar.SuspendLayout();
            this.tabPageMinBok.SuspendLayout();
            this.panelBokningar.SuspendLayout();
            this.tabPageNyBok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelNyBil.SuspendLayout();
            this.panelTider.SuspendLayout();
            this.tabPageMeny.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNyBoka
            // 
            this.buttonNyBoka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNyBoka.Location = new System.Drawing.Point(562, 142);
            this.buttonNyBoka.Name = "buttonNyBoka";
            this.buttonNyBoka.Size = new System.Drawing.Size(90, 30);
            this.buttonNyBoka.TabIndex = 28;
            this.buttonNyBoka.Text = "Ny bokning";
            this.buttonNyBoka.UseVisualStyleBackColor = true;
            this.buttonNyBoka.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonMinBok
            // 
            this.buttonMinBok.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinBok.Location = new System.Drawing.Point(562, 178);
            this.buttonMinBok.Name = "buttonMinBok";
            this.buttonMinBok.Size = new System.Drawing.Size(90, 47);
            this.buttonMinBok.TabIndex = 29;
            this.buttonMinBok.Text = "Mina bokningar";
            this.buttonMinBok.UseVisualStyleBackColor = true;
            this.buttonMinBok.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonProfil
            // 
            this.buttonProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProfil.Location = new System.Drawing.Point(562, 283);
            this.buttonProfil.Name = "buttonProfil";
            this.buttonProfil.Size = new System.Drawing.Size(90, 30);
            this.buttonProfil.TabIndex = 31;
            this.buttonProfil.Text = "Profil";
            this.buttonProfil.UseVisualStyleBackColor = true;
            this.buttonProfil.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonOmOss
            // 
            this.buttonOmOss.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOmOss.Location = new System.Drawing.Point(562, 319);
            this.buttonOmOss.Name = "buttonOmOss";
            this.buttonOmOss.Size = new System.Drawing.Size(90, 30);
            this.buttonOmOss.TabIndex = 32;
            this.buttonOmOss.Text = "Om Oss";
            this.buttonOmOss.UseVisualStyleBackColor = true;
            this.buttonOmOss.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonMinFordon
            // 
            this.buttonMinFordon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMinFordon.Location = new System.Drawing.Point(562, 231);
            this.buttonMinFordon.Name = "buttonMinFordon";
            this.buttonMinFordon.Size = new System.Drawing.Size(90, 46);
            this.buttonMinFordon.TabIndex = 31;
            this.buttonMinFordon.Text = "Mina fordon";
            this.buttonMinFordon.UseVisualStyleBackColor = true;
            this.buttonMinFordon.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // buttonMeny
            // 
            this.buttonMeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMeny.Location = new System.Drawing.Point(562, 106);
            this.buttonMeny.Name = "buttonMeny";
            this.buttonMeny.Size = new System.Drawing.Size(90, 30);
            this.buttonMeny.TabIndex = 32;
            this.buttonMeny.Text = "Menyn";
            this.buttonMeny.UseVisualStyleBackColor = true;
            this.buttonMeny.Click += new System.EventHandler(this.bytaTabPage);
            // 
            // tabPageMinFordon
            // 
            this.tabPageMinFordon.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMinFordon.Controls.Add(this.panelBilar);
            this.tabPageMinFordon.Controls.Add(this.label9);
            this.tabPageMinFordon.Location = new System.Drawing.Point(4, 22);
            this.tabPageMinFordon.Name = "tabPageMinFordon";
            this.tabPageMinFordon.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMinFordon.Size = new System.Drawing.Size(548, 438);
            this.tabPageMinFordon.TabIndex = 5;
            this.tabPageMinFordon.Text = "Mina fordon";
            // 
            // panelBilar
            // 
            this.panelBilar.Controls.Add(this.labelBilarMeddelande);
            this.panelBilar.Controls.Add(this.tableLayoutPanelBilar);
            this.panelBilar.Location = new System.Drawing.Point(150, 38);
            this.panelBilar.Name = "panelBilar";
            this.panelBilar.Size = new System.Drawing.Size(310, 370);
            this.panelBilar.TabIndex = 4;
            // 
            // labelBilarMeddelande
            // 
            this.labelBilarMeddelande.AutoSize = true;
            this.labelBilarMeddelande.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBilarMeddelande.Location = new System.Drawing.Point(0, 0);
            this.labelBilarMeddelande.Name = "labelBilarMeddelande";
            this.labelBilarMeddelande.Size = new System.Drawing.Size(0, 13);
            this.labelBilarMeddelande.TabIndex = 2;
            this.labelBilarMeddelande.Visible = false;
            // 
            // tableLayoutPanelBilar
            // 
            this.tableLayoutPanelBilar.AutoSize = true;
            this.tableLayoutPanelBilar.ColumnCount = 4;
            this.tableLayoutPanelBilar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBilar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBilar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBilar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBilar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelBilar.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBilar.Name = "tableLayoutPanelBilar";
            this.tableLayoutPanelBilar.RowCount = 1;
            this.tableLayoutPanelBilar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBilar.Size = new System.Drawing.Size(310, 0);
            this.tableLayoutPanelBilar.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(241, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "Mina bilar";
            // 
            // tabPageMinBok
            // 
            this.tabPageMinBok.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMinBok.Controls.Add(this.panelBokningar);
            this.tabPageMinBok.Controls.Add(this.label8);
            this.tabPageMinBok.Location = new System.Drawing.Point(4, 22);
            this.tabPageMinBok.Name = "tabPageMinBok";
            this.tabPageMinBok.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMinBok.Size = new System.Drawing.Size(548, 438);
            this.tabPageMinBok.TabIndex = 2;
            this.tabPageMinBok.Text = "Mina bokningar";
            // 
            // panelBokningar
            // 
            this.panelBokningar.AutoScroll = true;
            this.panelBokningar.Controls.Add(this.labelBokningarMeddelande);
            this.panelBokningar.Controls.Add(this.tableLayoutPanelBokningar);
            this.panelBokningar.Location = new System.Drawing.Point(118, 38);
            this.panelBokningar.Name = "panelBokningar";
            this.panelBokningar.Size = new System.Drawing.Size(360, 370);
            this.panelBokningar.TabIndex = 3;
            // 
            // labelBokningarMeddelande
            // 
            this.labelBokningarMeddelande.AutoSize = true;
            this.labelBokningarMeddelande.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelBokningarMeddelande.Location = new System.Drawing.Point(0, 0);
            this.labelBokningarMeddelande.Name = "labelBokningarMeddelande";
            this.labelBokningarMeddelande.Size = new System.Drawing.Size(0, 13);
            this.labelBokningarMeddelande.TabIndex = 1;
            this.labelBokningarMeddelande.Visible = false;
            // 
            // tableLayoutPanelBokningar
            // 
            this.tableLayoutPanelBokningar.AutoSize = true;
            this.tableLayoutPanelBokningar.ColumnCount = 3;
            this.tableLayoutPanelBokningar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBokningar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBokningar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelBokningar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360F));
            this.tableLayoutPanelBokningar.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelBokningar.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBokningar.Name = "tableLayoutPanelBokningar";
            this.tableLayoutPanelBokningar.RowCount = 1;
            this.tableLayoutPanelBokningar.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBokningar.Size = new System.Drawing.Size(360, 0);
            this.tableLayoutPanelBokningar.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(246, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "Bokningar";
            // 
            // tabPageNyBok
            // 
            this.tabPageNyBok.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageNyBok.Controls.Add(this.splitContainer1);
            this.tabPageNyBok.Location = new System.Drawing.Point(4, 22);
            this.tabPageNyBok.Name = "tabPageNyBok";
            this.tabPageNyBok.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNyBok.Size = new System.Drawing.Size(548, 438);
            this.tabPageNyBok.TabIndex = 1;
            this.tabPageNyBok.Text = "Ny bokning";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(6, 6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.monthCalendar1);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBoka);
            this.splitContainer1.Panel1.Controls.Add(this.panelNyBil);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxReg);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.labelSpec);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxMeddelandenBoka);
            this.splitContainer1.Panel2.Controls.Add(this.panelTider);
            this.splitContainer1.Size = new System.Drawing.Size(584, 394);
            this.splitContainer1.SplitterDistance = 265;
            this.splitContainer1.TabIndex = 33;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(44, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 31;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // buttonBoka
            // 
            this.buttonBoka.Location = new System.Drawing.Point(188, 362);
            this.buttonBoka.Name = "buttonBoka";
            this.buttonBoka.Size = new System.Drawing.Size(75, 23);
            this.buttonBoka.TabIndex = 30;
            this.buttonBoka.Text = "Boka";
            this.buttonBoka.UseVisualStyleBackColor = true;
            this.buttonBoka.Click += new System.EventHandler(this.buttonBoka_Click);
            // 
            // panelNyBil
            // 
            this.panelNyBil.Controls.Add(this.textBoxArsModell);
            this.panelNyBil.Controls.Add(this.labelModell);
            this.panelNyBil.Controls.Add(this.labelMarke);
            this.panelNyBil.Controls.Add(this.textBoxModell);
            this.panelNyBil.Controls.Add(this.labelArsmodell);
            this.panelNyBil.Controls.Add(this.textBoxMarke);
            this.panelNyBil.Location = new System.Drawing.Point(6, 258);
            this.panelNyBil.Name = "panelNyBil";
            this.panelNyBil.Size = new System.Drawing.Size(240, 105);
            this.panelNyBil.TabIndex = 32;
            // 
            // textBoxArsModell
            // 
            this.textBoxArsModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxArsModell.Location = new System.Drawing.Point(77, 72);
            this.textBoxArsModell.Name = "textBoxArsModell";
            this.textBoxArsModell.Size = new System.Drawing.Size(145, 26);
            this.textBoxArsModell.TabIndex = 18;
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
            this.textBoxModell.Location = new System.Drawing.Point(77, 3);
            this.textBoxModell.Name = "textBoxModell";
            this.textBoxModell.Size = new System.Drawing.Size(145, 26);
            this.textBoxModell.TabIndex = 15;
            // 
            // labelArsmodell
            // 
            this.labelArsmodell.AutoSize = true;
            this.labelArsmodell.BackColor = System.Drawing.Color.Transparent;
            this.labelArsmodell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArsmodell.Location = new System.Drawing.Point(-4, 78);
            this.labelArsmodell.Name = "labelArsmodell";
            this.labelArsmodell.Size = new System.Drawing.Size(83, 20);
            this.labelArsmodell.TabIndex = 19;
            this.labelArsmodell.Text = "Årsmodell:";
            // 
            // textBoxMarke
            // 
            this.textBoxMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMarke.Location = new System.Drawing.Point(77, 35);
            this.textBoxMarke.Name = "textBoxMarke";
            this.textBoxMarke.Size = new System.Drawing.Size(145, 26);
            this.textBoxMarke.TabIndex = 17;
            // 
            // comboBoxReg
            // 
            this.comboBoxReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReg.FormattingEnabled = true;
            this.comboBoxReg.Location = new System.Drawing.Point(83, 223);
            this.comboBoxReg.Name = "comboBoxReg";
            this.comboBoxReg.Size = new System.Drawing.Size(145, 28);
            this.comboBoxReg.TabIndex = 2;
            this.comboBoxReg.SelectedIndexChanged += new System.EventHandler(this.comboBoxReg_SelectedIndexChanged);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Regnr:";
            // 
            // labelSpec
            // 
            this.labelSpec.AutoSize = true;
            this.labelSpec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpec.Location = new System.Drawing.Point(15, 215);
            this.labelSpec.Name = "labelSpec";
            this.labelSpec.Size = new System.Drawing.Size(159, 20);
            this.labelSpec.TabIndex = 31;
            this.labelSpec.Text = "Problemspecifikation:";
            // 
            // richTextBoxMeddelandenBoka
            // 
            this.richTextBoxMeddelandenBoka.AcceptsTab = true;
            this.richTextBoxMeddelandenBoka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxMeddelandenBoka.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMeddelandenBoka.Location = new System.Drawing.Point(19, 245);
            this.richTextBoxMeddelandenBoka.Name = "richTextBoxMeddelandenBoka";
            this.richTextBoxMeddelandenBoka.Size = new System.Drawing.Size(238, 140);
            this.richTextBoxMeddelandenBoka.TabIndex = 28;
            this.richTextBoxMeddelandenBoka.Text = "";
            // 
            // panelTider
            // 
            this.panelTider.Controls.Add(this.timeButton_16);
            this.panelTider.Controls.Add(this.timeButton_14);
            this.panelTider.Controls.Add(this.timeButton_10);
            this.panelTider.Controls.Add(this.timeButton_08);
            this.panelTider.Controls.Add(this.buttonValjTid);
            this.panelTider.Location = new System.Drawing.Point(17, 5);
            this.panelTider.Name = "panelTider";
            this.panelTider.Size = new System.Drawing.Size(275, 187);
            this.panelTider.TabIndex = 30;
            // 
            // timeButton_16
            // 
            this.timeButton_16.AutoSize = true;
            this.timeButton_16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton_16.Location = new System.Drawing.Point(23, 113);
            this.timeButton_16.Name = "timeButton_16";
            this.timeButton_16.Size = new System.Drawing.Size(97, 19);
            this.timeButton_16.TabIndex = 3;
            this.timeButton_16.TabStop = true;
            this.timeButton_16.Text = "16:00 - 18:00";
            this.timeButton_16.UseVisualStyleBackColor = true;
            // 
            // timeButton_14
            // 
            this.timeButton_14.AutoSize = true;
            this.timeButton_14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton_14.Location = new System.Drawing.Point(23, 79);
            this.timeButton_14.Name = "timeButton_14";
            this.timeButton_14.Size = new System.Drawing.Size(97, 19);
            this.timeButton_14.TabIndex = 2;
            this.timeButton_14.TabStop = true;
            this.timeButton_14.Text = "14:00 - 16:00";
            this.timeButton_14.UseVisualStyleBackColor = true;
            // 
            // timeButton_10
            // 
            this.timeButton_10.AutoSize = true;
            this.timeButton_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton_10.Location = new System.Drawing.Point(23, 43);
            this.timeButton_10.Name = "timeButton_10";
            this.timeButton_10.Size = new System.Drawing.Size(97, 19);
            this.timeButton_10.TabIndex = 1;
            this.timeButton_10.TabStop = true;
            this.timeButton_10.Text = "10:00 - 12:00";
            this.timeButton_10.UseVisualStyleBackColor = true;
            // 
            // timeButton_08
            // 
            this.timeButton_08.AutoSize = true;
            this.timeButton_08.BackColor = System.Drawing.Color.Transparent;
            this.timeButton_08.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeButton_08.Location = new System.Drawing.Point(23, 11);
            this.timeButton_08.Name = "timeButton_08";
            this.timeButton_08.Size = new System.Drawing.Size(97, 19);
            this.timeButton_08.TabIndex = 0;
            this.timeButton_08.TabStop = true;
            this.timeButton_08.Text = "08:00 - 10:00";
            this.timeButton_08.UseVisualStyleBackColor = false;
            // 
            // buttonValjTid
            // 
            this.buttonValjTid.AutoSize = true;
            this.buttonValjTid.BackColor = System.Drawing.SystemColors.Control;
            this.buttonValjTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValjTid.Location = new System.Drawing.Point(165, 137);
            this.buttonValjTid.Name = "buttonValjTid";
            this.buttonValjTid.Size = new System.Drawing.Size(75, 25);
            this.buttonValjTid.TabIndex = 2;
            this.buttonValjTid.Text = "Välj tid";
            this.buttonValjTid.UseVisualStyleBackColor = false;
            this.buttonValjTid.Click += new System.EventHandler(this.buttonValjTid_Click);
            // 
            // tabPageMeny
            // 
            this.tabPageMeny.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageMeny.Controls.Add(this.richTextBoxBokningMeny);
            this.tabPageMeny.Location = new System.Drawing.Point(4, 22);
            this.tabPageMeny.Name = "tabPageMeny";
            this.tabPageMeny.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMeny.Size = new System.Drawing.Size(548, 438);
            this.tabPageMeny.TabIndex = 0;
            this.tabPageMeny.Text = "Meny";
            // 
            // richTextBoxBokningMeny
            // 
            this.richTextBoxBokningMeny.AcceptsTab = true;
            this.richTextBoxBokningMeny.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxBokningMeny.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxBokningMeny.Location = new System.Drawing.Point(29, 49);
            this.richTextBoxBokningMeny.Name = "richTextBoxBokningMeny";
            this.richTextBoxBokningMeny.ReadOnly = true;
            this.richTextBoxBokningMeny.Size = new System.Drawing.Size(168, 135);
            this.richTextBoxBokningMeny.TabIndex = 30;
            this.richTextBoxBokningMeny.TabStop = false;
            this.richTextBoxBokningMeny.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMeny);
            this.tabControl1.Controls.Add(this.tabPageNyBok);
            this.tabControl1.Controls.Add(this.tabPageMinBok);
            this.tabControl1.Controls.Add(this.tabPageMinFordon);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 464);
            this.tabControl1.TabIndex = 29;
            // 
            // FormBoka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 468);
            this.Controls.Add(this.buttonMinFordon);
            this.Controls.Add(this.buttonMeny);
            this.Controls.Add(this.buttonProfil);
            this.Controls.Add(this.buttonMinBok);
            this.Controls.Add(this.buttonOmOss);
            this.Controls.Add(this.buttonNyBoka);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBoka";
            this.Text = "Bokning";
            this.tabPageMinFordon.ResumeLayout(false);
            this.tabPageMinFordon.PerformLayout();
            this.panelBilar.ResumeLayout(false);
            this.panelBilar.PerformLayout();
            this.tabPageMinBok.ResumeLayout(false);
            this.tabPageMinBok.PerformLayout();
            this.panelBokningar.ResumeLayout(false);
            this.panelBokningar.PerformLayout();
            this.tabPageNyBok.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelNyBil.ResumeLayout(false);
            this.panelNyBil.PerformLayout();
            this.panelTider.ResumeLayout(false);
            this.panelTider.PerformLayout();
            this.tabPageMeny.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOmOss;
        private System.Windows.Forms.Button buttonProfil;
        private System.Windows.Forms.Button buttonMinBok;
        private System.Windows.Forms.Button buttonNyBoka;
        private System.Windows.Forms.Button buttonMinFordon;
        private System.Windows.Forms.Button buttonMeny;
        private System.Windows.Forms.TabPage tabPageMinFordon;
        private System.Windows.Forms.Panel panelBilar;
        private System.Windows.Forms.Label labelBilarMeddelande;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBilar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPageMinBok;
        private System.Windows.Forms.Panel panelBokningar;
        private System.Windows.Forms.Label labelBokningarMeddelande;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBokningar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPageNyBok;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonBoka;
        private System.Windows.Forms.Panel panelNyBil;
        private System.Windows.Forms.TextBox textBoxArsModell;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.Label labelMarke;
        private System.Windows.Forms.TextBox textBoxModell;
        private System.Windows.Forms.Label labelArsmodell;
        private System.Windows.Forms.TextBox textBoxMarke;
        private System.Windows.Forms.ComboBox comboBoxReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelSpec;
        private System.Windows.Forms.RichTextBox richTextBoxMeddelandenBoka;
        private System.Windows.Forms.Panel panelTider;
        private System.Windows.Forms.RadioButton timeButton_16;
        private System.Windows.Forms.RadioButton timeButton_14;
        private System.Windows.Forms.RadioButton timeButton_10;
        private System.Windows.Forms.RadioButton timeButton_08;
        private System.Windows.Forms.Button buttonValjTid;
        private System.Windows.Forms.TabPage tabPageMeny;
        private System.Windows.Forms.RichTextBox richTextBoxBokningMeny;
        private System.Windows.Forms.TabControl tabControl1;

    }
}