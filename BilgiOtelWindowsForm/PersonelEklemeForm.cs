using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BilgiOtel_Entity;
using BilgiOtelDAL;

namespace BilgiOtelWindowsForm
{
    public partial class PersonelEklemeForm : Form
    {
        public PersonelEklemeForm()
        {
            InitializeComponent();
        }
        NesneDoldurma nesne = new NesneDoldurma();
        Personeller personel =new Personeller();
        Kullanici kaydedilecekkullanici = new Kullanici();
        Yetkiler kaydedilecekyetki = new Yetkiler();
        PersonellerDAL personeldal = new PersonellerDAL();  
        // kullanicilardal = new KullaniciDal(); 
        void comboilyukleme()
        { nesne.herhangibircombo(Cmbil, "select * from tbl_Il where UlkeId=" + cmbUlke.SelectedValue + "", "txt"); }
        void comboilceyukleme()
        { nesne.herhangibircombo(cmbilce, "select * from tbl_Ilce where IlId=" + Cmbil.SelectedValue + "", "txt"); }

        void ekrandakilerientityeal()
        {
            personel.PersonelAd = txtAd.Text;
            personel.PersonelSoyad = txtSoyad.Text;
            personel.PersonelTcKimlik = txtTckimlik.Text;
            personel.PersonelTelefon=txtTelefon.Text;
            personel.PersonelEposta=txtEposta.Text;
            personel.PersonelSaatlikUcret =Convert.ToDecimal(txtsaatlikucret.Text);
            personel.PersonelMaas=Convert.ToDecimal(txtmaas.Text);
            personel.PersonelAcilDurumKisiAd = txtacildurumkisi.Text;
            personel.PersonelAcilDurumKisiTelefon= txtacildurumtel.Text;
            personel.PersonelDogumTarihi = dtpdogumtarihi.Value;
            personel.PersonelIseGirisTarihi = dtpisegiristarihi.Value;
            personel.UlkeId =(int)cmbUlke.SelectedValue;
            personel.IlId = (int)Cmbil.SelectedValue;
            personel.IlceId=(int)cmbilce.SelectedValue;
            personel.CinsiyetId= (int)CmbCinsiyet.SelectedValue;
            personel.PersonelKategoriID=(int)cmbKategori.SelectedValue;
            personel.PersonelSicilNo=txtsicilno.Text;
            personel.PersonelAdres=txtpersoneladres.Text;
        }
        private void PersonelEklemeForm_Load(object sender, EventArgs e)
        {
            nesne.herhangibircombo(cmbUlke, "select * from tbl_Ulke", "txt");
            nesne.herhangibircombo(CmbCinsiyet, "select * from tbl_Cinsiyet", "txt");
            nesne.herhangibircombo(cmbKategori, "select * from tbl_PersonelKategori", "txt");
            nesne.herhangibircombo(cmbpersonel, "select PersonelId,PersonelAd +' '+PersonelSoyad as AdSoyad from tbl_Personel", "txt");
            nesne.herhangibircombo(cmbyetki, "select YetkiId,YetkiAd +' '+YetkiAciklama as YetkiBilgi from tbl_Yetkiler", "txt");
            nesne.herhangibircombo(cmbkullanicitip, "select KullaniciTipiId,KullaniciTipiTanim from tbl_KullaniciTipi", "txt");
        }

        private void cmbUlke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboilyukleme();
        }

        private void Cmbil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboilceyukleme();
        }

        private void btnpersonekle_Click(object sender, EventArgs e)
        {
            try
            {
                ekrandakilerientityeal();
                int sonuc = personeldal.PersonelEkleme(personel);
                MessageBox.Show(sonuc +"İşlem Başarılı!");
            }
            catch (Exception hata) 
            {
                MessageBox.Show("Birşeyler Ters Gitti!"+hata);
            }
            
        }
        void yetkibilgilerikayıt()
        {
            kaydedilecekkullanici.KullaniciAd = txtkullanıcıad.Text;
            kaydedilecekkullanici.KullaniciParola = txtkullanıcıparola.Text;
            kaydedilecekkullanici.KullaniciEposta = txtEposta.Text;
            kaydedilecekkullanici.KullaniciKayıtTarihi=DateTime.Today;
            kaydedilecekkullanici.KullaniciSonGirisTarihi = DateTime.Today;
            personel.PersonelId = (int)cmbpersonel.SelectedValue;
            kaydedilecekyetki.YetkiId = (int)cmbyetki.SelectedValue;

        }
        private void YetkiKaydet_Click(object sender, EventArgs e)
        {
            yetkibilgilerikayıt();
         //  kullanicilardal.KullanıcıKaydet(kaydedilecekkullanici, personel, kaydedilecekyetki);
        }
    }
}
