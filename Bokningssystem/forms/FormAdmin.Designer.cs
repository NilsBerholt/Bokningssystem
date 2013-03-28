namespace Bokningssystem
{
    partial class FormAdmin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.visaBokningar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.nyHyrning = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visaHyrningar = new System.Windows.Forms.ToolStripMenuItem();
            this.läggTillHyrfordon = new System.Windows.Forms.ToolStripMenuItem();
            this.omOss = new System.Windows.Forms.ToolStripMenuItem();
            this.flowPanelRoot = new System.Windows.Forms.FlowLayoutPanel();
            this.panelVisaBok = new System.Windows.Forms.Panel();
            this.panelBokDag = new System.Windows.Forms.Panel();
            this.labelTid16 = new System.Windows.Forms.Label();
            this.labelTid14 = new System.Windows.Forms.Label();
            this.labelTid10 = new System.Windows.Forms.Label();
            this.labelTid08 = new System.Windows.Forms.Label();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelInfoProblem = new System.Windows.Forms.Panel();
            this.richTextBoxInfoProblem = new System.Windows.Forms.RichTextBox();
            this.panelInfoBil = new System.Windows.Forms.Panel();
            this.richTextBoxInfoBil = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelDag = new System.Windows.Forms.Label();
            this.labelValj = new System.Windows.Forms.Label();
            this.monthCalendarBokning = new System.Windows.Forms.MonthCalendar();
            this.panelNyBok = new System.Windows.Forms.Panel();
            this.labelNyBokTid = new System.Windows.Forms.Label();
            this.labelNyBokDag = new System.Windows.Forms.Label();
            this.richTextBoxBokMeddelande = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.maskedTextBoxArsmodell = new System.Windows.Forms.MaskedTextBox();
            this.labelArsmodell = new System.Windows.Forms.Label();
            this.maskedTextBoxModell = new System.Windows.Forms.MaskedTextBox();
            this.labelModell = new System.Windows.Forms.Label();
            this.maskedTextBoxMarke = new System.Windows.Forms.MaskedTextBox();
            this.labelMarke = new System.Windows.Forms.Label();
            this.buttonBoka = new System.Windows.Forms.Button();
            this.maskedTextBoxReg = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTfn = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxNamn = new System.Windows.Forms.MaskedTextBox();
            this.labelReg = new System.Windows.Forms.Label();
            this.labelTfn = new System.Windows.Forms.Label();
            this.labelNamn = new System.Windows.Forms.Label();
            this.panelNyHyr = new System.Windows.Forms.Panel();
            this.maskedTextBoxPersnr = new System.Windows.Forms.MaskedTextBox();
            this.labelPersnr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.monthCalendarHyrning = new System.Windows.Forms.MonthCalendar();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelNyHyrfordon = new System.Windows.Forms.Panel();
            this.checkedListBoxFordonsTyp = new System.Windows.Forms.CheckedListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonLäggTillFordon = new System.Windows.Forms.Button();
            this.TextBoxArsmodell = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TextBoxModell = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TextBoxMarke = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TextBoxReg = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBoxFormAdminMsgs = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.flowPanelRoot.SuspendLayout();
            this.panelVisaBok.SuspendLayout();
            this.panelBokDag.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.panelInfoProblem.SuspendLayout();
            this.panelInfoBil.SuspendLayout();
            this.panelNyBok.SuspendLayout();
            this.panelNyHyr.SuspendLayout();
            this.panelNyHyrfordon.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visaBokningar,
            this.toolStripMenuItem2,
            this.omOss});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // visaBokningar
            // 
            this.visaBokningar.Name = "visaBokningar";
            this.visaBokningar.Size = new System.Drawing.Size(73, 20);
            this.visaBokningar.Text = "Bokningar";
            this.visaBokningar.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nyHyrning,
            this.visaHyrningar,
            this.toolStripSeparator2,
            this.läggTillHyrfordon});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(72, 20);
            this.toolStripMenuItem2.Text = "Hyrningar";
            // 
            // nyHyrning
            // 
            this.nyHyrning.Name = "nyHyrning";
            this.nyHyrning.Size = new System.Drawing.Size(172, 22);
            this.nyHyrning.Text = "Ny hyrning";
            this.nyHyrning.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(169, 6);
            // 
            // visaHyrningar
            // 
            this.visaHyrningar.Name = "visaHyrningar";
            this.visaHyrningar.Size = new System.Drawing.Size(172, 22);
            this.visaHyrningar.Text = "Visa hyrningar";
            this.visaHyrningar.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // läggTillHyrfordon
            // 
            this.läggTillHyrfordon.Name = "läggTillHyrfordon";
            this.läggTillHyrfordon.Size = new System.Drawing.Size(172, 22);
            this.läggTillHyrfordon.Text = "Lägg till hyrfordon";
            this.läggTillHyrfordon.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // omOss
            // 
            this.omOss.Name = "omOss";
            this.omOss.Size = new System.Drawing.Size(59, 20);
            this.omOss.Text = "Om oss";
            this.omOss.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // flowPanelRoot
            // 
            this.flowPanelRoot.AutoSize = true;
            this.flowPanelRoot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowPanelRoot.Controls.Add(this.panelVisaBok);
            this.flowPanelRoot.Controls.Add(this.panelNyBok);
            this.flowPanelRoot.Controls.Add(this.panelNyHyr);
            this.flowPanelRoot.Controls.Add(this.panelNyHyrfordon);
            this.flowPanelRoot.Controls.Add(this.richTextBoxFormAdminMsgs);
            this.flowPanelRoot.Controls.Add(this.panel1);
            this.flowPanelRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowPanelRoot.Location = new System.Drawing.Point(0, 24);
            this.flowPanelRoot.MaximumSize = new System.Drawing.Size(800, 12000);
            this.flowPanelRoot.MinimumSize = new System.Drawing.Size(400, 200);
            this.flowPanelRoot.Name = "flowPanelRoot";
            this.flowPanelRoot.Size = new System.Drawing.Size(800, 725);
            this.flowPanelRoot.TabIndex = 1;
            // 
            // panelVisaBok
            // 
            this.panelVisaBok.AutoSize = true;
            this.panelVisaBok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelVisaBok.Controls.Add(this.panelBokDag);
            this.panelVisaBok.Controls.Add(this.labelValj);
            this.panelVisaBok.Controls.Add(this.monthCalendarBokning);
            this.panelVisaBok.Location = new System.Drawing.Point(3, 3);
            this.panelVisaBok.Name = "panelVisaBok";
            this.panelVisaBok.Size = new System.Drawing.Size(771, 202);
            this.panelVisaBok.TabIndex = 2;
            this.panelVisaBok.Visible = false;
            // 
            // panelBokDag
            // 
            this.panelBokDag.Controls.Add(this.labelTid16);
            this.panelBokDag.Controls.Add(this.labelTid14);
            this.panelBokDag.Controls.Add(this.labelTid10);
            this.panelBokDag.Controls.Add(this.labelTid08);
            this.panelBokDag.Controls.Add(this.panelInfo);
            this.panelBokDag.Controls.Add(this.label16);
            this.panelBokDag.Controls.Add(this.label14);
            this.panelBokDag.Controls.Add(this.label10);
            this.panelBokDag.Controls.Add(this.label8);
            this.panelBokDag.Controls.Add(this.labelDag);
            this.panelBokDag.Location = new System.Drawing.Point(238, 4);
            this.panelBokDag.Name = "panelBokDag";
            this.panelBokDag.Size = new System.Drawing.Size(530, 189);
            this.panelBokDag.TabIndex = 2;
            this.panelBokDag.Visible = false;
            // 
            // labelTid16
            // 
            this.labelTid16.AutoSize = true;
            this.labelTid16.Location = new System.Drawing.Point(355, 60);
            this.labelTid16.Name = "labelTid16";
            this.labelTid16.Size = new System.Drawing.Size(35, 13);
            this.labelTid16.TabIndex = 15;
            this.labelTid16.Text = "label7";
            // 
            // labelTid14
            // 
            this.labelTid14.AutoSize = true;
            this.labelTid14.Location = new System.Drawing.Point(243, 60);
            this.labelTid14.Name = "labelTid14";
            this.labelTid14.Size = new System.Drawing.Size(35, 13);
            this.labelTid14.TabIndex = 14;
            this.labelTid14.Text = "label6";
            // 
            // labelTid10
            // 
            this.labelTid10.AutoSize = true;
            this.labelTid10.Location = new System.Drawing.Point(131, 60);
            this.labelTid10.Name = "labelTid10";
            this.labelTid10.Size = new System.Drawing.Size(35, 13);
            this.labelTid10.TabIndex = 13;
            this.labelTid10.Text = "label5";
            // 
            // labelTid08
            // 
            this.labelTid08.AutoSize = true;
            this.labelTid08.Location = new System.Drawing.Point(19, 60);
            this.labelTid08.Name = "labelTid08";
            this.labelTid08.Size = new System.Drawing.Size(35, 13);
            this.labelTid08.TabIndex = 12;
            this.labelTid08.Text = "label4";
            // 
            // panelInfo
            // 
            this.panelInfo.Controls.Add(this.panelInfoProblem);
            this.panelInfo.Controls.Add(this.panelInfoBil);
            this.panelInfo.Location = new System.Drawing.Point(3, 89);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(524, 100);
            this.panelInfo.TabIndex = 11;
            // 
            // panelInfoProblem
            // 
            this.panelInfoProblem.Controls.Add(this.richTextBoxInfoProblem);
            this.panelInfoProblem.Location = new System.Drawing.Point(209, 3);
            this.panelInfoProblem.Name = "panelInfoProblem";
            this.panelInfoProblem.Size = new System.Drawing.Size(312, 93);
            this.panelInfoProblem.TabIndex = 1;
            // 
            // richTextBoxInfoProblem
            // 
            this.richTextBoxInfoProblem.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxInfoProblem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoProblem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfoProblem.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfoProblem.Name = "richTextBoxInfoProblem";
            this.richTextBoxInfoProblem.ReadOnly = true;
            this.richTextBoxInfoProblem.Size = new System.Drawing.Size(312, 93);
            this.richTextBoxInfoProblem.TabIndex = 20;
            this.richTextBoxInfoProblem.Text = "";
            // 
            // panelInfoBil
            // 
            this.panelInfoBil.Controls.Add(this.richTextBoxInfoBil);
            this.panelInfoBil.Location = new System.Drawing.Point(3, 3);
            this.panelInfoBil.Name = "panelInfoBil";
            this.panelInfoBil.Size = new System.Drawing.Size(200, 93);
            this.panelInfoBil.TabIndex = 0;
            // 
            // richTextBoxInfoBil
            // 
            this.richTextBoxInfoBil.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxInfoBil.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxInfoBil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxInfoBil.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInfoBil.Name = "richTextBoxInfoBil";
            this.richTextBoxInfoBil.ReadOnly = true;
            this.richTextBoxInfoBil.Size = new System.Drawing.Size(200, 93);
            this.richTextBoxInfoBil.TabIndex = 19;
            this.richTextBoxInfoBil.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(355, 27);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 17);
            this.label16.TabIndex = 6;
            this.label16.Text = "16:00 - 18:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(243, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 5;
            this.label14.Text = "14:00 - 16:00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(131, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "10:00 - 12:00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "08:00 - 10:00";
            // 
            // labelDag
            // 
            this.labelDag.AutoSize = true;
            this.labelDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDag.Location = new System.Drawing.Point(7, 0);
            this.labelDag.Name = "labelDag";
            this.labelDag.Size = new System.Drawing.Size(312, 18);
            this.labelDag.TabIndex = 2;
            this.labelDag.Text = "Någon text som handlar om dagens bokningar";
            // 
            // labelValj
            // 
            this.labelValj.AutoSize = true;
            this.labelValj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValj.Location = new System.Drawing.Point(10, 4);
            this.labelValj.Name = "labelValj";
            this.labelValj.Size = new System.Drawing.Size(154, 18);
            this.labelValj.TabIndex = 1;
            this.labelValj.Text = "Välj en dag i kalendern";
            // 
            // monthCalendarBokning
            // 
            this.monthCalendarBokning.Location = new System.Drawing.Point(6, 31);
            this.monthCalendarBokning.MaxSelectionCount = 1;
            this.monthCalendarBokning.Name = "monthCalendarBokning";
            this.monthCalendarBokning.TabIndex = 0;
            this.monthCalendarBokning.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarBokning_ChangedDays);
            // 
            // panelNyBok
            // 
            this.panelNyBok.Controls.Add(this.labelNyBokTid);
            this.panelNyBok.Controls.Add(this.labelNyBokDag);
            this.panelNyBok.Controls.Add(this.richTextBoxBokMeddelande);
            this.panelNyBok.Controls.Add(this.label9);
            this.panelNyBok.Controls.Add(this.maskedTextBoxArsmodell);
            this.panelNyBok.Controls.Add(this.labelArsmodell);
            this.panelNyBok.Controls.Add(this.maskedTextBoxModell);
            this.panelNyBok.Controls.Add(this.labelModell);
            this.panelNyBok.Controls.Add(this.maskedTextBoxMarke);
            this.panelNyBok.Controls.Add(this.labelMarke);
            this.panelNyBok.Controls.Add(this.buttonBoka);
            this.panelNyBok.Controls.Add(this.maskedTextBoxReg);
            this.panelNyBok.Controls.Add(this.maskedTextBoxTfn);
            this.panelNyBok.Controls.Add(this.maskedTextBoxNamn);
            this.panelNyBok.Controls.Add(this.labelReg);
            this.panelNyBok.Controls.Add(this.labelTfn);
            this.panelNyBok.Controls.Add(this.labelNamn);
            this.panelNyBok.Enabled = false;
            this.panelNyBok.Location = new System.Drawing.Point(3, 211);
            this.panelNyBok.Name = "panelNyBok";
            this.panelNyBok.Size = new System.Drawing.Size(430, 243);
            this.panelNyBok.TabIndex = 0;
            this.panelNyBok.Visible = false;
            // 
            // labelNyBokTid
            // 
            this.labelNyBokTid.AutoSize = true;
            this.labelNyBokTid.Enabled = false;
            this.labelNyBokTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNyBokTid.Location = new System.Drawing.Point(265, 137);
            this.labelNyBokTid.Name = "labelNyBokTid";
            this.labelNyBokTid.Size = new System.Drawing.Size(78, 18);
            this.labelNyBokTid.TabIndex = 20;
            this.labelNyBokTid.Text = "Årsmodell:";
            this.labelNyBokTid.Visible = false;
            // 
            // labelNyBokDag
            // 
            this.labelNyBokDag.AutoSize = true;
            this.labelNyBokDag.Enabled = false;
            this.labelNyBokDag.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNyBokDag.Location = new System.Drawing.Point(265, 110);
            this.labelNyBokDag.Name = "labelNyBokDag";
            this.labelNyBokDag.Size = new System.Drawing.Size(35, 18);
            this.labelNyBokDag.TabIndex = 19;
            this.labelNyBokDag.Text = "Dag";
            this.labelNyBokDag.Visible = false;
            // 
            // richTextBoxBokMeddelande
            // 
            this.richTextBoxBokMeddelande.Location = new System.Drawing.Point(6, 127);
            this.richTextBoxBokMeddelande.Name = "richTextBoxBokMeddelande";
            this.richTextBoxBokMeddelande.Size = new System.Drawing.Size(244, 110);
            this.richTextBoxBokMeddelande.TabIndex = 18;
            this.richTextBoxBokMeddelande.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 18);
            this.label9.TabIndex = 17;
            this.label9.Text = "Problemspecifikation:";
            // 
            // maskedTextBoxArsmodell
            // 
            this.maskedTextBoxArsmodell.Location = new System.Drawing.Point(297, 66);
            this.maskedTextBoxArsmodell.Name = "maskedTextBoxArsmodell";
            this.maskedTextBoxArsmodell.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBoxArsmodell.TabIndex = 16;
            // 
            // labelArsmodell
            // 
            this.labelArsmodell.AutoSize = true;
            this.labelArsmodell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArsmodell.Location = new System.Drawing.Point(213, 66);
            this.labelArsmodell.Name = "labelArsmodell";
            this.labelArsmodell.Size = new System.Drawing.Size(78, 18);
            this.labelArsmodell.TabIndex = 15;
            this.labelArsmodell.Text = "Årsmodell:";
            // 
            // maskedTextBoxModell
            // 
            this.maskedTextBoxModell.Location = new System.Drawing.Point(297, 32);
            this.maskedTextBoxModell.Name = "maskedTextBoxModell";
            this.maskedTextBoxModell.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBoxModell.TabIndex = 14;
            // 
            // labelModell
            // 
            this.labelModell.AutoSize = true;
            this.labelModell.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModell.Location = new System.Drawing.Point(211, 32);
            this.labelModell.Name = "labelModell";
            this.labelModell.Size = new System.Drawing.Size(56, 18);
            this.labelModell.TabIndex = 13;
            this.labelModell.Text = "Modell:";
            // 
            // maskedTextBoxMarke
            // 
            this.maskedTextBoxMarke.Location = new System.Drawing.Point(297, 3);
            this.maskedTextBoxMarke.Name = "maskedTextBoxMarke";
            this.maskedTextBoxMarke.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBoxMarke.TabIndex = 12;
            // 
            // labelMarke
            // 
            this.labelMarke.AutoSize = true;
            this.labelMarke.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMarke.Location = new System.Drawing.Point(211, 0);
            this.labelMarke.Name = "labelMarke";
            this.labelMarke.Size = new System.Drawing.Size(54, 18);
            this.labelMarke.TabIndex = 11;
            this.labelMarke.Text = "Märke:";
            // 
            // buttonBoka
            // 
            this.buttonBoka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBoka.Location = new System.Drawing.Point(338, 208);
            this.buttonBoka.Name = "buttonBoka";
            this.buttonBoka.Size = new System.Drawing.Size(75, 29);
            this.buttonBoka.TabIndex = 10;
            this.buttonBoka.Text = "Boka";
            this.buttonBoka.UseVisualStyleBackColor = true;
            this.buttonBoka.Click += new System.EventHandler(this.buttonBoka_Click);
            // 
            // maskedTextBoxReg
            // 
            this.maskedTextBoxReg.Location = new System.Drawing.Point(107, 67);
            this.maskedTextBoxReg.Mask = "AAA 000";
            this.maskedTextBoxReg.Name = "maskedTextBoxReg";
            this.maskedTextBoxReg.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxReg.TabIndex = 7;
            // 
            // maskedTextBoxTfn
            // 
            this.maskedTextBoxTfn.Location = new System.Drawing.Point(89, 33);
            this.maskedTextBoxTfn.Name = "maskedTextBoxTfn";
            this.maskedTextBoxTfn.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxTfn.TabIndex = 6;
            // 
            // maskedTextBoxNamn
            // 
            this.maskedTextBoxNamn.Location = new System.Drawing.Point(89, 3);
            this.maskedTextBoxNamn.Name = "maskedTextBoxNamn";
            this.maskedTextBoxNamn.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBoxNamn.TabIndex = 5;
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelReg.Location = new System.Drawing.Point(3, 66);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(98, 18);
            this.labelReg.TabIndex = 2;
            this.labelReg.Text = "Reg nummer:";
            // 
            // labelTfn
            // 
            this.labelTfn.AutoSize = true;
            this.labelTfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTfn.Location = new System.Drawing.Point(3, 32);
            this.labelTfn.Name = "labelTfn";
            this.labelTfn.Size = new System.Drawing.Size(74, 18);
            this.labelTfn.TabIndex = 1;
            this.labelTfn.Text = "Telefonnr:";
            // 
            // labelNamn
            // 
            this.labelNamn.AutoSize = true;
            this.labelNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamn.Location = new System.Drawing.Point(3, 0);
            this.labelNamn.Name = "labelNamn";
            this.labelNamn.Size = new System.Drawing.Size(52, 18);
            this.labelNamn.TabIndex = 0;
            this.labelNamn.Text = "Namn:";
            // 
            // panelNyHyr
            // 
            this.panelNyHyr.Controls.Add(this.maskedTextBoxPersnr);
            this.panelNyHyr.Controls.Add(this.labelPersnr);
            this.panelNyHyr.Controls.Add(this.label3);
            this.panelNyHyr.Controls.Add(this.checkedListBox1);
            this.panelNyHyr.Controls.Add(this.monthCalendarHyrning);
            this.panelNyHyr.Controls.Add(this.maskedTextBox1);
            this.panelNyHyr.Controls.Add(this.maskedTextBox2);
            this.panelNyHyr.Controls.Add(this.label1);
            this.panelNyHyr.Controls.Add(this.label2);
            this.panelNyHyr.Location = new System.Drawing.Point(3, 460);
            this.panelNyHyr.Name = "panelNyHyr";
            this.panelNyHyr.Size = new System.Drawing.Size(427, 415);
            this.panelNyHyr.TabIndex = 1;
            this.panelNyHyr.Visible = false;
            // 
            // maskedTextBoxPersnr
            // 
            this.maskedTextBoxPersnr.Location = new System.Drawing.Point(89, 66);
            this.maskedTextBoxPersnr.Name = "maskedTextBoxPersnr";
            this.maskedTextBoxPersnr.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBoxPersnr.TabIndex = 37;
            // 
            // labelPersnr
            // 
            this.labelPersnr.AutoSize = true;
            this.labelPersnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersnr.Location = new System.Drawing.Point(3, 65);
            this.labelPersnr.Name = "labelPersnr";
            this.labelPersnr.Size = new System.Drawing.Size(73, 18);
            this.labelPersnr.TabIndex = 36;
            this.labelPersnr.Text = "Personnr:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 18);
            this.label3.TabIndex = 35;
            this.label3.Text = "Typ av fordon";
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
            this.checkedListBox1.Location = new System.Drawing.Point(8, 299);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(149, 109);
            this.checkedListBox1.TabIndex = 34;
            // 
            // monthCalendarHyrning
            // 
            this.monthCalendarHyrning.Location = new System.Drawing.Point(6, 99);
            this.monthCalendarHyrning.Name = "monthCalendarHyrning";
            this.monthCalendarHyrning.TabIndex = 11;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(89, 33);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(118, 20);
            this.maskedTextBox1.TabIndex = 10;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(89, 3);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(116, 20);
            this.maskedTextBox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Telefonnr:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Namn:";
            // 
            // panelNyHyrfordon
            // 
            this.panelNyHyrfordon.Controls.Add(this.checkedListBoxFordonsTyp);
            this.panelNyHyrfordon.Controls.Add(this.label17);
            this.panelNyHyrfordon.Controls.Add(this.buttonLäggTillFordon);
            this.panelNyHyrfordon.Controls.Add(this.TextBoxArsmodell);
            this.panelNyHyrfordon.Controls.Add(this.label11);
            this.panelNyHyrfordon.Controls.Add(this.TextBoxModell);
            this.panelNyHyrfordon.Controls.Add(this.label12);
            this.panelNyHyrfordon.Controls.Add(this.TextBoxMarke);
            this.panelNyHyrfordon.Controls.Add(this.label13);
            this.panelNyHyrfordon.Controls.Add(this.TextBoxReg);
            this.panelNyHyrfordon.Controls.Add(this.label15);
            this.panelNyHyrfordon.Location = new System.Drawing.Point(3, 881);
            this.panelNyHyrfordon.Name = "panelNyHyrfordon";
            this.panelNyHyrfordon.Size = new System.Drawing.Size(436, 210);
            this.panelNyHyrfordon.TabIndex = 3;
            this.panelNyHyrfordon.Visible = false;
            // 
            // checkedListBoxFordonsTyp
            // 
            this.checkedListBoxFordonsTyp.CheckOnClick = true;
            this.checkedListBoxFordonsTyp.FormattingEnabled = true;
            this.checkedListBoxFordonsTyp.Items.AddRange(new object[] {
            "Bil (2 pers)",
            "Bil (5 pers)",
            "Bil (7 pers)",
            "Bil (9 pers)",
            "Lastbil",
            "Motorcykel",
            "Skåpbil"});
            this.checkedListBoxFordonsTyp.Location = new System.Drawing.Point(248, 33);
            this.checkedListBoxFordonsTyp.Name = "checkedListBoxFordonsTyp";
            this.checkedListBoxFordonsTyp.Size = new System.Drawing.Size(149, 109);
            this.checkedListBoxFordonsTyp.TabIndex = 34;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(245, 12);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(98, 18);
            this.label17.TabIndex = 27;
            this.label17.Text = "Typ av fordon";
            // 
            // buttonLäggTillFordon
            // 
            this.buttonLäggTillFordon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLäggTillFordon.Location = new System.Drawing.Point(153, 160);
            this.buttonLäggTillFordon.Name = "buttonLäggTillFordon";
            this.buttonLäggTillFordon.Size = new System.Drawing.Size(75, 29);
            this.buttonLäggTillFordon.TabIndex = 25;
            this.buttonLäggTillFordon.Text = "Lägg till";
            this.buttonLäggTillFordon.UseVisualStyleBackColor = true;
            this.buttonLäggTillFordon.Click += new System.EventHandler(this.buttonLäggTillFordon_Click);
            // 
            // TextBoxArsmodell
            // 
            this.TextBoxArsmodell.Location = new System.Drawing.Point(109, 96);
            this.TextBoxArsmodell.Name = "TextBoxArsmodell";
            this.TextBoxArsmodell.Size = new System.Drawing.Size(116, 20);
            this.TextBoxArsmodell.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 18);
            this.label11.TabIndex = 23;
            this.label11.Text = "Årsmodell:";
            // 
            // TextBoxModell
            // 
            this.TextBoxModell.Location = new System.Drawing.Point(109, 70);
            this.TextBoxModell.Name = "TextBoxModell";
            this.TextBoxModell.Size = new System.Drawing.Size(116, 20);
            this.TextBoxModell.TabIndex = 22;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 18);
            this.label12.TabIndex = 21;
            this.label12.Text = "Modell:";
            // 
            // TextBoxMarke
            // 
            this.TextBoxMarke.Location = new System.Drawing.Point(109, 43);
            this.TextBoxMarke.Name = "TextBoxMarke";
            this.TextBoxMarke.Size = new System.Drawing.Size(116, 20);
            this.TextBoxMarke.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 45);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 18);
            this.label13.TabIndex = 19;
            this.label13.Text = "Märke:";
            // 
            // TextBoxReg
            // 
            this.TextBoxReg.Location = new System.Drawing.Point(125, 12);
            this.TextBoxReg.Mask = "AAA 000";
            this.TextBoxReg.Name = "TextBoxReg";
            this.TextBoxReg.Size = new System.Drawing.Size(100, 20);
            this.TextBoxReg.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 18);
            this.label15.TabIndex = 17;
            this.label15.Text = "Reg nummer:";
            // 
            // richTextBoxFormAdminMsgs
            // 
            this.richTextBoxFormAdminMsgs.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxFormAdminMsgs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxFormAdminMsgs.Location = new System.Drawing.Point(445, 881);
            this.richTextBoxFormAdminMsgs.Name = "richTextBoxFormAdminMsgs";
            this.richTextBoxFormAdminMsgs.Size = new System.Drawing.Size(100, 96);
            this.richTextBoxFormAdminMsgs.TabIndex = 4;
            this.richTextBoxFormAdminMsgs.Text = "";
            this.richTextBoxFormAdminMsgs.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(551, 881);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 5;
            // 
            // FormAdmin
            // 
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(998, 749);
            this.Controls.Add(this.flowPanelRoot);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(100000, 100000);
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "FormAdmin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowPanelRoot.ResumeLayout(false);
            this.flowPanelRoot.PerformLayout();
            this.panelVisaBok.ResumeLayout(false);
            this.panelVisaBok.PerformLayout();
            this.panelBokDag.ResumeLayout(false);
            this.panelBokDag.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfoProblem.ResumeLayout(false);
            this.panelInfoBil.ResumeLayout(false);
            this.panelNyBok.ResumeLayout(false);
            this.panelNyBok.PerformLayout();
            this.panelNyHyr.ResumeLayout(false);
            this.panelNyHyr.PerformLayout();
            this.panelNyHyrfordon.ResumeLayout(false);
            this.panelNyHyrfordon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem visaBokningar;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem nyHyrning;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem visaHyrningar;
        private System.Windows.Forms.ToolStripMenuItem omOss;
        private System.Windows.Forms.FlowLayoutPanel flowPanelRoot;
        private System.Windows.Forms.Panel panelNyBok;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Label labelTfn;
        private System.Windows.Forms.Label labelNamn;
        private System.Windows.Forms.Button buttonBoka;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxReg;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTfn;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNamn;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxArsmodell;
        private System.Windows.Forms.Label labelArsmodell;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxModell;
        private System.Windows.Forms.Label labelModell;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMarke;
        private System.Windows.Forms.Label labelMarke;
        private System.Windows.Forms.Panel panelNyHyr;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendarHyrning;
        private System.Windows.Forms.Panel panelVisaBok;
        private System.Windows.Forms.Label labelValj;
        private System.Windows.Forms.MonthCalendar monthCalendarBokning;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPersnr;
        private System.Windows.Forms.Label labelPersnr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Panel panelBokDag;
        private System.Windows.Forms.Label labelDag;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTid16;
        private System.Windows.Forms.Label labelTid14;
        private System.Windows.Forms.Label labelTid10;
        private System.Windows.Forms.Label labelTid08;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelInfoProblem;
        private System.Windows.Forms.Panel panelInfoBil;
        private System.Windows.Forms.RichTextBox richTextBoxBokMeddelande;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTextBoxInfoProblem;
        private System.Windows.Forms.RichTextBox richTextBoxInfoBil;
        private System.Windows.Forms.ToolStripMenuItem läggTillHyrfordon;
        private System.Windows.Forms.Panel panelNyHyrfordon;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button buttonLäggTillFordon;
        private System.Windows.Forms.MaskedTextBox TextBoxArsmodell;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox TextBoxModell;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox TextBoxMarke;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox TextBoxReg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckedListBox checkedListBoxFordonsTyp;
        private System.Windows.Forms.RichTextBox richTextBoxFormAdminMsgs;
        private System.Windows.Forms.Label labelNyBokTid;
        private System.Windows.Forms.Label labelNyBokDag;
        private System.Windows.Forms.Panel panel1;
    }
}