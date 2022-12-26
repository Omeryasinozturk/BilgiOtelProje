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
    public partial class MusteriEkleForm : Form
    {
        MusterilerDAL musteri =new MusterilerDAL();
        Musteri kurumsalmusteri = new Musteri();
        Misafir bireyselmusteri = new Misafir();
        NesneDoldurma nesne = new NesneDoldurma();
        public MusteriEkleForm()
        {
            InitializeComponent();
        }
        void lwdoldurma()
        { nesne.listviewdoldur(lwmusteriler, "sp_Musteriler", null, "sp"); }
        void KurumsalMusteriBilgileriEntityde()
        {
            kurumsalmusteri.MusteriAd = txtAd.Text;
            kurumsalmusteri.MusteriSoyad = txtSoyad.Text;
            kurumsalmusteri.MusteriVergiNo = txtVergiNo.Text;
            kurumsalmusteri.MusteriTelefon = txtTelefon.Text;
            kurumsalmusteri.MusteriPosta = txtEposta.Text;
            kurumsalmusteri.MusteriPasaportNo=txtPasaportNo.Text;
            kurumsalmusteri.MusteriUnvan = txtMusteriUnvan.Text;
            kurumsalmusteri.MusteriYetkiliAdSoyad = txtYetkiliAd.Text;
            kurumsalmusteri.MusteriVergiDairesi = txtVergiDairesi.Text;
            kurumsalmusteri.MusteriAdres = txtAdres.Text;
            kurumsalmusteri.MusteriAciklama = txtAciklama.Text;
            kurumsalmusteri.MusteriKurumsalOK = cboxkurumsal.Checked;
            kurumsalmusteri.UlkeID =Convert.ToInt32( cmbUlke.SelectedValue);
            kurumsalmusteri.IlID = Convert.ToInt32(Cmbil.SelectedValue);
            kurumsalmusteri.IlceID = Convert.ToInt32(cmbilce.SelectedValue);
            kurumsalmusteri.DilID= Convert.ToInt32(cmbdil.SelectedValue);
        }
        void bireyselmusteriBilgileriEntityde()
        {
            bireyselmusteri.MisafirAd = txtAd.Text;
            bireyselmusteri.MisafirSoyad = txtSoyad.Text;
            bireyselmusteri.MisafirTcKimlik = txtTckimlik.Text;
            bireyselmusteri.MisafirTelefon = txtTelefon.Text;
            bireyselmusteri.MisafirEposta= txtEposta.Text;
            bireyselmusteri.MisafirPasaportNo = txtPasaportNo.Text;
            bireyselmusteri.MisafirAdres = txtAdres.Text;
            bireyselmusteri.MisafirAciklama = txtAciklama.Text;
            bireyselmusteri.UlkeId = Convert.ToInt32(cmbUlke.SelectedValue);
            bireyselmusteri.IlId = Convert.ToInt32(Cmbil.SelectedValue);
            bireyselmusteri.IlceId = Convert.ToInt32(cmbilce.SelectedValue);
            bireyselmusteri.dilId = Convert.ToInt32(cmbdil.SelectedValue);
            bireyselmusteri.CinsiyetId = Convert.ToInt32(CmbCinsiyet.SelectedValue);
            bireyselmusteri.MisafirDogumTarihi = Convert.ToDateTime(dtpdogumtarihi.Value);


        }
        void comboilyukleme()
        { nesne.herhangibircombo(Cmbil, "select * from tbl_Il where UlkeId=" + cmbUlke.SelectedValue + "", "txt"); }
        void comboilceyukleme()
        { nesne.herhangibircombo(cmbilce, "select * from tbl_Ilce where IlId=" + Cmbil.SelectedValue + "", "txt"); }
        private void MusteriEkleForm_Load(object sender, EventArgs e)
        {
           nesne.herhangibircombo(cmbUlke, "select * from tbl_Ulke", "txt");
           nesne.herhangibircombo(cmbdil, "select * from tbl_Diller", "txxt");
           nesne.herhangibircombo(CmbCinsiyet, "select * from tbl_Cinsiyet", "txt");
           nesne.listviewdoldur(lwmusteriler, "sp_Musteriler",null,"sp");

        }

        private void cboxkurumsal_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxkurumsal.Checked == true)
            {
                label16.Visible = false;
                dtpdogumtarihi.Visible = false;
                label19.Visible = false;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                txtVergiNo.Visible = true;
                CmbCinsiyet.Visible = false;
                label7.Visible = true;
                label8.Visible = true;

                label10.Visible = true;
                txtMusteriUnvan.Visible = true;
                txtYetkiliAd.Visible = true;
                txtVergiDairesi.Visible = true;

                

            }
            else
            {
                label6.Visible = true;
                label7.Visible = false;
                label8.Visible = false;
                label19.Visible = true;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                txtVergiNo.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label16.Visible = true;
                dtpdogumtarihi.Visible = true;
                CmbCinsiyet.Visible = true;
                label19.Visible = true;
                label10.Visible = false;
                txtMusteriUnvan.Visible = false;
                txtYetkiliAd.Visible = false;
                txtVergiDairesi.Visible = false;
            }
        }

        private void cmbUlke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboilyukleme();
        }

        private void Cmbil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboilceyukleme();
        }

        private void lwmusteriler_Click(object sender, EventArgs e)
        {
            cboxkurumsal.Checked = Convert.ToBoolean(lwmusteriler.SelectedItems[0].SubItems[16].Text);
            txtAd.Text = lwmusteriler.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = lwmusteriler.SelectedItems[0].SubItems[2].Text;
            txtTckimlik.Text=lwmusteriler.SelectedItems[0].SubItems[3].Text;
            txtVergiNo.Text = lwmusteriler.SelectedItems[0].SubItems[7].Text;
            txtTelefon.Text=lwmusteriler.SelectedItems[0].SubItems[9].Text;
            txtEposta.Text= lwmusteriler.SelectedItems[0].SubItems[10].Text;
            txtPasaportNo.Text= lwmusteriler.SelectedItems[0].SubItems[4].Text;
            txtMusteriUnvan.Text= lwmusteriler.SelectedItems[0].SubItems[5].Text;
            txtYetkiliAd.Text= lwmusteriler.SelectedItems[0].SubItems[6].Text;
            txtVergiDairesi.Text= lwmusteriler.SelectedItems[0].SubItems[8].Text;
            txtAdres.Text= lwmusteriler.SelectedItems[0].SubItems[11].Text;
            txtAciklama.Text= lwmusteriler.SelectedItems[0].SubItems[15].Text;
            abcdef(cmbUlke, lwmusteriler.SelectedItems[0].SubItems[14].Text);
            comboilyukleme();
            abcdef(Cmbil, lwmusteriler.SelectedItems[0].SubItems[12].Text);
            comboilceyukleme();
            abcdef(cmbilce, lwmusteriler.SelectedItems[0].SubItems[13].Text);
            if (lwmusteriler.SelectedItems[0].SubItems[17].Text!="")
            {   abcdef(cmbdil, lwmusteriler.SelectedItems[0].SubItems[17].Text);}
            if (lwmusteriler.SelectedItems[0].SubItems[18].Text != "")
            {   dtpdogumtarihi.Value = Convert.ToDateTime(lwmusteriler.SelectedItems[0].SubItems[18].Text);}
            if (lwmusteriler.SelectedItems[0].SubItems[19].Text != "")
            {   abcdef(CmbCinsiyet, lwmusteriler.SelectedItems[0].SubItems[19].Text);}
           
        }
        void abcdef(ComboBox cmb,string tablodakideger)
        {
            List<KeyValuePair<object, string>> liste2 = (List<KeyValuePair<object, string>>)cmb.DataSource;
            //cmb.SelectedValue = liste2.FirstOrDefault(w => w.Value == tablodakideger).Key;
            for (int i = 0; i < liste2.Count(); i++)
            {
                if (liste2[i].Value == tablodakideger)
                {
                    cmb.SelectedValue = liste2[i].Key;
                    break;
                }
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            
            
            if (cboxkurumsal.Checked==true)
            {
                KurumsalMusteriBilgileriEntityde();
                musteri.KurumsalMusteriEkleme(kurumsalmusteri, GlobalGirisClass.GirisYapanID);
            }
            else
            {
                bireyselmusteriBilgileriEntityde();
                musteri.BireyselMusteriEkleme(bireyselmusteri,GlobalGirisClass.GirisYapanID);
            }
        }

        private void btnGuncelleme_Click(object sender, EventArgs e)
        {
            if (lwmusteriler.SelectedItems.Count!=0)
            {
                if (cboxkurumsal.Checked == true)
                {
                    KurumsalMusteriBilgileriEntityde();
                    kurumsalmusteri.MusteriID = Convert.ToInt32(lwmusteriler.SelectedItems[0].SubItems[0].Text);
                    musteri.KurumsalMusteriGuncelleme(kurumsalmusteri);
                    lwdoldurma();
                }
                else
                {
                    bireyselmusteriBilgileriEntityde();
                    bireyselmusteri.MisafirId = Convert.ToInt32(lwmusteriler.SelectedItems[0].SubItems[0].Text);
                    musteri.BireyselMusteriGuncelleme(bireyselmusteri);
                    lwdoldurma();
                }
            }
            else
            {
                MessageBox.Show("Test");
            }
            
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            nesne.FromTemizleme(this);
            lwdoldurma();
        }

        private void btnmusterigetir_Click(object sender, EventArgs e)
        {
            SqlParameter[] sorgu =
            {
                new SqlParameter
                { ParameterName="SorguBilgisi",
                    Value=txtsorgu.Text
                }
            };
            nesne.listviewdoldur(lwmusteriler, "sp_MusteriTcveyaVergiyegoreSorgu", sorgu, "sp");
        }

        private void btntummusteri_Click(object sender, EventArgs e)
        {
            lwdoldurma();
        }
    }
}
