namespace Bokningssystem.forms
{
    partial class FormProfil
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
            this.panelRed = new System.Windows.Forms.Panel();
            this.maskedTextBoxNytt = new System.Windows.Forms.MaskedTextBox();
            this.labelGamla = new System.Windows.Forms.Label();
            this.maskedTextBoxGamla = new System.Windows.Forms.MaskedTextBox();
            this.labelNytt = new System.Windows.Forms.Label();
            this.labelBekräfta = new System.Windows.Forms.Label();
            this.labelEditLosen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxNamn = new System.Windows.Forms.TextBox();
            this.textBoxBekräfta = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxTfn = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonBytLösen = new System.Windows.Forms.Button();
            this.labelAvbryt = new System.Windows.Forms.Label();
            this.panelRed.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRed
            // 
            this.panelRed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRed.AutoSize = true;
            this.panelRed.Controls.Add(this.maskedTextBoxNytt);
            this.panelRed.Controls.Add(this.labelGamla);
            this.panelRed.Controls.Add(this.maskedTextBoxGamla);
            this.panelRed.Controls.Add(this.labelNytt);
            this.panelRed.Location = new System.Drawing.Point(9, 246);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(145, 124);
            this.panelRed.TabIndex = 31;
            this.panelRed.Visible = false;
            // 
            // maskedTextBoxNytt
            // 
            this.maskedTextBoxNytt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxNytt.Location = new System.Drawing.Point(19, 88);
            this.maskedTextBoxNytt.Name = "maskedTextBoxNytt";
            this.maskedTextBoxNytt.Size = new System.Drawing.Size(115, 24);
            this.maskedTextBoxNytt.TabIndex = 9;
            this.maskedTextBoxNytt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxNyttKeyDown);
            // 
            // labelGamla
            // 
            this.labelGamla.AutoSize = true;
            this.labelGamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGamla.Location = new System.Drawing.Point(16, 11);
            this.labelGamla.Name = "labelGamla";
            this.labelGamla.Size = new System.Drawing.Size(48, 16);
            this.labelGamla.TabIndex = 18;
            this.labelGamla.Text = "Gamla";
            // 
            // maskedTextBoxGamla
            // 
            this.maskedTextBoxGamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxGamla.Location = new System.Drawing.Point(19, 30);
            this.maskedTextBoxGamla.Name = "maskedTextBoxGamla";
            this.maskedTextBoxGamla.Size = new System.Drawing.Size(115, 24);
            this.maskedTextBoxGamla.TabIndex = 8;
            // 
            // labelNytt
            // 
            this.labelNytt.AutoSize = true;
            this.labelNytt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNytt.Location = new System.Drawing.Point(16, 69);
            this.labelNytt.Name = "labelNytt";
            this.labelNytt.Size = new System.Drawing.Size(31, 16);
            this.labelNytt.TabIndex = 14;
            this.labelNytt.Text = "Nytt";
            // 
            // labelBekräfta
            // 
            this.labelBekräfta.AutoSize = true;
            this.labelBekräfta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBekräfta.Location = new System.Drawing.Point(173, 246);
            this.labelBekräfta.Name = "labelBekräfta";
            this.labelBekräfta.Size = new System.Drawing.Size(164, 16);
            this.labelBekräfta.TabIndex = 15;
            this.labelBekräfta.Text = "Bekräfta med ditt lösenord";
            this.labelBekräfta.Visible = false;
            // 
            // labelEditLosen
            // 
            this.labelEditLosen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEditLosen.AutoSize = true;
            this.labelEditLosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditLosen.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelEditLosen.Location = new System.Drawing.Point(336, 219);
            this.labelEditLosen.Name = "labelEditLosen";
            this.labelEditLosen.Size = new System.Drawing.Size(74, 15);
            this.labelEditLosen.TabIndex = 7;
            this.labelEditLosen.Text = "Byt lösenord";
            this.labelEditLosen.Click += new System.EventHandler(this.initChangeLosen);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 33;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // textBoxNamn
            // 
            this.textBoxNamn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNamn.Location = new System.Drawing.Point(146, 3);
            this.textBoxNamn.Name = "textBoxNamn";
            this.textBoxNamn.Size = new System.Drawing.Size(252, 24);
            this.textBoxNamn.TabIndex = 1;
            this.textBoxNamn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxKeyEvent);
            // 
            // textBoxBekräfta
            // 
            this.textBoxBekräfta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBekräfta.Location = new System.Drawing.Point(195, 265);
            this.textBoxBekräfta.Name = "textBoxBekräfta";
            this.textBoxBekräfta.Size = new System.Drawing.Size(115, 24);
            this.textBoxBekräfta.TabIndex = 5;
            this.textBoxBekräfta.UseSystemPasswordChar = true;
            this.textBoxBekräfta.Visible = false;
            this.textBoxBekräfta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxKeyEvent);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.91022F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.08978F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.textBoxAdress, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxTfn, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBoxEmail, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label12, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNamn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 0);
            this.tableLayoutPanel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.74101F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.26471F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.59524F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(401, 185);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAdress.Location = new System.Drawing.Point(146, 138);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(252, 24);
            this.textBoxAdress.TabIndex = 4;
            this.textBoxAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxKeyEvent);
            // 
            // textBoxTfn
            // 
            this.textBoxTfn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxTfn.Location = new System.Drawing.Point(146, 92);
            this.textBoxTfn.Name = "textBoxTfn";
            this.textBoxTfn.Size = new System.Drawing.Size(252, 24);
            this.textBoxTfn.TabIndex = 3;
            this.textBoxTfn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxKeyEvent);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEmail.Location = new System.Drawing.Point(146, 47);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(252, 24);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxKeyEvent);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 18);
            this.label12.TabIndex = 1;
            this.label12.Text = "Epost-adress:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 2;
            this.label13.Text = "Telefon nummer:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 18);
            this.label14.TabIndex = 3;
            this.label14.Text = "Adress:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 18);
            this.label15.TabIndex = 0;
            this.label15.Text = "Namn:";
            // 
            // buttonBytLösen
            // 
            this.buttonBytLösen.Location = new System.Drawing.Point(318, 315);
            this.buttonBytLösen.Name = "buttonBytLösen";
            this.buttonBytLösen.Size = new System.Drawing.Size(75, 52);
            this.buttonBytLösen.TabIndex = 10;
            this.buttonBytLösen.Text = "Byt Lösenord";
            this.buttonBytLösen.UseVisualStyleBackColor = true;
            this.buttonBytLösen.Visible = false;
            this.buttonBytLösen.Click += new System.EventHandler(this.buttonBytLösen_Click);
            // 
            // labelAvbryt
            // 
            this.labelAvbryt.AutoSize = true;
            this.labelAvbryt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAvbryt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelAvbryt.Location = new System.Drawing.Point(336, 270);
            this.labelAvbryt.Name = "labelAvbryt";
            this.labelAvbryt.Size = new System.Drawing.Size(38, 15);
            this.labelAvbryt.TabIndex = 37;
            this.labelAvbryt.Text = "Avbryt";
            this.labelAvbryt.Click += new System.EventHandler(this.labelAvbryt_Click);
            // 
            // FormProfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 382);
            this.Controls.Add(this.labelAvbryt);
            this.Controls.Add(this.buttonBytLösen);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.textBoxBekräfta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelBekräfta);
            this.Controls.Add(this.labelEditLosen);
            this.Controls.Add(this.panelRed);
            this.Name = "FormProfil";
            this.Text = "FormProfil";
            this.panelRed.ResumeLayout(false);
            this.panelRed.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNytt;
        private System.Windows.Forms.Label labelGamla;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxGamla;
        private System.Windows.Forms.Label labelNytt;
        private System.Windows.Forms.Label labelBekräfta;
        private System.Windows.Forms.Label labelEditLosen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxNamn;
        private System.Windows.Forms.TextBox textBoxBekräfta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxTfn;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonBytLösen;
        private System.Windows.Forms.Label labelAvbryt;

    }
}