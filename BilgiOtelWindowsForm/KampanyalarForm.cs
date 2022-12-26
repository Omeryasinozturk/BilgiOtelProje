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

namespace BilgiOtelWindowsForm
{
    public partial class KampanyalarForm : Form
    {
        public KampanyalarForm()
        {
            InitializeComponent();
        }
        Kampanyalar kamp = new Kampanyalar();
        KampanyalarDAL kampdal =new KampanyalarDAL();
        NesneDoldurma nesne = new NesneDoldurma();
        void Kampanyalar()
        {
            nesne.listdordurmalisteyegore(kampdal.getAllKampanyalar(), lwkampanyalar);   
        }
        void ekrandakilerkampanyaentitysinde()
        {
            kamp.KampanyaBilgileri = txtkampanyabilgi.Text;
            kamp.KampanyaIndirimOran =Convert.ToInt32(txtkampanyaindirim.Text);
            kamp.KampanyaBaslangicZaman = dtpkambaslangıc.Value;
            kamp.KampanyaBitisTarihi = dtpkambitis.Value;
            kamp.KampanyaTanim = txtkampanyatanım.Text;

        }
        private void KampanyalarForm_Load(object sender, EventArgs e)
        {
            Kampanyalar();
        }

        private void lwkampanyalar_Click(object sender, EventArgs e)
        {  
            txtkampanyaid.Text= lwkampanyalar.SelectedItems[0].SubItems[0].Text;
            txtkampanyabilgi.Text=lwkampanyalar.SelectedItems[0].SubItems[1].Text;
            txtkampanyaindirim.Text = lwkampanyalar.SelectedItems[0].SubItems[2].Text;
            dtpkambaslangıc.Value = Convert.ToDateTime(lwkampanyalar.SelectedItems[0].SubItems[3].Text);
            dtpkambitis.Value = Convert.ToDateTime(lwkampanyalar.SelectedItems[0].SubItems[4].Text);
            txtkampanyatanım.Text=lwkampanyalar.SelectedItems[0].SubItems[5].Text;

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                ekrandakilerkampanyaentitysinde();
                if (txtkampanyabilgi.Text != String.Empty && txtkampanyaindirim.Text != String.Empty && txtkampanyatanım.Text != String.Empty)
                {
                    kampdal.insertKampanyalar(kamp);
                    Kampanyalar();
                }
                else
                {
                    MessageBox.Show("Lütfen Kampanya Detaylarını Doldurunuz!");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı"+hata);
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {   
                ekrandakilerkampanyaentitysinde();
                if (txtkampanyabilgi.Text != String.Empty && txtkampanyaindirim.Text != String.Empty && txtkampanyatanım.Text != String.Empty && txtkampanyaid.Text != String.Empty)
                {
                    kamp.KampanyaId = Convert.ToInt32(lwkampanyalar.SelectedItems[0].SubItems[0].Text);
                    kampdal.updateKampanyalar(kamp);
                    Kampanyalar();
                }
                else
                {
                    MessageBox.Show("Lütfen Tablodan Güncellemek istediğiniz Kampanyayı seçiniz.");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı" + hata);
            }
        }

        private void btnkampanyasil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lwkampanyalar.SelectedItems[0].SubItems[0].Text != String.Empty)
                {
                    kamp.KampanyaId = Convert.ToInt32(lwkampanyalar.SelectedItems[0].SubItems[0].Text);
                    kampdal.deleteKampanyalar(kamp);

                    Kampanyalar();
                }
                else
                {
                    MessageBox.Show("Lütfen Kampanya seçiniz!");
                }

            }
            catch (Exception hata)
            {
                MessageBox.Show("Beklenmedik bir hata ile karşılaşıldı" + hata);
            }
        }
    }
}
