using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BilgiOtelWebForm.Login
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGrisi_Click(object sender, EventArgs e)
        {
            if (TxtParola.Text != null && TxtKullaniciAdi.Text!= null)
            {


                SqlConnection baglanti = new SqlConnection("Server=.;Database=DB_Bilgi_Hotel;Trusted_Connection=True;");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM tbl_Kullanici AS k " +
                    "join tbl_KullaniciMusteri as km ON k.KullaniciId=km.KullaniciId " +
                    "where k.KullaniciAd='" + TxtKullaniciAdi.Text + "' and k.KullaniciParola='" + TxtParola.Text + "'", baglanti);

                object girisyapanid = komut.ExecuteScalar();
                if (girisyapanid != null)
                {
                    Session.Add("GirisYapanId", girisyapanid);
                    Response.Redirect("Home.aspx");
                    baglanti.Close();
                }
                else
                {
                    Label1.Text = "KullanıcıAdı Veya Parola Yanlış.";
                }
            }
            else
            {
                Label1.Text = "Alanları boş Bırakmayınız.";
            }
        }
    }
}