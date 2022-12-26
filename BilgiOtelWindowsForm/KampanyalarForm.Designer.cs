namespace BilgiOtelWindowsForm
{
    partial class KampanyalarForm
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
            this.btnErkenRezSil = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbodasatistip = new System.Windows.Forms.ComboBox();
            this.btnerkenrezkaydetme = new System.Windows.Forms.Button();
            this.btnerkenrezguncelle = new System.Windows.Forms.Button();
            this.cboxindirimaktif = new System.Windows.Forms.CheckBox();
            this.txterkenrezaciklama = new System.Windows.Forms.TextBox();
            this.txterkenrezindirimoran = new System.Windows.Forms.TextBox();
            this.txterkenrezgunsayi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnkampanyasil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.txtkampanyatanım = new System.Windows.Forms.TextBox();
            this.dtpkambitis = new System.Windows.Forms.DateTimePicker();
            this.dtpkambaslangıc = new System.Windows.Forms.DateTimePicker();
            this.txtkampanyaindirim = new System.Windows.Forms.TextBox();
            this.txtkampanyabilgi = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnErkenRezSil
            // 
            this.btnErkenRezSil.Location = new System.Drawing.Point(1225, 343);
            this.btnErkenRezSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnErkenRezSil.Name = "btnErkenRezSil";
            this.btnErkenRezSil.Size = new System.Drawing.Size(84, 59);
            this.btnErkenRezSil.TabIndex = 55;
            this.btnErkenRezSil.Text = "Sil";
            this.btnErkenRezSil.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(106, 421);
            this.listView2.Margin = new System.Windows.Forms.Padding(2);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1134, 299);
            this.listView2.TabIndex = 54;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "ERKEN REZERVASYON ID";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ERKEN REZERVASYON GÜN SAYISI";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "ERKEN REZERVASYON İNDİRİM ORANI";
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "ERKEN REZERVASYON AÇIKLAMA";
            this.columnHeader10.Width = 249;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "ODA SATIŞ TİPİ";
            this.columnHeader11.Width = 142;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "ERKEN REZERVASYON AKTİF Mİ";
            this.columnHeader12.Width = 200;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "ODA SATIŞ TİP ID";
            this.columnHeader13.Width = 141;
            // 
            // cmbodasatistip
            // 
            this.cmbodasatistip.FormattingEnabled = true;
            this.cmbodasatistip.Location = new System.Drawing.Point(840, 360);
            this.cmbodasatistip.Margin = new System.Windows.Forms.Padding(2);
            this.cmbodasatistip.Name = "cmbodasatistip";
            this.cmbodasatistip.Size = new System.Drawing.Size(104, 21);
            this.cmbodasatistip.TabIndex = 53;
            // 
            // btnerkenrezkaydetme
            // 
            this.btnerkenrezkaydetme.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnerkenrezkaydetme.Location = new System.Drawing.Point(1083, 343);
            this.btnerkenrezkaydetme.Margin = new System.Windows.Forms.Padding(2);
            this.btnerkenrezkaydetme.Name = "btnerkenrezkaydetme";
            this.btnerkenrezkaydetme.Size = new System.Drawing.Size(123, 59);
            this.btnerkenrezkaydetme.TabIndex = 52;
            this.btnerkenrezkaydetme.Text = "KAYDET";
            this.btnerkenrezkaydetme.UseVisualStyleBackColor = false;
            // 
            // btnerkenrezguncelle
            // 
            this.btnerkenrezguncelle.Location = new System.Drawing.Point(979, 343);
            this.btnerkenrezguncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnerkenrezguncelle.Name = "btnerkenrezguncelle";
            this.btnerkenrezguncelle.Size = new System.Drawing.Size(72, 59);
            this.btnerkenrezguncelle.TabIndex = 51;
            this.btnerkenrezguncelle.Text = "GÜNCELLE";
            this.btnerkenrezguncelle.UseVisualStyleBackColor = true;
            // 
            // cboxindirimaktif
            // 
            this.cboxindirimaktif.AutoSize = true;
            this.cboxindirimaktif.Location = new System.Drawing.Point(737, 364);
            this.cboxindirimaktif.Margin = new System.Windows.Forms.Padding(2);
            this.cboxindirimaktif.Name = "cboxindirimaktif";
            this.cboxindirimaktif.Size = new System.Drawing.Size(15, 14);
            this.cboxindirimaktif.TabIndex = 50;
            this.cboxindirimaktif.UseVisualStyleBackColor = true;
            // 
            // txterkenrezaciklama
            // 
            this.txterkenrezaciklama.Location = new System.Drawing.Point(535, 364);
            this.txterkenrezaciklama.Margin = new System.Windows.Forms.Padding(2);
            this.txterkenrezaciklama.Multiline = true;
            this.txterkenrezaciklama.Name = "txterkenrezaciklama";
            this.txterkenrezaciklama.Size = new System.Drawing.Size(129, 40);
            this.txterkenrezaciklama.TabIndex = 49;
            // 
            // txterkenrezindirimoran
            // 
            this.txterkenrezindirimoran.Location = new System.Drawing.Point(351, 364);
            this.txterkenrezindirimoran.Margin = new System.Windows.Forms.Padding(2);
            this.txterkenrezindirimoran.Name = "txterkenrezindirimoran";
            this.txterkenrezindirimoran.Size = new System.Drawing.Size(105, 20);
            this.txterkenrezindirimoran.TabIndex = 48;
            // 
            // txterkenrezgunsayi
            // 
            this.txterkenrezgunsayi.Location = new System.Drawing.Point(141, 364);
            this.txterkenrezgunsayi.Margin = new System.Windows.Forms.Padding(2);
            this.txterkenrezgunsayi.Name = "txterkenrezgunsayi";
            this.txterkenrezgunsayi.Size = new System.Drawing.Size(105, 20);
            this.txterkenrezgunsayi.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(822, 330);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "REZERVASYON TİP DURUMU";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(707, 330);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "İNDİRİM AKTİF Mİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(517, 330);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "ERKEN REZERVASYON AÇIKLAMA";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 330);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(210, 13);
            this.label7.TabIndex = 43;
            this.label7.Text = "ERKEN REZERVASYON İNDİRİM ORANI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "ERKEN REZERVASYON GÜN SAYISI";
            // 
            // btnkampanyasil
            // 
            this.btnkampanyasil.Location = new System.Drawing.Point(1225, 32);
            this.btnkampanyasil.Margin = new System.Windows.Forms.Padding(2);
            this.btnkampanyasil.Name = "btnkampanyasil";
            this.btnkampanyasil.Size = new System.Drawing.Size(84, 59);
            this.btnkampanyasil.TabIndex = 41;
            this.btnkampanyasil.Text = "Sil";
            this.btnkampanyasil.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(979, 32);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(72, 59);
            this.btnGuncelle.TabIndex = 40;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // txtkampanyatanım
            // 
            this.txtkampanyatanım.Location = new System.Drawing.Point(840, 55);
            this.txtkampanyatanım.Margin = new System.Windows.Forms.Padding(2);
            this.txtkampanyatanım.Name = "txtkampanyatanım";
            this.txtkampanyatanım.Size = new System.Drawing.Size(105, 20);
            this.txtkampanyatanım.TabIndex = 39;
            // 
            // dtpkambitis
            // 
            this.dtpkambitis.Location = new System.Drawing.Point(636, 55);
            this.dtpkambitis.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkambitis.Name = "dtpkambitis";
            this.dtpkambitis.Size = new System.Drawing.Size(144, 20);
            this.dtpkambitis.TabIndex = 38;
            // 
            // dtpkambaslangıc
            // 
            this.dtpkambaslangıc.Location = new System.Drawing.Point(444, 55);
            this.dtpkambaslangıc.Margin = new System.Windows.Forms.Padding(2);
            this.dtpkambaslangıc.Name = "dtpkambaslangıc";
            this.dtpkambaslangıc.Size = new System.Drawing.Size(139, 20);
            this.dtpkambaslangıc.TabIndex = 37;
            // 
            // txtkampanyaindirim
            // 
            this.txtkampanyaindirim.Location = new System.Drawing.Point(286, 52);
            this.txtkampanyaindirim.Margin = new System.Windows.Forms.Padding(2);
            this.txtkampanyaindirim.Name = "txtkampanyaindirim";
            this.txtkampanyaindirim.Size = new System.Drawing.Size(105, 20);
            this.txtkampanyaindirim.TabIndex = 36;
            // 
            // txtkampanyabilgi
            // 
            this.txtkampanyabilgi.Location = new System.Drawing.Point(141, 52);
            this.txtkampanyabilgi.Margin = new System.Windows.Forms.Padding(2);
            this.txtkampanyabilgi.Name = "txtkampanyabilgi";
            this.txtkampanyabilgi.Size = new System.Drawing.Size(105, 20);
            this.txtkampanyabilgi.TabIndex = 35;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(94, 107);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1134, 202);
            this.listView1.TabIndex = 34;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "KAMPANYA ID";
            this.columnHeader6.Width = 147;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "KAMPANYA BİLGİLERİ";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "İNDİRİM ORANI";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "BAŞLANGIÇ TARİHİ";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "BİTİŞ TARİHİ";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KAMPANYA TANIM";
            this.columnHeader5.Width = 200;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(842, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "KAMPANYA TANIM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(656, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "KAMPANYA BİTİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(454, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "KAMPANYA BAŞLANGIÇ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "KAMPANYA İNDİRİM ORANI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "KAMPANYA BİLGİLERİ";
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnkaydet.Location = new System.Drawing.Point(1083, 32);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(123, 59);
            this.btnkaydet.TabIndex = 28;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = false;
            // 
            // KampanyalarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 731);
            this.Controls.Add(this.btnErkenRezSil);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.cmbodasatistip);
            this.Controls.Add(this.btnerkenrezkaydetme);
            this.Controls.Add(this.btnerkenrezguncelle);
            this.Controls.Add(this.cboxindirimaktif);
            this.Controls.Add(this.txterkenrezaciklama);
            this.Controls.Add(this.txterkenrezindirimoran);
            this.Controls.Add(this.txterkenrezgunsayi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnkampanyasil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.txtkampanyatanım);
            this.Controls.Add(this.dtpkambitis);
            this.Controls.Add(this.dtpkambaslangıc);
            this.Controls.Add(this.txtkampanyaindirim);
            this.Controls.Add(this.txtkampanyabilgi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnkaydet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KampanyalarForm";
            this.Text = "KampanyalarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnErkenRezSil;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ComboBox cmbodasatistip;
        private System.Windows.Forms.Button btnerkenrezkaydetme;
        private System.Windows.Forms.Button btnerkenrezguncelle;
        private System.Windows.Forms.CheckBox cboxindirimaktif;
        private System.Windows.Forms.TextBox txterkenrezaciklama;
        private System.Windows.Forms.TextBox txterkenrezindirimoran;
        private System.Windows.Forms.TextBox txterkenrezgunsayi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnkampanyasil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox txtkampanyatanım;
        private System.Windows.Forms.DateTimePicker dtpkambitis;
        private System.Windows.Forms.DateTimePicker dtpkambaslangıc;
        private System.Windows.Forms.TextBox txtkampanyaindirim;
        private System.Windows.Forms.TextBox txtkampanyabilgi;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnkaydet;
    }
}