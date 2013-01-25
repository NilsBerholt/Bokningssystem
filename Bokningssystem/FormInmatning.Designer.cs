namespace Bokningssystem
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
            // buttonVisa
            // 
            this.buttonVisa.Enabled = false;
<<<<<<< HEAD
            this.buttonVisa.Location = new System.Drawing.Point(299, 18);
=======
            this.buttonVisa.Location = new System.Drawing.Point(100, 112);
>>>>>>> f339e0551dade416b74345993c43da0e0a1de4f5
            this.buttonVisa.Name = "buttonVisa";
            this.buttonVisa.Size = new System.Drawing.Size(100, 100);
            this.buttonVisa.TabIndex = 42;
            this.buttonVisa.Text = "Visa Kontakter";
            this.buttonVisa.UseVisualStyleBackColor = true;
            this.buttonVisa.Visible = false;
            this.buttonVisa.Click += new System.EventHandler(this.buttonVisa_Click);
            //
            // buttonDebug
            //
            this.buttonDebug.Visible = true;
            this.buttonDebug.Location = new System.Drawing.Point(299, 50);
            this.buttonDebug.Name = "buttonDebug";
            this.buttonDebug.Size = new System.Drawing.Size(50, 50);
            this.buttonDebug.TabIndex = 43;
            this.buttonDebug.Text = "Sluta debugga";
            this.buttonDebug.UseVisualStyleBackColor = true;
            this.buttonDebug.Enabled = true;
            this.buttonDebug.Click += new System.EventHandler(this.buttonDebug_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Namn:";
            // 
            // buttonLogga
            // 
            this.buttonLogga.Location = new System.Drawing.Point(7, 112);
            this.buttonLogga.Name = "buttonLogga";
            this.buttonLogga.Size = new System.Drawing.Size(75, 23);
            this.buttonLogga.TabIndex = 6;
            this.buttonLogga.Text = "Logga in";
            this.buttonLogga.UseVisualStyleBackColor = true;
            this.buttonLogga.Click += new System.EventHandler(this.buttonLogga_Click);
            // 
            // textBoxPersnr
            // 
            this.textBoxPersnr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxPersnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersnr.Location = new System.Drawing.Point(12, 237);
            this.textBoxPersnr.Name = "textBoxPersnr";
            this.textBoxPersnr.Size = new System.Drawing.Size(172, 26);
            this.textBoxPersnr.TabIndex = 7;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAdress.Location = new System.Drawing.Point(12, 185);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(172, 26);
            this.textBoxAdress.TabIndex = 6;
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefon.Location = new System.Drawing.Point(12, 133);
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(172, 26);
            this.textBoxTelefon.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(12, 81);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(172, 26);
            this.textBoxEmail.TabIndex = 4;
            // 
            // labelPersnr
            // 
            this.labelPersnr.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelPersnr.AutoSize = true;
            this.labelPersnr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersnr.Location = new System.Drawing.Point(12, 214);
            this.labelPersnr.Name = "labelPersnr";
            this.labelPersnr.Size = new System.Drawing.Size(121, 20);
            this.labelPersnr.TabIndex = 20;
            this.labelPersnr.Text = "Personnummer:";
            // 
            // labelAdress
            // 
            this.labelAdress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdress.Location = new System.Drawing.Point(12, 162);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(63, 20);
            this.labelAdress.TabIndex = 19;
            this.labelAdress.Text = "Adress:";
            // 
            // labelTfn
            // 
            this.labelTfn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelTfn.AutoSize = true;
            this.labelTfn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTfn.Location = new System.Drawing.Point(12, 110);
            this.labelTfn.Name = "labelTfn";
            this.labelTfn.Size = new System.Drawing.Size(66, 20);
            this.labelTfn.TabIndex = 18;
            this.labelTfn.Text = "Telefon:";
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(12, 58);
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
            this.labelLosen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelLosen.AutoSize = true;
            this.labelLosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLosen.Location = new System.Drawing.Point(12, 266);
            this.labelLosen.Name = "labelLosen";
            this.labelLosen.Size = new System.Drawing.Size(80, 20);
            this.labelLosen.TabIndex = 22;
            this.labelLosen.Text = "Lösenord:";
            // 
            // label
            // 
            this.label.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(12, 318);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 20);
            this.label.TabIndex = 22;
            this.label.Text = "Bekräfta lösenord:";
            // 
            // textBoxLosenBek
            // 
            this.textBoxLosenBek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLosenBek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLosenBek.Location = new System.Drawing.Point(12, 341);
            this.textBoxLosenBek.Name = "textBoxLosenBek";
            this.textBoxLosenBek.Size = new System.Drawing.Size(172, 26);
            this.textBoxLosenBek.TabIndex = 9;
            this.textBoxLosenBek.UseSystemPasswordChar = true;
            // 
            // textBoxLosen
            // 
            this.textBoxLosen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxLosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLosen.Location = new System.Drawing.Point(12, 289);
            this.textBoxLosen.Name = "textBoxLosen";
            this.textBoxLosen.Size = new System.Drawing.Size(172, 26);
            this.textBoxLosen.TabIndex = 8;
            this.textBoxLosen.UseSystemPasswordChar = true;
            // 
            // buttonRegistrera
            // 
            this.buttonRegistrera.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonRegistrera.Location = new System.Drawing.Point(205, 31);
            this.buttonRegistrera.Name = "buttonRegistrera";
            this.buttonRegistrera.Size = new System.Drawing.Size(75, 23);
            this.buttonRegistrera.TabIndex = 23;
            this.buttonRegistrera.Text = "Registrera";
            this.buttonRegistrera.UseVisualStyleBackColor = true;
            this.buttonRegistrera.Click += new System.EventHandler(this.buttonRegistrera_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(3, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 23;
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
            this.splitContainer1.Size = new System.Drawing.Size(619, 376);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 25;
            // 
            // richTextBoxMeddelanden1
            // 
            this.richTextBoxMeddelanden1.AcceptsTab = true;
            this.richTextBoxMeddelanden1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxMeddelanden1.Location = new System.Drawing.Point(7, 268);
            this.richTextBoxMeddelanden1.Name = "richTextBoxMeddelanden1";
            this.richTextBoxMeddelanden1.ReadOnly = true;
            this.richTextBoxMeddelanden1.Size = new System.Drawing.Size(168, 99);
            this.richTextBoxMeddelanden1.TabIndex = 25;
            this.richTextBoxMeddelanden1.TabStop = false;
            this.richTextBoxMeddelanden1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
<<<<<<< HEAD
=======
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
>>>>>>> f339e0551dade416b74345993c43da0e0a1de4f5
            this.label2.Location = new System.Drawing.Point(201, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Jag ångrade mig, jag har redan ett konto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // richTextBoxMeddelanden
            // 
            this.richTextBoxMeddelanden.AcceptsTab = true;
            this.richTextBoxMeddelanden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.richTextBoxMeddelanden.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBoxMeddelanden.Location = new System.Drawing.Point(204, 268);
            this.richTextBoxMeddelanden.Name = "richTextBoxMeddelanden";
            this.richTextBoxMeddelanden.ReadOnly = true;
            this.richTextBoxMeddelanden.Size = new System.Drawing.Size(168, 99);
            this.richTextBoxMeddelanden.TabIndex = 26;
            this.richTextBoxMeddelanden.TabStop = false;
            this.richTextBoxMeddelanden.Text = "";
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxNamn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNamn.Location = new System.Drawing.Point(12, 29);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(172, 26);
            this.textBoxNamn.TabIndex = 3;
            // 
            // FormInmatning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(619, 376);
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
    }
}

