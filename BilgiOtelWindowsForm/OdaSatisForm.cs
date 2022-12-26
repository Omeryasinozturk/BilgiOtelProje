using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiOtelDAL;
using BilgiOtel_Entity;
using System.Data.SqlClient;

namespace BilgiOtelWindowsForm
{
    public partial class OdaSatisForm : Form
    {   // silinecek veriler  düzenmelesi oda durum ve tüm fiyat hesaplamaları kısmıyla yapılacak
        List<string> odakontrollistesi = new List<string>();
        List<string> odadurumkontrollistesi = new List<string>();
        List<decimal> odasatistipkatsayi = new List<decimal>();
        //
        Misafir satismisafir= new Misafir();
        MisafirlerDAL satismisafirdal = new MisafirlerDAL();    
        Musteri satismusteri = new Musteri();
        MusterilerDAL satismusteridal = new MusterilerDAL();
        Satis satis =new Satis();
        SatisDAL SatisDAL = new SatisDAL();
        Odalar oda = new Odalar();
        OdalarDAL odadal = new OdalarDAL();
        Kampanyalar kampanyaentity = new Kampanyalar();
        KampanyalarDAL kampanyadal = new KampanyalarDAL();
        NesneDoldurma nesne =new NesneDoldurma();
       
        public OdaSatisForm()
        {
            InitializeComponent();
        }

        #region  Oda Durum ve Tüm Fiyat Hesaplamaları
        decimal satistipkatsayi = 1;
        void ekrandakilersatisentitysinde()
        { 
            satis.SatisOdaGirisTarihi = dt1.Value;
            satis.SatisOdaCikisTarihi = dt2.Value;
        }
        void tarihfarkı()
        {

            DateTime ilktarih = dt1.Value;
            DateTime ikincitarih = dt2.Value;
            if (ilktarih <= ikincitarih)
            {
                txtsatısindirimoranı.Text = "";
                TimeSpan tarihfarkı = Convert.ToDateTime(dt2.Value) - Convert.ToDateTime(dt1.Value);
                int gunsayısı = Convert.ToInt32(tarihfarkı.TotalDays);
                // gunsayısı++;
                txtgunsayısı.Text = gunsayısı.ToString();

                odadurumbilgilerigetir();
                kampanyasorgu();
            }
        }
        void kampanyasorgu()
        {
            kampanyaentity.KampanyaBaslangicZaman = dt1.Value;
            kampanyaentity = kampanyadal.TariheGoreKampanyaGetir(kampanyaentity);
            
            if (kampanyaentity.KampanyaIndirimOran != 0)
            {
                txtsatısindirimoranı.Text = kampanyaentity.KampanyaIndirimOran.ToString();
            }
            else
            {
                txtsatısindirimoranı.Text = "0";
            }
         
        }
        void indirimhesap()
        {
            if (txtodafiyat.Text != String.Empty && txtsatısindirimoranı.Text != String.Empty && txtgunsayısı.Text != String.Empty)
            {
                decimal odafiyat = oda.OdaFiyat * satistipkatsayi;
                txtkatsayılıfiyat.Text= odafiyat.ToString();
                int kalınacakgun = Convert.ToInt32(txtgunsayısı.Text);
                decimal kdvoranı = 18;
                decimal sonuc;
               
                if (kampanyaentity.KampanyaIndirimOran!= 0)
                {
                    decimal indirim;
                    indirim = (odafiyat * kalınacakgun * kampanyaentity.KampanyaIndirimOran) / 100;
                    sonuc = (((odafiyat * kalınacakgun) - indirim) * (kdvoranı)) / 100;
                    txtKdvoranı.Text = sonuc.ToString();
                    txtodasatıstutar.Text=((odafiyat * kalınacakgun -indirim)+sonuc).ToString();
                }
                else
                {
                    sonuc = (((odafiyat * kalınacakgun) * (kdvoranı))/100);
                    txtodasatıstutar.Text=((odafiyat * kalınacakgun)+(sonuc)).ToString();
                }

            }
        }

