namespace BilgiOtelWindowsForm
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnkapatma = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtkullaniciadi = new System.Windows.Forms.TextBox();
            this.txtparola = new System.Windows.Forms.TextBox();
            this.btngiris = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 530);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btngiris);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnkapatma);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(300, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 530);
            this.panel2.TabIndex = 1;
            // 
            // btnkapatma
            // 
            this.btnkapatma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkapatma.FlatAppearance.BorderSize = 0;
            this.btnkapatma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnkapatma.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnkapatma.Location = new System.Drawing.Point(410, 0);
            this.btnkapatma.Name = "btnkapatma";
            this.btnkapatma.Size = new System.Drawing.Size(40, 40);
            this.btnkapatma.TabIndex = 0;
            this.btnkapatma.Text = "X";
            this.btnkapatma.UseVisualStyleBackColor = true;
            this.btnkapatma.Click += new System.EventHandler(this.btnkapatma_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.txtkullaniciadi);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 200);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(450, 45);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.txtparola);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Location = new System.Drawing.Point(0, 260);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(450, 45);
            this.panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BilgiOtelWindowsForm.Properties.Resources.iconfinder_securityprotectlockshield04_4021479_113137;
            this.pictureBox2.Location = new System.Drawing.Point(15, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BilgiOtelWindowsForm.Properties.Resources.avatardefault_92824;
            this.pictureBox1.Location = new System.Drawing.Point(15, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtkullaniciadi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullaniciadi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtkullaniciadi.Location = new System.Drawing.Point(55, 11);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(370, 25);
            this.txtkullaniciadi.TabIndex = 0;
            this.txtkullaniciadi.Text = "KullanıcıAdı";
            this.txtkullaniciadi.Click += new System.EventHandler(this.txtkullaniciadi_Click);
            this.txtkullaniciadi.Enter += new System.EventHandler(this.txtkullaniciadi_Enter);
            this.txtkullaniciadi.Leave += new System.EventHandler(this.txtkullaniciadi_Leave);
            // 
            // txtparola
            // 
            this.txtparola.BackColor = System.Drawing.SystemColors.Control;
            this.txtparola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtparola.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtparola.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.txtparola.Location = new System.Drawing.Point(55, 10);
            this.txtparola.Name = "txtparola";
            this.txtparola.Size = new System.Drawing.Size(370, 25);
            this.txtparola.TabIndex = 1;
            this.txtparola.Text = "Parola";
            this.txtparola.Click += new System.EventHandler(this.txtparola_Click);
            this.txtparola.Enter += new System.EventHandler(this.txtparola_Enter);
            this.txtparola.Leave += new System.EventHandler(this.txtparola_Leave);
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(116)))), ((int)(((byte)(199)))));
            this.btngiris.FlatAppearance.BorderSize = 0;
            this.btngiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngiris.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btngiris.ForeColor = System.Drawing.Color.White;
            this.btngiris.Location = new System.Drawing.Point(55, 321);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(148, 35);
            this.btngiris.TabIndex = 3;
            this.btngiris.Text = "GİRİŞ";
            this.btngiris.UseVisualStyleBackColor = false;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(70)))), ((int)(((byte)(82)))));
            this.button2.Location = new System.Drawing.Point(244, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "PAROLAMI UNUTTUM";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::BilgiOtelWindowsForm.Properties.Resources.avatardefault_92824;
            this.pictureBox3.Location = new System.Drawing.Point(61, 185);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(184, 154);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnkapatma;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtparola;
        private System.Windows.Forms.TextBox txtkullaniciadi;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}