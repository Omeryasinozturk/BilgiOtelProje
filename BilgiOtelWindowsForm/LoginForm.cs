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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnkapatma_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtkullaniciadi_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.BackColor=Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            txtparola.BackColor=SystemColors.Control;
        }

        private void txtparola_Click(object sender, EventArgs e)
        {
            txtparola.BackColor = Color.White;
            panel4.BackColor=Color.White;
            txtkullaniciadi.BackColor = SystemColors.Control;
            panel3.BackColor=SystemColors.Control;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            txtparola.UseSystemPasswordChar = true;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtparola.UseSystemPasswordChar=false;
        }

        private void txtkullaniciadi_Enter(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text=="KullanıcıAdı")
            {
                txtkullaniciadi.Text = "";
            }
        }

        private void txtkullaniciadi_Leave(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "")
            {
                txtkullaniciadi.Text = "KullanıcıAdı";
            }
        }

        private void txtparola_Enter(object sender, EventArgs e)
        {
            if (txtparola.Text=="Parola")
            {
                txtparola.Text = "";
                txtparola.UseSystemPasswordChar=true;
            }
        }

        private void txtparola_Leave(object sender, EventArgs e)
        {
            if (txtparola.Text == "")
            {
                txtparola.Text = "Parola";
                txtparola.UseSystemPasswordChar = false;
            }

        }

        private void btngiris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "KullanıcıAdı" || txtparola.Text == "Parola")
            {
                MessageBox.Show("Kullanıcıadı veya Parola Boş geçilemez!");
            }
            else
            {
               int a= GlobalGirisClass.Giris(txtkullaniciadi.Text, txtparola.Text);
                if (a==1)
                {
                    AnasayfaForm anasayfa = new AnasayfaForm();
                    anasayfa.Show();
                    this.Hide();
                    MessageBox.Show("Giriş basarılı!");
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız!");
                }
            }
        }
    }
}
