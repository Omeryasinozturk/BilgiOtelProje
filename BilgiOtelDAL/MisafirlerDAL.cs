using BilgiOtel_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class MisafirlerDAL
    {
        //Crud op

        // Misafir Ekleme++
        public int MisafirEkleme(Misafir eklenecekmisafir)
        {
            SqlParameter[] misafirparametreleri =
            {
                new SqlParameter
                {
                    ParameterName= "MisafirAd",
                    Value=eklenecekmisafir.MisafirAd
                },
                new SqlParameter
                {
                    ParameterName= "MisafirSoyad",
                    Value=eklenecekmisafir.MisafirSoyad
                },
                new SqlParameter
                {
                    ParameterName= "MisafirTcKimlik",
                    Value=eklenecekmisafir.MisafirTcKimlik
                },
                new SqlParameter
                {
                    ParameterName= "MisafirDogumTarihi",
                    Value=eklenecekmisafir.MisafirDogumTarihi
                },
                new SqlParameter
                {
                    ParameterName= "MisafirEposta",
                    Value=eklenecekmisafir.MisafirEposta
                },
                new SqlParameter
                {
                    ParameterName= "MisafirTelefon",
                    Value=eklenecekmisafir.MisafirTelefon
                },
                new SqlParameter
                {
                    ParameterName= "MisafirPasaportNo",
                    Value=eklenecekmisafir.MisafirPasaportNo
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = eklenecekmisafir.CinsiyetId
                },
                new SqlParameter
                {
                    ParameterName = "MisafirAdres",
                    Value = eklenecekmisafir.MisafirAdres
                },
                new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = eklenecekmisafir.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = eklenecekmisafir.IlceId
                },
                new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = eklenecekmisafir.UlkeId
                },
                new SqlParameter
                {
                    ParameterName= "MisafirAciklama",
                    Value=eklenecekmisafir.MisafirAciklama
                },
                new SqlParameter
                {
                    ParameterName= "dilId",
                    Value=eklenecekmisafir.dilId
                },
            };


            int eklenensatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_MisafirEkleme", misafirparametreleri, "sp");


            return eklenensatir;
        }

        // Misafir Güncelleme++
        public int MisafirGuncelleme(Misafir guncellenecekMisafir)
        {
            SqlParameter[] GuncellenecekMusteriparametreleri =
 {
                new SqlParameter
                {
                    ParameterName= "MisafirID",
                    Value=guncellenecekMisafir.MisafirId
                },
                new SqlParameter
                {
                    ParameterName= "MisafirAd",
                    Value=guncellenecekMisafir.MisafirAd
                },
                new SqlParameter
                {
                    ParameterName= "MisafirSoyad",
                    Value=guncellenecekMisafir.MisafirSoyad
                },
                new SqlParameter
                {
                    ParameterName= "MisafirTcKimlik",
                    Value=guncellenecekMisafir.MisafirTcKimlik
                },
                new SqlParameter
                {
                    ParameterName= "MisafirDogumTarihi",
                    Value=guncellenecekMisafir.MisafirDogumTarihi
                },
                new SqlParameter
                {
                    ParameterName= "MisafirEposta",
                    Value=guncellenecekMisafir.MisafirEposta
                },
                new SqlParameter
                {
                    ParameterName= "MisafirTelefon",
                    Value=guncellenecekMisafir.MisafirTelefon
                },
                new SqlParameter
                {
                    ParameterName= "MisafirPasaportNo",
                    Value=guncellenecekMisafir.MisafirPasaportNo
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = guncellenecekMisafir.CinsiyetId
                },
                new SqlParameter
                {
                    ParameterName = "MisafirAdres",
                    Value = guncellenecekMisafir.MisafirAdres
                },
                new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = guncellenecekMisafir.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = guncellenecekMisafir.IlceId
                },
                new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = guncellenecekMisafir.UlkeId
                },
                new SqlParameter
                {
                    ParameterName= "MisafirAciklama",
                    Value=guncellenecekMisafir.MisafirAciklama
                },
                new SqlParameter
                {
                    ParameterName= "dilId",
                    Value=guncellenecekMisafir.dilId
                },
            };

            int guncellenensatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_MisafirGuncelleme", GuncellenecekMusteriparametreleri, "sp");

            return guncellenensatir;
        }

        // TC göre Misafir Getirme
        public Misafir TCGoreMisafirGetirme(string MisafirTC)
        {
            SqlParameter[] MisafirParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="SorguTC",
                    Value=MisafirTC
                }

            };
            SqlDataReader misafirdr = BilgiOtelHelperSQL.myExecuteReader("sp_MisafirSorgu", MisafirParametreleri, "sp");
            Misafir gelenmisafir = new Misafir();
            while (misafirdr.Read())
            {

                gelenmisafir.MisafirId = Convert.ToInt32(misafirdr[0].ToString());
                gelenmisafir.MisafirAd = misafirdr[1].ToString();
                gelenmisafir.MisafirSoyad = misafirdr[2].ToString();
                gelenmisafir.MisafirTcKimlik = misafirdr[3].ToString();
                gelenmisafir.MisafirDogumTarihi = Convert.ToDateTime(misafirdr[4].ToString());
                gelenmisafir.MisafirEposta = misafirdr[5].ToString();
                gelenmisafir.MisafirTelefon = misafirdr[6].ToString();
                gelenmisafir.MisafirPasaportNo = misafirdr[7].ToString();
            //    gelenmisafir.CinsiyetId = Convert.ToInt32(misafirdr[14].ToString());
                gelenmisafir.MisafirAdres = misafirdr[8].ToString();
                //gelenmisafir.IlId = Convert.ToInt32(misafirdr[11].ToString());
                //gelenmisafir.IlceId = Convert.ToInt32(misafirdr[12].ToString());
                //gelenmisafir.UlkeId = Convert.ToInt32(misafirdr[10].ToString());
                //gelenmisafir.MisafirAciklama = misafirdr[9].ToString();
                //gelenmisafir.dilId = Convert.ToInt32(misafirdr[13].ToString());

            }
            return gelenmisafir;
            
        }

        // Tum Misafirleri Getir
        public List<Misafir> TumMisafirleriGetir()
        {

            SqlDataReader misafirdr = BilgiOtelHelperSQL.myExecuteReader("sp_TumMusterilerinListesi", null, "sp");
            List<Misafir> tumpersoneller = new List<Misafir>();

            while (misafirdr.Read())
            {
                Misafir mymisafir = new Misafir();
                mymisafir.MisafirId = Convert.ToInt32(misafirdr[0]);
                mymisafir.MisafirAd = misafirdr[1].ToString();
                mymisafir.MisafirSoyad = misafirdr[2].ToString();
                mymisafir.MisafirTcKimlik = misafirdr[3].ToString();
                mymisafir.MisafirDogumTarihi = Convert.ToDateTime(misafirdr[4]);
                mymisafir.MisafirUyrukId = Convert.ToInt32(misafirdr[5]);
                mymisafir.MisafirEposta = misafirdr[6].ToString();
                mymisafir.MisafirTelefon = misafirdr[7].ToString();
                mymisafir.MisafirPasaportNo = misafirdr[8].ToString();
                mymisafir.CinsiyetId = Convert.ToInt32(misafirdr[9]);
                mymisafir.MisafirAdres = misafirdr[10].ToString();
                mymisafir.IlId = Convert.ToInt32(misafirdr[11]);
                mymisafir.IlceId = Convert.ToInt32(misafirdr[12]);
                mymisafir.UlkeId = Convert.ToInt32(misafirdr[13]);
                mymisafir.MisafirAciklama = misafirdr[14].ToString();
                mymisafir.MisafirHesKod = misafirdr[15].ToString();
                mymisafir.dilId = Convert.ToInt32(misafirdr[16]);

                tumpersoneller.Add(mymisafir);
            }
            misafirdr.Close();
            return tumpersoneller;

        }

        // Misafir silme
        public int MisafirSilme(string MisafirTC)
        {
            SqlParameter[] silinecekmisafirparametre =
            {
                new SqlParameter
                {
                    ParameterName="MisafirTc",
                    Value=MisafirTC

                }

            };

            int etkilenensatir =BilgiOtelHelperSQL.myExecuteNonQuery("sp_MisafirSilme", silinecekmisafirparametre, "sp");

            return etkilenensatir;
        }
    }
}