        void odasatistipkatsayiları()
        {
            nesne.herhangibircombo(cmbodasatistip, "sp_odasatistipkatsayi","txt");
        }

        void odadurumbilgilerigetir()
        {
            ekrandakilersatisentitysinde();
            odakontrollistesi = SatisDAL.OdaDurumlarıKontrol(satis);
            // ODA TADİLAT DURUMLARI KONTROL ////
            //baglanti.Open();
            //SqlCommand odadurumsorgu = new SqlCommand("sp_odadurumsorgulama", baglanti);
            //odadurumsorgu.CommandType = CommandType.StoredProcedure;
            //odadurumsorgu.Parameters.AddWithValue("@ilktarih", dt1.Value.ToString("MM / dd / yyyy HH: mm:ss"));
            //odadurumsorgu.Parameters.AddWithValue("@ikincitarih", dt2.Value.ToString("MM / dd / yyyy HH: mm:ss"));
            //SqlDataReader dr2 = odadurumsorgu.ExecuteReader();
            //while (dr2.Read())
            //{
            //    odadurumkontrollistesi.Add(dr2[0].ToString());
            //}
            //baglanti.Close();
            //dr.Close();

            foreach (Control x in gboxoda.Controls)
            {
                if (x is Button)
                {
                    if (odakontrollistesi.Contains(x.Text))
                    {
                        x.BackColor = Color.Red;
                    }
                   /* else if (odadurumkontrollistesi.Contains(x.Text))
                    {
                        x.BackColor = Color.White;
                    }*/
                    else
                    {
                        x.BackColor = Color.Green;
                    }

                }
            }

        }
        #endregion

        #region Listview de müşteri silme-ekleme-temizleme
        private void btnmusterisil_Click(object sender, EventArgs e)
        {
            lwMusteriler.Items.Remove(lwMusteriler.SelectedItems[0]);
        }

        private void btnmusteritemizle_Click(object sender, EventArgs e)
        {
            lwMusteriler.Items.Clear();
        }

        private void btnmisafirsil_Click(object sender, EventArgs e)
        {
            lwmisafirler.Items.Clear();
        }

        private void btnmisafirtemizle_Click(object sender, EventArgs e)
        {
            lwmisafirler.Items.Clear();
        }

        private void btnmusterigetir_Click(object sender, EventArgs e)
        {
            nesne.listdordurmalisteyegore(BilgiOtelHelperSQL.myexecuteReaderTable("sp_BireyselMusteriGetirme",nesne.degeriparametreyapma("MusteriTC", tcgoremusterigetir.Text),"sp"), lwMusteriler);
        }
      
        private void btnmisafirgetir_Click(object sender, EventArgs e)
        {

            satismisafir = satismisafirdal.TCGoreMisafirGetirme(tcgoremisafirgetir.Text);
            ListViewItem ekleme = new ListViewItem(satismisafir.MisafirId.ToString());

            ekleme.SubItems.Add(satismisafir.MisafirTcKimlik.ToString());
            ekleme.SubItems.Add(satismisafir.MisafirAd.ToString());
            ekleme.SubItems.Add(satismisafir.MisafirSoyad.ToString());
            ekleme.SubItems.Add(satismisafir.MisafirTelefon.ToString());

            lwmisafirler.Items.Add(ekleme);


        }
        #endregion

        #region DatetimePickerlar
        private void dt1_ValueChanged(object sender, EventArgs e)
        {
            dt2.MinDate = dt1.Value;
            tarihfarkı();
            odadurumbilgilerigetir();
            kampanyasorgu();
            if (txtodafiyat.Text != String.Empty && txtsatısindirimoranı.Text != String.Empty)
            {
                indirimhesap();
            }
        }

