namespace BilgiOtelWindowsForm
{
    partial class OdaDuzenleme
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
            this.lwodadurum = new System.Windows.Forms.ListView();
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grboxodatadilat = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btntadilatsilme = new System.Windows.Forms.Button();
            this.btntadilatguncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbodadurum = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtodatadilat = new System.Windows.Forms.TextBox();
            this.btntadilatkaydet = new System.Windows.Forms.Button();
            this.dt2bitis = new System.Windows.Forms.DateTimePicker();
            this.dt1baslangıc = new System.Windows.Forms.DateTimePicker();
            this.grboxodabilgileri = new System.Windows.Forms.GroupBox();
            this.btnodabilgiguncelle = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOdaaciklama = new System.Windows.Forms.TextBox();
            this.txtodakisisayisi = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtodafiyat = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtodakat = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboxBalkon = new System.Windows.Forms.CheckBox();
            this.cboxTv = new System.Windows.Forms.CheckBox();
            this.cboxKasa = new System.Windows.Forms.CheckBox();
            this.cboxWifi = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboxKurutma = new System.Windows.Forms.CheckBox();
            this.cboxKlima = new System.Windows.Forms.CheckBox();
            this.cboxMini = new System.Windows.Forms.CheckBox();
            this.txtodanumarası = new System.Windows.Forms.TextBox();
            this.lwodalar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboxAktif = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdurumid = new System.Windows.Forms.TextBox();
            this.grboxodatadilat.SuspendLayout();
            this.grboxodabilgileri.SuspendLayout();
            this.SuspendLayout();
            // 
            // lwodadurum
            // 
            this.lwodadurum.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader18,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lwodadurum.GridLines = true;
            this.lwodadurum.HideSelection = false;
            this.lwodadurum.Location = new System.Drawing.Point(34, 373);
            this.lwodadurum.Name = "lwodadurum";
            this.lwodadurum.Size = new System.Drawing.Size(685, 359);
            this.lwodadurum.TabIndex = 27;
            this.lwodadurum.UseCompatibleStateImageBehavior = false;
            this.lwodadurum.View = System.Windows.Forms.View.Details;
            this.lwodadurum.Click += new System.EventHandler(this.lwodadurum_Click);
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Oda Durum ID";
            this.columnHeader18.Width = 96;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Oda Numarası";
            this.columnHeader13.Width = 113;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Tadilat Başlangıç";
            this.columnHeader14.Width = 128;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Tadilat Bitiş";
            this.columnHeader15.Width = 123;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Oda Kategori";
            this.columnHeader16.Width = 109;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "AktifMi";
            this.columnHeader17.Width = 135;
            // 
            // grboxodatadilat
            // 
            this.grboxodatadilat.Controls.Add(this.label7);
            this.grboxodatadilat.Controls.Add(this.txtdurumid);
            this.grboxodatadilat.Controls.Add(this.cboxAktif);
            this.grboxodatadilat.Controls.Add(this.label5);
            this.grboxodatadilat.Controls.Add(this.label3);
            this.grboxodatadilat.Controls.Add(this.label4);
            this.grboxodatadilat.Controls.Add(this.btntadilatsilme);
            this.grboxodatadilat.Controls.Add(this.btntadilatguncelle);
            this.grboxodatadilat.Controls.Add(this.label2);
            this.grboxodatadilat.Controls.Add(this.cmbodadurum);
            this.grboxodatadilat.Controls.Add(this.label1);
            this.grboxodatadilat.Controls.Add(this.txtodatadilat);
            this.grboxodatadilat.Controls.Add(this.btntadilatkaydet);
            this.grboxodatadilat.Controls.Add(this.dt2bitis);
            this.grboxodatadilat.Controls.Add(this.dt1baslangıc);
            this.grboxodatadilat.Location = new System.Drawing.Point(774, 373);
            this.grboxodatadilat.Name = "grboxodatadilat";
            this.grboxodatadilat.Size = new System.Drawing.Size(490, 359);
            this.grboxodatadilat.TabIndex = 26;
            this.grboxodatadilat.TabStop = false;
            this.grboxodatadilat.Text = "ODA TADİLAT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "BİTİŞ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "BAŞLANGIÇ :";
            // 
            // btntadilatsilme
            // 
            this.btntadilatsilme.Location = new System.Drawing.Point(98, 286);
            this.btntadilatsilme.Name = "btntadilatsilme";
            this.btntadilatsilme.Size = new System.Drawing.Size(93, 34);
            this.btntadilatsilme.TabIndex = 29;
            this.btntadilatsilme.Text = "SİL";
            this.btntadilatsilme.UseVisualStyleBackColor = true;
            this.btntadilatsilme.Click += new System.EventHandler(this.btntadilatsilme_Click);
            // 
            // btntadilatguncelle
            // 
            this.btntadilatguncelle.Location = new System.Drawing.Point(334, 286);
            this.btntadilatguncelle.Name = "btntadilatguncelle";
            this.btntadilatguncelle.Size = new System.Drawing.Size(90, 34);
            this.btntadilatguncelle.TabIndex = 27;
            this.btntadilatguncelle.Text = "GÜNCELLE";
            this.btntadilatguncelle.UseVisualStyleBackColor = true;
            this.btntadilatguncelle.Click += new System.EventHandler(this.btntadilatguncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "ODA DURUM :";
            // 
            // cmbodadurum
            // 
            this.cmbodadurum.FormattingEnabled = true;
            this.cmbodadurum.Location = new System.Drawing.Point(234, 106);
            this.cmbodadurum.Name = "cmbodadurum";
            this.cmbodadurum.Size = new System.Drawing.Size(121, 21);
            this.cmbodadurum.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "ODA NUMARASI :";
            // 
            // txtodatadilat
            // 
            this.txtodatadilat.Location = new System.Drawing.Point(234, 69);
            this.txtodatadilat.Margin = new System.Windows.Forms.Padding(2);
            this.txtodatadilat.Name = "txtodatadilat";
            this.txtodatadilat.Size = new System.Drawing.Size(121, 20);
            this.txtodatadilat.TabIndex = 23;
            // 
            // btntadilatkaydet
            // 
            this.btntadilatkaydet.Location = new System.Drawing.Point(216, 286);
            this.btntadilatkaydet.Name = "btntadilatkaydet";
            this.btntadilatkaydet.Size = new System.Drawing.Size(93, 34);
            this.btntadilatkaydet.TabIndex = 22;
            this.btntadilatkaydet.Text = "KAYDET";
            this.btntadilatkaydet.UseVisualStyleBackColor = true;
            this.btntadilatkaydet.Click += new System.EventHandler(this.btntadilatkaydet_Click);
            // 
            // dt2bitis
            // 
            this.dt2bitis.Location = new System.Drawing.Point(234, 209);
            this.dt2bitis.Name = "dt2bitis";
            this.dt2bitis.Size = new System.Drawing.Size(206, 20);
            this.dt2bitis.TabIndex = 21;
            // 
            // dt1baslangıc
            // 
            this.dt1baslangıc.Location = new System.Drawing.Point(234, 164);
            this.dt1baslangıc.Name = "dt1baslangıc";
            this.dt1baslangıc.Size = new System.Drawing.Size(206, 20);
            this.dt1baslangıc.TabIndex = 20;
            this.dt1baslangıc.ValueChanged += new System.EventHandler(this.dt1baslangıc_ValueChanged);
            // 
            // grboxodabilgileri
            // 
            this.grboxodabilgileri.Controls.Add(this.btnodabilgiguncelle);
            this.grboxodabilgileri.Controls.Add(this.label16);
            this.grboxodabilgileri.Controls.Add(this.txtOdaaciklama);
            this.grboxodabilgileri.Controls.Add(this.txtodakisisayisi);
            this.grboxodabilgileri.Controls.Add(this.label15);
            this.grboxodabilgileri.Controls.Add(this.txtodafiyat);
            this.grboxodabilgileri.Controls.Add(this.label14);
            this.grboxodabilgileri.Controls.Add(this.txtodakat);
            this.grboxodabilgileri.Controls.Add(this.label13);
            this.grboxodabilgileri.Controls.Add(this.cboxBalkon);
            this.grboxodabilgileri.Controls.Add(this.cboxTv);
            this.grboxodabilgileri.Controls.Add(this.cboxKasa);
            this.grboxodabilgileri.Controls.Add(this.cboxWifi);
            this.grboxodabilgileri.Controls.Add(this.label6);
            this.grboxodabilgileri.Controls.Add(this.cboxKurutma);
            this.grboxodabilgileri.Controls.Add(this.cboxKlima);
            this.grboxodabilgileri.Controls.Add(this.cboxMini);
            this.grboxodabilgileri.Controls.Add(this.txtodanumarası);
            this.grboxodabilgileri.Location = new System.Drawing.Point(774, 17);
            this.grboxodabilgileri.Name = "grboxodabilgileri";
            this.grboxodabilgileri.Size = new System.Drawing.Size(490, 318);
            this.grboxodabilgileri.TabIndex = 25;
            this.grboxodabilgileri.TabStop = false;
            this.grboxodabilgileri.Text = "ODA BİLGİLERİ";
            // 
            // btnodabilgiguncelle
            // 
            this.btnodabilgiguncelle.Location = new System.Drawing.Point(334, 270);
            this.btnodabilgiguncelle.Name = "btnodabilgiguncelle";
            this.btnodabilgiguncelle.Size = new System.Drawing.Size(91, 33);
            this.btnodabilgiguncelle.TabIndex = 23;
            this.btnodabilgiguncelle.Text = "GÜNCELLE";
            this.btnodabilgiguncelle.UseVisualStyleBackColor = true;
            this.btnodabilgiguncelle.Click += new System.EventHandler(this.btnodabilgiguncelle_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "ODA AÇIKLAMA :";
            // 
            // txtOdaaciklama
            // 
            this.txtOdaaciklama.Location = new System.Drawing.Point(128, 220);
            this.txtOdaaciklama.Name = "txtOdaaciklama";
            this.txtOdaaciklama.Size = new System.Drawing.Size(124, 20);
            this.txtOdaaciklama.TabIndex = 21;
            // 
            // txtodakisisayisi
            // 
            this.txtodakisisayisi.Location = new System.Drawing.Point(129, 182);
            this.txtodakisisayisi.Name = "txtodakisisayisi";
            this.txtodakisisayisi.Size = new System.Drawing.Size(100, 20);
            this.txtodakisisayisi.TabIndex = 20;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 186);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "ODA KİŞİ SAYISI :";
            // 
            // txtodafiyat
            // 
            this.txtodafiyat.Location = new System.Drawing.Point(129, 143);
            this.txtodafiyat.Name = "txtodafiyat";
            this.txtodafiyat.Size = new System.Drawing.Size(100, 20);
            this.txtodafiyat.TabIndex = 18;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 149);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 17;
            this.label14.Text = "ODA FİYAT :";
            // 
            // txtodakat
            // 
            this.txtodakat.Location = new System.Drawing.Point(129, 107);
            this.txtodakat.Name = "txtodakat";
            this.txtodakat.Size = new System.Drawing.Size(100, 20);
            this.txtodakat.TabIndex = 16;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "ODA KAT :";
            // 
            // cboxBalkon
            // 
            this.cboxBalkon.AutoSize = true;
            this.cboxBalkon.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboxBalkon.Location = new System.Drawing.Point(409, 169);
            this.cboxBalkon.Name = "cboxBalkon";
            this.cboxBalkon.Size = new System.Drawing.Size(59, 17);
            this.cboxBalkon.TabIndex = 6;
            this.cboxBalkon.Text = "Balkon";
            this.cboxBalkon.UseVisualStyleBackColor = true;
            // 
            // cboxTv
            // 
            this.cboxTv.AutoSize = true;
            this.cboxTv.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboxTv.Location = new System.Drawing.Point(409, 132);
            this.cboxTv.Name = "cboxTv";
            this.cboxTv.Size = new System.Drawing.Size(40, 17);
            this.cboxTv.TabIndex = 5;
            this.cboxTv.Text = "TV";
            this.cboxTv.UseVisualStyleBackColor = true;
            // 
            // cboxKasa
            // 
            this.cboxKasa.AutoSize = true;
            this.cboxKasa.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboxKasa.Location = new System.Drawing.Point(374, 202);
            this.cboxKasa.Name = "cboxKasa";
            this.cboxKasa.Size = new System.Drawing.Size(50, 17);
            this.cboxKasa.TabIndex = 4;
            this.cboxKasa.Text = "Kasa";
            this.cboxKasa.UseVisualStyleBackColor = true;
            // 
            // cboxWifi
            // 
            this.cboxWifi.AutoSize = true;
            this.cboxWifi.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboxWifi.Location = new System.Drawing.Point(322, 169);
            this.cboxWifi.Name = "cboxWifi";
            this.cboxWifi.Size = new System.Drawing.Size(49, 17);
            this.cboxWifi.TabIndex = 3;
            this.cboxWifi.Text = "WİFİ";
            this.cboxWifi.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "ODA NUMARASI :";
            // 
            // cboxKurutma
            // 
            this.cboxKurutma.AutoSize = true;
            this.cboxKurutma.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboxKurutma.Location = new System.Drawing.Point(409, 95);
            this.cboxKurutma.Name = "cboxKurutma";
            this.cboxKurutma.Size = new System.Drawing.Size(65, 17);
            this.cboxKurutma.TabIndex = 2;
            this.cboxKurutma.Text = "Kurutma";
            this.cboxKurutma.UseVisualStyleBackColor = true;
            // 
            // cboxKlima
            // 
            this.cboxKlima.AutoSize = true;
            this.cboxKlima.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboxKlima.Location = new System.Drawing.Point(322, 95);
            this.cboxKlima.Name = "cboxKlima";
            this.cboxKlima.Size = new System.Drawing.Size(51, 17);
            this.cboxKlima.TabIndex = 1;
            this.cboxKlima.Text = "Klima";
            this.cboxKlima.UseVisualStyleBackColor = true;
            // 
            // cboxMini
            // 
            this.cboxMini.AutoSize = true;
            this.cboxMini.ForeColor = System.Drawing.Color.SteelBlue;
            this.cboxMini.Location = new System.Drawing.Point(322, 132);
            this.cboxMini.Name = "cboxMini";
            this.cboxMini.Size = new System.Drawing.Size(64, 17);
            this.cboxMini.TabIndex = 0;
            this.cboxMini.Text = "Mini Bar";
            this.cboxMini.UseVisualStyleBackColor = true;
            // 
            // txtodanumarası
            // 
            this.txtodanumarası.Location = new System.Drawing.Point(128, 72);
            this.txtodanumarası.Margin = new System.Windows.Forms.Padding(2);
            this.txtodanumarası.Name = "txtodanumarası";
            this.txtodanumarası.Size = new System.Drawing.Size(100, 20);
            this.txtodanumarası.TabIndex = 10;
            // 
            // lwodalar
            // 
            this.lwodalar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lwodalar.GridLines = true;
            this.lwodalar.HideSelection = false;
            this.lwodalar.Location = new System.Drawing.Point(34, 17);
            this.lwodalar.Name = "lwodalar";
            this.lwodalar.Size = new System.Drawing.Size(685, 318);
            this.lwodalar.TabIndex = 24;
            this.lwodalar.UseCompatibleStateImageBehavior = false;
            this.lwodalar.View = System.Windows.Forms.View.Details;
            this.lwodalar.Click += new System.EventHandler(this.lwodalar_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ODA NO";
            this.columnHeader1.Width = 64;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ODA FİYAT";
            this.columnHeader2.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "MİNİ BAR";
            this.columnHeader3.Width = 64;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KLİMA";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KURUTMA";
            this.columnHeader5.Width = 69;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "WİFİ";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "KASA";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "BALKON";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "TV";
            this.columnHeader9.Width = 44;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "YATAK BİLGİ";
            this.columnHeader10.Width = 90;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "KAT";
            this.columnHeader11.Width = 40;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "KİŞİ SAYISI";
            // 
            // cboxAktif
            // 
            this.cboxAktif.AutoSize = true;
            this.cboxAktif.Location = new System.Drawing.Point(234, 248);
            this.cboxAktif.Name = "cboxAktif";
            this.cboxAktif.Size = new System.Drawing.Size(15, 14);
            this.cboxAktif.TabIndex = 32;
            this.cboxAktif.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "AKTİF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 37);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "ODA DURUM ID :";
            // 
            // txtdurumid
            // 
            this.txtdurumid.Location = new System.Drawing.Point(234, 34);
            this.txtdurumid.Margin = new System.Windows.Forms.Padding(2);
            this.txtdurumid.Name = "txtdurumid";
            this.txtdurumid.Size = new System.Drawing.Size(121, 20);
            this.txtdurumid.TabIndex = 33;
            // 
            // OdaDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 762);
            this.Controls.Add(this.lwodadurum);
            this.Controls.Add(this.grboxodatadilat);
            this.Controls.Add(this.grboxodabilgileri);
            this.Controls.Add(this.lwodalar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OdaDuzenleme";
            this.Text = "OdaDuzenleme";
            this.Load += new System.EventHandler(this.OdaDuzenleme_Load);
            this.grboxodatadilat.ResumeLayout(false);
            this.grboxodatadilat.PerformLayout();
            this.grboxodabilgileri.ResumeLayout(false);
            this.grboxodabilgileri.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwodadurum;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.GroupBox grboxodatadilat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btntadilatsilme;
        private System.Windows.Forms.Button btntadilatguncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbodadurum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtodatadilat;
        private System.Windows.Forms.Button btntadilatkaydet;
        private System.Windows.Forms.DateTimePicker dt2bitis;
        private System.Windows.Forms.DateTimePicker dt1baslangıc;
        private System.Windows.Forms.GroupBox grboxodabilgileri;
        private System.Windows.Forms.Button btnodabilgiguncelle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOdaaciklama;
        private System.Windows.Forms.TextBox txtodakisisayisi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtodafiyat;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtodakat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cboxBalkon;
        private System.Windows.Forms.CheckBox cboxTv;
        private System.Windows.Forms.CheckBox cboxKasa;
        private System.Windows.Forms.CheckBox cboxWifi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cboxKurutma;
        private System.Windows.Forms.CheckBox cboxKlima;
        private System.Windows.Forms.CheckBox cboxMini;
        private System.Windows.Forms.TextBox txtodanumarası;
        private System.Windows.Forms.ListView lwodalar;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.CheckBox cboxAktif;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdurumid;
    }
}