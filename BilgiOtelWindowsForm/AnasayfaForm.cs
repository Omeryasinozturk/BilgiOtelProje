using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiOtelWindowsForm
{
    public partial class AnasayfaForm : Form
    {
        public AnasayfaForm()
        {
            InitializeComponent();
        }
        void panelhareket(Control btn)
        {
            panel2.Top=btn.Top+115;
            panel2.Height=btn.Height;

        }
        void paneleformgetirme(Form frm)
        {
            Anapanel.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            Anapanel.Controls.Add(frm);
            //  frm.BringToFront();
            frm.Show();

        }

        private void AnasayfaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            Button b=(Button)sender;
            panelhareket(b);
            paneleformgetirme(new MusteriEkleForm());
        }

        private void btnMisafirEkle_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            panelhareket(b);
            paneleformgetirme(new MisafirEkleForm());
        }

        private void btnOdaSatis_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            panelhareket(b);
            paneleformgetirme(new OdaSatisForm());
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            panelhareket(b);
            //  paneleformgetirme(new RezervasyonForm());
        }

        private void btnOdadurum_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            panelhareket(b);
            paneleformgetirme(new OdaDuzenleme());
        }

        private void btnKampanyalar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            panelhareket(b);
            paneleformgetirme(new KampanyalarForm());
        }

        private void btnPersonelListesi_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            panelhareket(b);
            paneleformgetirme(new PersonelEklemeForm());
        }

        private void btnMuhasebe_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            panelhareket(b);
            //  paneleformgetirme(new MuhasebeForm());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label1.Text = dt.ToString("HH:mm:ss");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
