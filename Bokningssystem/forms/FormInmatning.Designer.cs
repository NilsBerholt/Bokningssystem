﻿namespace Bokningssystem
{
    partial class FormInmatning
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
            this.buttonDebug = new System.Windows.Forms.Button();
            this.buttonVisa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLogga = new System.Windows.Forms.Button();
            this.textBoxPersnr = new System.Windows.Forms.TextBox();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelPersnr = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelTfn = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxLosenLogin = new System.Windows.Forms.TextBox();
            this.textBoxEmailLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelLosen = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.textBoxLosenBek = new System.Windows.Forms.TextBox();
            this.textBoxLosen = new System.Windows.Forms.TextBox();
            this.buttonRegistrera = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.radioButtonLaga = new System.Windows.Forms.RadioButton();
            this.radioButtonHyra = new System.Windows.Forms.RadioButton();
            this.richTextBoxMeddelanden1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxMeddelanden = new System.Windows.Forms.RichTextBox();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDebug
            // 
            this.buttonDebug.Location = new System.Drawing.Point(249, 9);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(75, 23);
            this.buttonDebug.TabIndex = 16;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // buttonVisa
            // 
            this.buttonVisa.Enabled = false;
            this.buttonVisa.Location = new System.Drawing.Point(330, 6);
            this.buttonVisa.Name = "buttonVisa";
            this.buttonVisa.Size = new System.Drawing.Size(100, 100);
            this.buttonVisa.TabIndex = 17;
            this.buttonVisa.Text = "Visa Kontakter";
            this.buttonVisa.UseVisualStyleBackColor = true;
            this.buttonVisa.Visible = false;
            this.buttonVisa.Click += new System.EventHandler(this.buttonVisa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn:";
            // 
            // buttonLogga
            // 
            this.buttonLogga.Location = new System.Drawing.Point(25, 133);
            this.buttonLogga.Name = "buttonLogga";
            this.buttonLogga.Size = new System.Drawing.Size(75, 23);
            this.buttonLogga.TabIndex = 5;
            this.buttonLogga.Text = "Logga in";
            this.buttonLogga.UseVisualStyleBackColor = true;
            this.buttonLogga.Click += new System.EventHandler(this.buttonLogga_Click);
            // 
            // textBoxPersnr
            // 
            this.textBoxPersnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersnr.Location = new System.Drawing.Point(20, 240);
            this.textBoxPersnr.Name = "textBoxPersnr";
            this.textBoxPersnr.Size = new System.Drawing.Size(172, 26);
            this.textBoxPersnr.TabIndex = 11;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdress.Location = new System.Drawing.Point(20, 188);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(172, 26);
            this.textBoxAdress.TabIndex = 10;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefon.Location = new System.Drawing.Point(20, 136);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(172, 26);
            this.textBoxTelefon.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(20, 84);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(172, 26);
            this.textBoxEmail.TabIndex = 8;
            // 
            // labelPersnr
            // 
            this.labelPersnr.AutoSize = true;
            this.labelPersnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersnr.Location = new System.Drawing.Point(20, 217);
            this.labelPersnr.Name = "labelPersnr";
            this.labelPersnr.Size = new System.Drawing.Size(121, 20);
            this.labelPersnr.TabIndex = 20;
            this.labelPersnr.Text = "Personnummer:";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.Location = new System.Drawing.Point(20, 165);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(63, 20);
            this.labelAdress.TabIndex = 19;
            this.labelAdress.Text = "Adress:";
            // 
            // labelTfn
            // 
            this.labelTfn.AutoSize = true;
            this.labelTfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTfn.Location = new System.Drawing.Point(20, 113);
            this.labelTfn.Name = "labelTfn";
            this.labelTfn.Size = new System.Drawing.Size(66, 20);
            this.labelTfn.TabIndex = 18;
            this.labelTfn.Text = "Telefon:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(20, 61);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(105, 20);
            this.labelEmail.TabIndex = 17;
            this.labelEmail.Text = "Email-adress:";
            // 
            // textBoxLosenLogin
            // 
            this.textBoxLosenLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxLosenLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLosenLogin.Location = new System.Drawing.Point(6, 80);
            this.textBoxLosenLogin.Name = "textBoxLosenLogin";
            this.textBoxLosenLogin.Size = new System.Drawing.Size(172, 26);
            this.textBoxLosenLogin.TabIndex = 2;
            this.textBoxLosenLogin.UseSystemPasswordChar = true;
            // 
            // textBoxEmailLogin
            // 
            this.textBoxEmailLogin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxEmailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmailLogin.Location = new System.Drawing.Point(6, 28);
            this.textBoxEmailLogin.Name = "textBoxEmailLogin";
            this.textBoxEmailLogin.Size = new System.Drawing.Size(172, 26);
            this.textBoxEmailLogin.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Lösenord:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Email-adress:";
            // 
            // labelLosen
            // 
            this.labelLosen.AutoSize = true;
            this.labelLosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLosen.Location = new System.Drawing.Point(20, 269);
            this.labelLosen.Name = "labelLosen";
            this.labelLosen.Size = new System.Drawing.Size(80, 20);
            this.labelLosen.TabIndex = 22;
            this.labelLosen.Text = "Lösenord:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(20, 321);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 20);
            this.label.TabIndex = 22;
            this.label.Text = "Bekräfta lösenord:";
            // 
            // textBoxLosenBek
            // 
            this.textBoxLosenBek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLosenBek.Location = new System.Drawing.Point(20, 344);
            this.textBoxLosenBek.Name = "textBoxLosenBek";
            this.textBoxLosenBek.Size = new System.Drawing.Size(172, 26);
            this.textBoxLosenBek.TabIndex = 13;
            this.textBoxLosenBek.UseSystemPasswordChar = true;
            // 
            // textBoxLosen
            // 
            this.textBoxLosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLosen.Location = new System.Drawing.Point(20, 292);
            this.textBoxLosen.Name = "textBoxLosen";
            this.textBoxLosen.Size = new System.Drawing.Size(172, 26);
            this.textBoxLosen.TabIndex = 12;
            this.textBoxLosen.UseSystemPasswordChar = true;
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegistrera.Location = new System.Drawing.Point(382, 344);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrera.TabIndex = 14;
            this.buttonRegistrera.Text = "Registrera";
            this.buttonRegistrera.UseVisualStyleBackColor = true;
            this.buttonRegistrera.Click += new System.EventHandler(this.buttonRegistrera_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(143, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Skapa användare";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonLaga);
            this.splitContainer1.Panel1.Controls.Add(this.radioButtonHyra);
            this.splitContainer1.Panel1.Controls.Add(this.richTextBoxMeddelanden1);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLosenLogin);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.buttonLogga);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxEmailLogin);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonDebug);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBoxMeddelanden);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxNamn);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.buttonRegistrera);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLosenBek);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxAdress);
            this.splitContainer1.Panel2.Controls.Add(this.label);
            this.splitContainer1.Panel2.Controls.Add(this.labelAdress);
            this.splitContainer1.Panel2.Controls.Add(this.labelEmail);
            this.splitContainer1.Panel2.Controls.Add(this.labelPersnr);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxLosen);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxTelefon);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxEmail);
            this.splitContainer1.Panel2.Controls.Add(this.textBoxPersnr);
            this.splitContainer1.Panel2.Controls.Add(this.labelLosen);
            this.splitContainer1.Panel2.Controls.Add(this.labelTfn);
            this.splitContainer1.Panel2.Controls.Add(this.buttonVisa);
            this.splitContainer1.Panel2MinSize = 0;
            this.splitContainer1.Size = new System.Drawing.Size(655, 379);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 25;
            // 
            // radioButtonLaga
            // 
            this.radioButtonLaga.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonLaga.AutoSize = true;
            this.radioButtonLaga.Location = new System.Drawing.Point(176, 110);
            this.radioButtonLaga.Name = "radioButtonLaga";
            this.radioButtonLaga.Size = new System.Drawing.Size(49, 17);
            this.radioButtonLaga.TabIndex = 4;
            this.radioButtonLaga.TabStop = true;
            this.radioButtonLaga.Text = "Laga";
            this.radioButtonLaga.UseVisualStyleBackColor = true;
            this.radioButtonLaga.CheckedChanged += new System.EventHandler(this.radioButtonLaga_CheckedChanged);
            // 
            // radioButtonHyra
            // 
            this.radioButtonHyra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonHyra.AutoSize = true;
            this.radioButtonHyra.Location = new System.Drawing.Point(53, 110);
            this.radioButtonHyra.Name = "radioButtonHyra";
            this.radioButtonHyra.Size = new System.Drawing.Size(47, 17);
            this.radioButtonHyra.TabIndex = 3;
            this.radioButtonHyra.TabStop = true;
            this.radioButtonHyra.Text = "Hyra";
            this.radioButtonHyra.UseVisualStyleBackColor = true;
            this.radioButtonHyra.CheckedChanged += new System.EventHandler(this.radioButtonHyra_CheckedChanged);
            // 
            // richTextBoxMeddelanden1
            // 
            this.richTextBoxMeddelanden1.AcceptsTab = true;
            this.richTextBoxMeddelanden1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBoxMeddelanden1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMeddelanden1.Location = new System.Drawing.Point(10, 162);
            this.richTextBoxMeddelanden1.Name = "richTextBoxMeddelanden1";
            this.richTextBoxMeddelanden1.ReadOnly = true;
            this.richTextBoxMeddelanden1.Size = new System.Drawing.Size(172, 99);
            this.richTextBoxMeddelanden1.TabIndex = 25;
            this.richTextBoxMeddelanden1.TabStop = false;
            this.richTextBoxMeddelanden1.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(259, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Jag ångrade mig, jag har redan ett konto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBoxMeddelanden
            // 
            this.richTextBoxMeddelanden.AcceptsTab = true;
            this.richTextBoxMeddelanden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxMeddelanden.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMeddelanden.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxMeddelanden.Location = new System.Drawing.Point(289, 170);
            this.richTextBoxMeddelanden.Name = "richTextBoxMeddelanden";
            this.richTextBoxMeddelanden.ReadOnly = true;
            this.richTextBoxMeddelanden.Size = new System.Drawing.Size(168, 99);
            this.richTextBoxMeddelanden.TabIndex = 26;
            this.richTextBoxMeddelanden.TabStop = false;
            this.richTextBoxMeddelanden.Text = "";
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamn.Location = new System.Drawing.Point(20, 32);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(172, 26);
            this.textBoxNamn.TabIndex = 7;
            // 
            // FormInmatning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(655, 379);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormInmatning";
            this.Text = "Inloggning";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLogga;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelPersnr;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelTfn;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxPersnr;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.TextBox textBoxLosenBek;
        private System.Windows.Forms.TextBox textBoxLosen;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelLosen;
        private System.Windows.Forms.TextBox textBoxLosenLogin;
        private System.Windows.Forms.TextBox textBoxEmailLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRegistrera;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.RichTextBox richTextBoxMeddelanden1;
        private System.Windows.Forms.RichTextBox richTextBoxMeddelanden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVisa;
        private System.Windows.Forms.Button buttonDebug;
        private System.Windows.Forms.RadioButton radioButtonLaga;
        private System.Windows.Forms.RadioButton radioButtonHyra;
    }
}

