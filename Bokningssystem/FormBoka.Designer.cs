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
            this.button2 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelNyBil.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimeDatum
            // 
            this.dateTimeDatum.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dateTimeDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeDatum.Location = new System.Drawing.Point(290, 15);
            this.dateTimeDatum.Name = "dateTimeDatum";
            this.dateTimeDatum.Size = new System.Drawing.Size(172, 26);
            this.dateTimeDatum.TabIndex = 2;
            // 
            // buttonNyBoka
            // 
            this.buttonNyBoka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNyBoka.Location = new System.Drawing.Point(12, 12);
            this.buttonNyBoka.Name = "buttonNyBoka";
            this.buttonNyBoka.Size = new System.Drawing.Size(105, 29);
            this.buttonNyBoka.TabIndex = 28;
            this.buttonNyBoka.Text = "Ny bokning";
            this.buttonNyBoka.UseVisualStyleBackColor = true;
            this.buttonNyBoka.Click += new System.EventHandler(this.buttonNyBoka_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(123, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 29);
            this.button2.TabIndex = 29;
            this.button2.Text = "Mina bokningar";
            this.button2.UseVisualStyleBackColor = true;
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
            this.richTextBoxMeddelandenBoka.Location = new System.Drawing.Point(3, 19);
            this.richTextBoxMeddelandenBoka.Name = "richTextBoxMeddelandenBoka";
            this.richTextBoxMeddelandenBoka.ReadOnly = true;
            this.richTextBoxMeddelandenBoka.Size = new System.Drawing.Size(168, 132);
            this.richTextBoxMeddelandenBoka.TabIndex = 28;
            this.richTextBoxMeddelandenBoka.TabStop = false;
            this.richTextBoxMeddelandenBoka.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 58);
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
            // FormBoka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 436);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonNyBoka);
            this.Controls.Add(this.dateTimeDatum);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeDatum;
        private System.Windows.Forms.Button buttonNyBoka;
        private System.Windows.Forms.Button button2;
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
    }
}