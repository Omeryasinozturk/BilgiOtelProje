namespace BilgiOtelWindowsForm
{
    partial class MusteriEkleForm
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
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lwmusteriler = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtVergiNo = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnGuncelleme = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboxkurumsal = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtYetkiliAd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMusteriUnvan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPasaportNo = new System.Windows.Forms.TextBox();
            this.cmbdil = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTckimlik = new System.Windows.Forms.TextBox();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.Cmbil = new System.Windows.Forms.ComboBox();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.cmbUlke = new System.Windows.Forms.ComboBox();
            this.dtpdogumtarihi = new System.Windows.Forms.DateTimePicker();
            this.btntummusteri = new System.Windows.Forms.Button();
            this.btnmusterigetir = new System.Windows.Forms.Button();
            this.txtsorgu = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(8, 578);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(139, 54);
            this.btnTemizle.TabIndex = 13;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lwmusteriler
            // 
            this.lwmusteriler.HideSelection = false;
            this.lwmusteriler.Location = new System.Drawing.Point(19, 683);
            this.lwmusteriler.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lwmusteriler.Name = "lwmusteriler";
            this.lwmusteriler.Size = new System.Drawing.Size(1740, 249);
            this.lwmusteriler.TabIndex = 12;
            this.lwmusteriler.UseCompatibleStateImageBehavior = false;
            this.lwmusteriler.View = System.Windows.Forms.View.Details;
            this.lwmusteriler.Click += new System.EventHandler(this.lwmusteriler_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtVergiNo);
            this.groupBox1.Controls.Add(this.btnTemizle);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.btnGuncelleme);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CmbCinsiyet);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.cboxkurumsal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtAciklama);
            this.groupBox1.Controls.Add(this.btnkaydet);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtVergiDairesi);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtYetkiliAd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtMusteriUnvan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPasaportNo);
            this.groupBox1.Controls.Add(this.cmbdil);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTckimlik);
            this.groupBox1.Controls.Add(this.cmbilce);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.Cmbil);
            this.groupBox1.Controls.Add(this.txtEposta);
            this.groupBox1.Controls.Add(this.cmbUlke);
            this.groupBox1.Controls.Add(this.dtpdogumtarihi);
            this.groupBox1.Location = new System.Drawing.Point(864, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(896, 641);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "YENİ MÜŞTERİ EKLEME";
            // 
            // txtVergiNo
            // 
            this.txtVergiNo.Location = new System.Drawing.Point(251, 167);
            this.txtVergiNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVergiNo.Name = "txtVergiNo";
            this.txtVergiNo.Size = new System.Drawing.Size(200, 22);
            this.txtVergiNo.TabIndex = 41;
            this.txtVergiNo.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(59, 171);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 16);
            this.label22.TabIndex = 37;
            this.label22.Text = "VERGİ NO :";
            this.label22.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(59, 73);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "FİRMA AD : ";
            this.label20.Visible = false;
            // 
            // btnGuncelleme
            // 
            this.btnGuncelleme.Location = new System.Drawing.Point(573, 561);
            this.btnGuncelleme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuncelleme.Name = "btnGuncelleme";
            this.btnGuncelleme.Size = new System.Drawing.Size(205, 44);
            this.btnGuncelleme.TabIndex = 56;
            this.btnGuncelleme.Text = "GÜNCELLE";
            this.btnGuncelleme.UseVisualStyleBackColor = true;
            this.btnGuncelleme.Click += new System.EventHandler(this.btnGuncelleme_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(59, 122);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(60, 16);
            this.label21.TabIndex = 36;
            this.label21.Text = "SOYAD :";
            this.label21.Visible = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(504, 443);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 55;
            this.label19.Text = "CİNSİYET :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(504, 482);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 16);
            this.label16.TabIndex = 54;
            this.label16.Text = "DOĞUM TARİHİ";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Location = new System.Drawing.Point(685, 433);
            this.CmbCinsiyet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(172, 24);
            this.CmbCinsiyet.TabIndex = 54;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(251, 69);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(200, 22);
            this.txtAd.TabIndex = 38;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(304, 20);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(168, 16);
            this.label18.TabIndex = 53;
            this.label18.Text = "MÜŞTERİ KURUMSAL MI :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(504, 398);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 16);
            this.label15.TabIndex = 53;
            this.label15.Text = "DİL";
            // 
            // cboxkurumsal
            // 
            this.cboxkurumsal.AutoSize = true;
            this.cboxkurumsal.Location = new System.Drawing.Point(513, 20);
            this.cboxkurumsal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboxkurumsal.Name = "cboxkurumsal";
            this.cboxkurumsal.Size = new System.Drawing.Size(18, 17);
            this.cboxkurumsal.TabIndex = 52;
            this.cboxkurumsal.UseVisualStyleBackColor = true;
            this.cboxkurumsal.CheckedChanged += new System.EventHandler(this.cboxkurumsal_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "AD :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(504, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 16);
            this.label17.TabIndex = 51;
            this.label17.Text = "MÜŞTERİ AÇIKLAMA:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(504, 346);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 52;
            this.label14.Text = "İLÇE";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(685, 144);
            this.txtAciklama.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(199, 63);
            this.txtAciklama.TabIndex = 50;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(203, 551);
            this.btnkaydet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(324, 64);
            this.btnkaydet.TabIndex = 49;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "SOYAD :";
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(251, 463);
            this.txtVergiDairesi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(200, 22);
            this.txtVergiDairesi.TabIndex = 48;
            this.txtVergiDairesi.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(504, 289);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 16);
            this.label13.TabIndex = 51;
            this.label13.Text = "İL :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "TC KİMLİK :";
            // 
            // txtYetkiliAd
            // 
            this.txtYetkiliAd.Location = new System.Drawing.Point(251, 414);
            this.txtYetkiliAd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYetkiliAd.Name = "txtYetkiliAd";
            this.txtYetkiliAd.Size = new System.Drawing.Size(200, 22);
            this.txtYetkiliAd.TabIndex = 46;
            this.txtYetkiliAd.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(504, 235);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 16);
            this.label12.TabIndex = 50;
            this.label12.Text = "ÜLKE :";
            // 
            // txtMusteriUnvan
            // 
            this.txtMusteriUnvan.Location = new System.Drawing.Point(251, 364);
            this.txtMusteriUnvan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMusteriUnvan.Name = "txtMusteriUnvan";
            this.txtMusteriUnvan.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriUnvan.TabIndex = 45;
            this.txtMusteriUnvan.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "TELEFON :";
            // 
            // txtPasaportNo
            // 
            this.txtPasaportNo.Location = new System.Drawing.Point(251, 315);
            this.txtPasaportNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPasaportNo.Name = "txtPasaportNo";
            this.txtPasaportNo.Size = new System.Drawing.Size(200, 22);
            this.txtPasaportNo.TabIndex = 44;
            // 
            // cmbdil
            // 
            this.cmbdil.FormattingEnabled = true;
            this.cmbdil.Location = new System.Drawing.Point(685, 388);
            this.cmbdil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbdil.Name = "cmbdil";
            this.cmbdil.Size = new System.Drawing.Size(172, 24);
            this.cmbdil.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 466);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(174, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "MÜŞTERİ VERGİ DAİRESİ :";
            this.label10.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "E POSTA :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(504, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "MÜŞTERİ ADRES :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 417);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 16);
            this.label8.TabIndex = 41;
            this.label8.Text = "MÜŞTERİ YETKİLİ AD :";
            this.label8.Visible = false;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(251, 118);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtSoyad.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "MÜŞTERİ ÜNVAN :";
            this.label7.Visible = false;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(685, 59);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(199, 63);
            this.txtAdres.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "MÜŞTERİ PASAPORT NO :";
            // 
            // txtTckimlik
            // 
            this.txtTckimlik.Location = new System.Drawing.Point(251, 167);
            this.txtTckimlik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTckimlik.Name = "txtTckimlik";
            this.txtTckimlik.Size = new System.Drawing.Size(200, 22);
            this.txtTckimlik.TabIndex = 40;
            // 
            // cmbilce
            // 
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(685, 336);
            this.cmbilce.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(172, 24);
            this.cmbilce.TabIndex = 46;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(251, 217);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(200, 22);
            this.txtTelefon.TabIndex = 41;
            // 
            // Cmbil
            // 
            this.Cmbil.FormattingEnabled = true;
            this.Cmbil.Location = new System.Drawing.Point(685, 279);
            this.Cmbil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmbil.Name = "Cmbil";
            this.Cmbil.Size = new System.Drawing.Size(172, 24);
            this.Cmbil.TabIndex = 45;
            this.Cmbil.SelectionChangeCommitted += new System.EventHandler(this.Cmbil_SelectionChangeCommitted);
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(251, 266);
            this.txtEposta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(200, 22);
            this.txtEposta.TabIndex = 42;
            // 
            // cmbUlke
            // 
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Location = new System.Drawing.Point(685, 225);
            this.cmbUlke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(172, 24);
            this.cmbUlke.TabIndex = 44;
            this.cmbUlke.SelectionChangeCommitted += new System.EventHandler(this.cmbUlke_SelectionChangeCommitted);
            // 
            // dtpdogumtarihi
            // 
            this.dtpdogumtarihi.Location = new System.Drawing.Point(685, 475);
            this.dtpdogumtarihi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdogumtarihi.Name = "dtpdogumtarihi";
            this.dtpdogumtarihi.Size = new System.Drawing.Size(200, 22);
            this.dtpdogumtarihi.TabIndex = 43;
            // 
            // btntummusteri
            // 
            this.btntummusteri.Location = new System.Drawing.Point(19, 617);
            this.btntummusteri.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btntummusteri.Name = "btntummusteri";
            this.btntummusteri.Size = new System.Drawing.Size(201, 44);
            this.btntummusteri.TabIndex = 9;
            this.btntummusteri.Text = "TÜM MÜŞTERİLER";
            this.btntummusteri.UseVisualStyleBackColor = true;
            this.btntummusteri.Click += new System.EventHandler(this.btntummusteri_Click);
            // 
            // btnmusterigetir
            // 
            this.btnmusterigetir.Location = new System.Drawing.Point(239, 258);
            this.btnmusterigetir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnmusterigetir.Name = "btnmusterigetir";
            this.btnmusterigetir.Size = new System.Drawing.Size(200, 42);
            this.btnmusterigetir.TabIndex = 8;
            this.btnmusterigetir.Text = "MÜŞTERİ GETİR";
            this.btnmusterigetir.UseVisualStyleBackColor = true;
            this.btnmusterigetir.Click += new System.EventHandler(this.btnmusterigetir_Click);
            // 
            // txtsorgu
            // 
            this.txtsorgu.Location = new System.Drawing.Point(239, 215);
            this.txtsorgu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsorgu.Name = "txtsorgu";
            this.txtsorgu.Size = new System.Drawing.Size(199, 22);
            this.txtsorgu.TabIndex = 7;
            // 
            // MusteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1856, 948);
            this.Controls.Add(this.lwmusteriler);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btntummusteri);
            this.Controls.Add(this.btnmusterigetir);
            this.Controls.Add(this.txtsorgu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MusteriEkleForm";
            this.Text = "MusteriEkleForm";
            this.Load += new System.EventHandler(this.MusteriEkleForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ListView lwmusteriler;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnGuncelleme;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cboxkurumsal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtYetkiliAd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMusteriUnvan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPasaportNo;
        private System.Windows.Forms.ComboBox cmbdil;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTckimlik;
        private System.Windows.Forms.ComboBox cmbilce;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox Cmbil;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.ComboBox cmbUlke;
        private System.Windows.Forms.DateTimePicker dtpdogumtarihi;
        private System.Windows.Forms.Button btntummusteri;
        private System.Windows.Forms.Button btnmusterigetir;
        private System.Windows.Forms.TextBox txtsorgu;
        private System.Windows.Forms.TextBox txtVergiNo;
    }
}