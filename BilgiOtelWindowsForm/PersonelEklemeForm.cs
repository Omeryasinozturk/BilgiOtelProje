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
        PersonellerDAL personeldal = new PersonellerDAL();  
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
            personel.PersonelPasaportNo = txtPasaportno.Text;
            personel.PersonelSaatlikUcret =Convert.ToDecimal(txtsaatlikucret.Text);
            personel.PersonelSaatlikUcret=Convert.ToDecimal(txtsaatlikucret.Text);
            personel.PersonelAcilDurumKisiAd = txtacildurumkisi.Text;
            personel.PersonelDogumTarihi = dtpdogumtarihi.Value;
            personel.PersonelIseGirisTarihi = dtpisegiristarihi.Value;
            personel.UlkeId =(int)cmbUlke.SelectedValue;
            personel.IlId = (int)Cmbil.SelectedValue;
            personel.IlceId=(int)cmbilce.SelectedValue;
            personel.PersonelKategoriID=(int)cmbKategori.SelectedValue;
            personel.PersonelSicilNo=txtsicilno.Text;
        }
        private void PersonelEklemeForm_Load(object sender, EventArgs e)
        {
            nesne.herhangibircombo(cmbUlke, "select * from tbl_Ulke", "txt");
            nesne.herhangibircombo(cmbdil, "select * from tbl_Diller", "txxt");
            nesne.herhangibircombo(CmbCinsiyet, "select * from tbl_Cinsiyet", "txt");
            nesne.herhangibircombo(cmbKategori, "select * from tbl_PersonelKategori", "txt");
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
            ekrandakilerientityeal();


        }
    }
}
