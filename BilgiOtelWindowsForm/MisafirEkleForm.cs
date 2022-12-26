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
    public partial class MisafirEkleForm : Form
    {
        public MisafirEkleForm()
        {
            InitializeComponent();
        }
        MisafirlerDAL misafirdal = new MisafirlerDAL();
        Misafir misafir = new Misafir();
        NesneDoldurma nesne = new NesneDoldurma();
        void ekrandakilerientityeal()
        {
            misafir.MisafirAd = txtAd.Text;
            misafir.MisafirSoyad = txtSoyad.Text;
            misafir.MisafirAd = txtAd.Text;
            misafir.MisafirSoyad = txtSoyad.Text;
            misafir.MisafirTcKimlik = txtTckimlik.Text;
            misafir.MisafirTelefon = txtTelefon.Text;
            misafir.MisafirEposta = txtEposta.Text;
            misafir.MisafirPasaportNo = txtPasaportno.Text;
            misafir.MisafirAdres = txtAdres.Text;
            misafir.MisafirAciklama = txtAciklama.Text;
            misafir.UlkeId = Convert.ToInt32(cmbUlke.SelectedValue);
            misafir.IlId = Convert.ToInt32(Cmbil.SelectedValue);
            misafir.IlceId = Convert.ToInt32(cmbilce.SelectedValue);
            misafir.dilId = Convert.ToInt32(cmbdil.SelectedValue);
            misafir.CinsiyetId = Convert.ToInt32(CmbCinsiyet.SelectedValue);
            misafir.MisafirDogumTarihi = Convert.ToDateTime(dtpdogumtarihi.Value);

        }
        
        private void btnmisafirkaydet_Click(object sender, EventArgs e)
        {
            ekrandakilerientityeal();
            misafirdal.MisafirEkleme(misafir);
            nesne.listviewdoldur(lwMisafirler, "sp_Tummisafirler", null, "sp");
        }

        private void MisafirSorgu_Click(object sender, EventArgs e)
        {
            SqlParameter[] sorgu =
           {
                new SqlParameter
                { ParameterName="SorguTC",
                    Value=txttcyegoremisafir.Text
                }
            };
            nesne.listviewdoldur(lwMisafirler, "sp_MisafirSorgu", sorgu, "sp");

        }

        void comboilyukleme()
        { nesne.herhangibircombo(Cmbil, "select * from tbl_Il where UlkeId=" + cmbUlke.SelectedValue + "", "txt"); }
        void comboilceyukleme()
        { nesne.herhangibircombo(cmbilce, "select * from tbl_Ilce where IlId=" + Cmbil.SelectedValue + "", "txt"); }
        private void listView1_Click(object sender, EventArgs e)
        {
            txtAd.Text = lwMisafirler.SelectedItems[0].SubItems[1].Text;
            txtSoyad.Text = lwMisafirler.SelectedItems[0].SubItems[2].Text;
            txtTckimlik.Text = lwMisafirler.SelectedItems[0].SubItems[3].Text;
            dtpdogumtarihi.Value = Convert.ToDateTime(lwMisafirler.SelectedItems[0].SubItems[4].Text);
            txtEposta.Text = lwMisafirler.SelectedItems[0].SubItems[5].Text;
            txtTelefon.Text = lwMisafirler.SelectedItems[0].SubItems[6].Text;
            txtPasaportno.Text = lwMisafirler.SelectedItems[0].SubItems[7].Text;
            txtAdres.Text = lwMisafirler.SelectedItems[0].SubItems[8].Text;
            txtAciklama.Text = lwMisafirler.SelectedItems[0].SubItems[9].Text;
            nesne.ismeGoreComboSectirme(cmbUlke, lwMisafirler.SelectedItems[0].SubItems[10].Text);
            comboilyukleme();
            nesne.ismeGoreComboSectirme(Cmbil, lwMisafirler.SelectedItems[0].SubItems[11].Text);
            comboilceyukleme();
            nesne.ismeGoreComboSectirme(cmbilce, lwMisafirler.SelectedItems[0].SubItems[12].Text);
            nesne.ismeGoreComboSectirme(cmbdil, lwMisafirler.SelectedItems[0].SubItems[13].Text);
            nesne.ismeGoreComboSectirme(CmbCinsiyet, lwMisafirler.SelectedItems[0].SubItems[14].Text);
        }
        private void MisafirEkleForm_Load(object sender, EventArgs e)
        {
            nesne.herhangibircombo(cmbUlke, "select * from tbl_Ulke", "txt");
            nesne.herhangibircombo(cmbdil, "select * from tbl_Diller", "txxt");
            nesne.herhangibircombo(CmbCinsiyet, "select * from tbl_Cinsiyet", "txt");
            nesne.listviewdoldur(lwMisafirler, "sp_Tummisafirler", null, "sp");
        }

        private void cmbUlke_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboilyukleme();
        }

        private void Cmbil_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboilceyukleme();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nesne.listviewdoldur(lwMisafirler, "sp_Tummisafirler", null, "sp");
        }

        private void btnMisafirGuncelle_Click(object sender, EventArgs e)
        {
            if (lwMisafirler.SelectedItems.Count != 0)
            {
                ekrandakilerientityeal();
                misafir.MisafirId =Convert.ToInt32(lwMisafirler.SelectedItems[0].SubItems[0].Text);
                misafirdal.MisafirGuncelleme(misafir);
                nesne.listviewdoldur(lwMisafirler, "sp_Tummisafirler", null, "sp");
            }
            else
            {
                MessageBox.Show("Seçim Yapınız.");
            }
        }
    }
}
