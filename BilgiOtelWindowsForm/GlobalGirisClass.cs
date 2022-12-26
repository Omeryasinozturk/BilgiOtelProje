using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BilgiOtelDAL;

namespace BilgiOtelWindowsForm
{
    public static class GlobalGirisClass
    {
        public static int GirisYapanID { get; set; }
        public static int GirisYapanYetki { get; set; }
        public static string GirisYapanName { get; set; }
        

        public static int Giris(string @Kullanici, string @Parola)
        {
            int a=0;
            SqlParameter[] girisparametreleri =
            {
                new SqlParameter
                {
                    ParameterName = "Kullaniciad",
                    Value = Kullanici
                },
                new SqlParameter
                {
                    ParameterName= "kullaniciparola",
                    Value=Parola
                }

            };

            SqlDataReader dr = BilgiOtelHelperSQL.myExecuteReader("sp_KullaniciGirisKontrol", girisparametreleri, "sp");
            while (dr.Read())
            {
                if (Kullanici == dr[0].ToString() && Parola == dr[1].ToString())
                {
                    GirisYapanID = Convert.ToInt32(dr[2].ToString());
                    GirisYapanYetki = Convert.ToInt32(dr[3].ToString());
                    a = 1; 
                }
            }
           
            dr.Close();
           return a;
        }
    }
}