        private void dt2_ValueChanged(object sender, EventArgs e)
        {
            tarihfarkı();
            odadurumbilgilerigetir();

            if (txtodafiyat.Text != String.Empty && txtsatısindirimoranı.Text != String.Empty)
            {
                indirimhesap();
            }
        }

        #endregion

        #region Oda Seçimi ve bilgilerinin yüklenmesi
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor == Color.Green)
            {
                oda = odadal.IdGoreOdaBilgileriGetirme(btn.Text);

                txtodanumarası.Text = oda.OdaId.ToString();
                txtodafiyat.Text = oda.OdaFiyat.ToString();
                txtodakat.Text = oda.OdaKat.ToString();
                txtOdaaciklama.Text = oda.OdaAciklama.ToString();
                txtodakisisayisi.Text = oda.OdaKisiSayisi.ToString();
                cboxMini.Checked = oda.OdaMiniBarOk;
                cboxBalkon.Checked = oda.OdaBalkonOk;
                cboxKlima.Checked = oda.OdaKlimaOk;
                cboxKurutma.Checked = oda.OdaKurutmaOk;
                cboxTv.Checked = oda.OdaTvOk;
                cboxWifi.Checked = oda.OdaWifiOk;
                cboxKasa.Checked = oda.OdaKasaOk;

                indirimhesap();

            }
            else
            {
                DialogResult secim = MessageBox.Show("Odadan Çıkış mı yapılıyor?","Çıkış",MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (secim== DialogResult.Yes)
                {
                    MessageBox.Show("odadan çıkış yapılıyor");
                }

                odadurumbilgilerigetir();
            }
            odadurumbilgilerigetir();
        }
        #endregion
        #region Form LOAD
        private void OdaSatisForm_Load(object sender, EventArgs e)
        {
            dt2.MinDate = dt1.Value;
            odadurumbilgilerigetir();
            odasatistipkatsayiları();
            cmbodasatistip.SelectedIndex = -1;
        }
        #endregion
        #region Satistipi degisimi
        private void cmbodasatistip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            satistipkatsayi = SatisDAL.OdaSatisTipKatsayiDondurme((int)cmbodasatistip.SelectedValue);
            textBox1.Text=satistipkatsayi.ToString();
            indirimhesap();
        }
        #endregion

        private void btnSatıs_Click(object sender, EventArgs e)
        {

            if (txtodanumarası.Text != String.Empty && lwmisafirler.Items.Count > 0 && lwMusteriler.Items.Count > 0)
            {
                satis.OdaId = oda.OdaId;
                satis.SatisIndirim = kampanyaentity.KampanyaIndirimOran;
                satis.SatisOdaGirisTarihi = dt1.Value;
                satis.SatisOdaCikisTarihi = dt2.Value;
                satis.OdaSatisTutar = Convert.ToDecimal(txtodasatıstutar.Text);
                satis.OdaSatisKDV = Convert.ToDecimal(txtKdvoranı.Text);
                satis.OdaSatisOdemeTipiId = Convert.ToInt32(cmbodasatistip.SelectedValue);
                satis.SatisAktifMi = cboxOdeme.Checked;

                satis.SatisId= SatisDAL.OdaSatis(satis, GlobalGirisClass.GirisYapanID);
                
                if (satis.SatisId != 0)
                {
                    for (int i = 0; i < lwmisafirler.Items.Count; i++)
                    {
                        satismusteri.MusteriID = Convert.ToInt32(lwMusteriler.Items[0].SubItems[0].Text);
                        satismisafir.MisafirId = Convert.ToInt32(lwmisafirler.Items[i].SubItems[0].Text);

                        SatisDAL.OdaSatisAraTablo(satismusteri, satismisafir, satis);
                        MessageBox.Show("Satış Başarılı");
                        odadurumbilgilerigetir();
                    }
                }
            }
            else
            {
                MessageBox.Show("LÜTFEN ODANIN MÜŞTERİ,MİSAFİR VE ODA BELİRTİNİZ..");
            }
        }
    }
}
