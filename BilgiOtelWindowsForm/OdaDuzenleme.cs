using BilgiOtel_Entity;
using BilgiOtelDAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtelWindowsForm
{
    public partial class OdaDuzenleme : Form
    {
        public OdaDuzenleme()
        {
            InitializeComponent();
        }
        #region Kullanılan Classlar
        NesneDoldurma nesne = new NesneDoldurma();
        Odalar OdaGuncelleme = new Odalar();
        OdalarDAL OdaDAL = new OdalarDAL();
        OdaDurum tadilatdurum = new OdaDurum();
        #endregion
        #region Verileri Ekrandan Alma - Başlangıçta Ekrana Verileri Yazma
        void odalar()
        {
            nesne.listdordurmalisteyegore(BilgiOtelHelperSQL.myexecuteReaderTable("SELECT OdaId,OdaFiyat,OdaMiniBarOk,OdaKlimaOk,OdaKurutmaOk,OdaWifiOk,OdaKasaOk,OdaBalkonOk,OdaTvOk,OdaAciklama,OdaKat,OdaKisiSayisi FROM tbl_Odalar",null,"txt"),lwodalar);
        }
        void odadurum()
        {
            nesne.listdordurmalisteyegore(BilgiOtelHelperSQL.myexecuteReaderTable("sp_odadurumtablo", null,"sp"), lwodadurum);
        }
        void odadurumlarıdoldurma()
        {
            nesne.herhangibircombo(cmbodadurum, "sp_odadurumkategori", "sp");
        }
        void odabilgilerinientityalma()
        {
            OdaGuncelleme.OdaId = Convert.ToInt32(txtodanumarası.Text);
            OdaGuncelleme.OdaKat = Convert.ToInt32(txtodakat.Text);
            OdaGuncelleme.OdaFiyat = Convert.ToDecimal(txtodafiyat.Text);
            OdaGuncelleme.OdaKisiSayisi = Convert.ToInt32(txtodakisisayisi.Text);
            OdaGuncelleme.OdaAciklama = txtOdaaciklama.Text;
            OdaGuncelleme.OdaKlimaOk=cboxKlima.Checked;
            OdaGuncelleme.OdaMiniBarOk = cboxMini.Checked;
            OdaGuncelleme.OdaWifiOk = cboxWifi.Checked;
            OdaGuncelleme.OdaTvOk = cboxTv.Checked;
            OdaGuncelleme.OdaBalkonOk = cboxBalkon.Checked;
            OdaGuncelleme.OdaKasaOk = cboxKasa.Checked;
            OdaGuncelleme.OdaKurutmaOk = cboxKurutma.Checked;

        }
        void tadilatbilgilerientityalma()
        {
            tadilatdurum.OdaDurumID =Convert.ToInt32(txtdurumid.Text);
            tadilatdurum.OdaId =Convert.ToInt32( txtodatadilat.Text);
            tadilatdurum.DurumKategoriId =Convert.ToInt32(cmbodadurum.SelectedValue);
            tadilatdurum.OdaDurumilktarih = dt1baslangıc.Value;
            tadilatdurum.OdaDurumSonTarih = dt2bitis.Value;
            tadilatdurum.OdaDurumAktifMi = cboxAktif.Checked;

        }
        #endregion 
        private void OdaDuzenleme_Load(object sender, EventArgs e)
        {
            odalar();
            odadurum();
            odadurumlarıdoldurma();
            dt2bitis.MinDate = dt1baslangıc.Value;
        }

        private void lwodalar_Click(object sender, EventArgs e)
        {
            txtodanumarası.Text = lwodalar.SelectedItems[0].SubItems[0].Text;
            txtodafiyat.Text = lwodalar.SelectedItems[0].SubItems[1].Text;
            txtodakat.Text = lwodalar.SelectedItems[0].SubItems[10].Text;
            txtOdaaciklama.Text = lwodalar.SelectedItems[0].SubItems[9].Text;
            txtodakisisayisi.Text = lwodalar.SelectedItems[0].SubItems[11].Text;
            //
            cboxBalkon.Checked = Convert.ToBoolean(lwodalar.SelectedItems[0].SubItems[7].Text);
            cboxKasa.Checked = Convert.ToBoolean(lwodalar.SelectedItems[0].SubItems[6].Text);
            cboxKlima.Checked = Convert.ToBoolean(lwodalar.SelectedItems[0].SubItems[3].Text);
            cboxKurutma.Checked = Convert.ToBoolean(lwodalar.SelectedItems[0].SubItems[4].Text);
            cboxMini.Checked = Convert.ToBoolean(lwodalar.SelectedItems[0].SubItems[2].Text);
            cboxTv.Checked = Convert.ToBoolean(lwodalar.SelectedItems[0].SubItems[8].Text);
            cboxWifi.Checked = Convert.ToBoolean(lwodalar.SelectedItems[0].SubItems[5].Text);

        }

        private void btnodabilgiguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                odabilgilerinientityalma();
                if (txtodanumarası.Text != String.Empty && txtodakisisayisi.Text!=String.Empty)
                {
                   int etkilenen = OdaDAL.Odaguncelleme(OdaGuncelleme);
                    MessageBox.Show(etkilenen+" satır etkilendi.");
                }
                else
                {
                    MessageBox.Show("Oda Seçin veya odakişisayısını boş bırakmayınız.");
                }

                odalar();

            }
            catch (Exception hata)
            {
                MessageBox.Show("HATA"+ hata);

            }
            
        }

        private void btntadilatkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                tadilatbilgilerientityalma();

                if (txtodatadilat.Text != String.Empty)
                {
                    OdaDAL.OdaDurumEkleme(tadilatdurum);
                }
                else
                {
                    MessageBox.Show("Oda Numarasını Belirtiniz.");
                }

                odadurum();

            }
            catch (Exception hat)
            {
                MessageBox.Show("HATA"+hat);
            }

        }

        private void btntadilatguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                tadilatbilgilerientityalma();

                if (txtodatadilat.Text != String.Empty)
                {
                    OdaDAL.OdaDurumGuncelleme(tadilatdurum);
                }
                else
                {
                    MessageBox.Show("Oda Numarasını Belirtiniz.");
                }

                odadurum();

            }
            catch (Exception hat)
            {
                MessageBox.Show("HATA" + hat);
            }
        }

        private void btntadilatsilme_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Çalışmıyor :)");
        }

        private void lwodadurum_Click(object sender, EventArgs e)
        {
            txtdurumid.Text = lwodadurum.SelectedItems[0].SubItems[0].Text;
            txtodatadilat.Text = lwodadurum.SelectedItems[0].SubItems[1].Text;
            dt1baslangıc.Value =Convert.ToDateTime(lwodadurum.SelectedItems[0].SubItems[2].Text);
            dt2bitis.Value =Convert.ToDateTime(lwodadurum.SelectedItems[0].SubItems[3].Text);
            cboxAktif.Checked=Convert.ToBoolean(lwodadurum.SelectedItems[0].SubItems[5].Text);

            nesne.ismeGoreComboSectirme(cmbodadurum, lwodadurum.SelectedItems[0].SubItems[4].Text);

        }

        private void dt1baslangıc_ValueChanged(object sender, EventArgs e)
        {
            dt2bitis.MinDate = dt1baslangıc.Value;
        }
    }
}
