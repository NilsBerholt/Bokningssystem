namespace Bokningssystem
{
    partial class Form1
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
            this.groupBoxAdm = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxAdm
            // 
            this.groupBoxAdm.Location = new System.Drawing.Point(12, 11);
            this.groupBoxAdm.Name = "groupBoxAdm";
            this.groupBoxAdm.Size = new System.Drawing.Size(260, 237);
            this.groupBoxAdm.TabIndex = 0;
            this.groupBoxAdm.TabStop = false;
            this.groupBoxAdm.Text = "groupBoxAdm";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.groupBoxAdm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdm;
    }
}