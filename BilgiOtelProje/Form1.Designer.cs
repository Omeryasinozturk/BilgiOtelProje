namespace BilgiOtelProje
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
            this.cmbulke = new System.Windows.Forms.ComboBox();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cmbulke
            // 
            this.cmbulke.FormattingEnabled = true;
            this.cmbulke.Location = new System.Drawing.Point(298, 170);
            this.cmbulke.Name = "cmbulke";
            this.cmbulke.Size = new System.Drawing.Size(121, 21);
            this.cmbulke.TabIndex = 0;
            // 
            // cmbil
            // 
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(298, 210);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(121, 21);
            this.cmbil.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbil);
            this.Controls.Add(this.cmbulke);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbulke;
        private System.Windows.Forms.ComboBox cmbil;
    }
}