using BilgiOtel_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class KampanyalarDAL
    {
        #region
        //ID ye göre Kampanya Getir (SELECT with ID)
        public Kampanyalar getKampanyalarwithID(int kampanyaID)
        {
            SqlParameter[] kampanyaParametreleri =
            {
                new SqlParameter {
                   ParameterName = "KampanyaId",
                   Value=kampanyaID

                },

            };


            SqlDataReader kampanyaRdr = BilgiOtelHelperSQL.myExecuteReader("??????", kampanyaParametreleri, "sp");

            Kampanyalar mykampanya = null;
            while (kampanyaRdr.Read())
            {
               mykampanya.KampanyaId = Convert.ToInt32(kampanyaRdr["kitapID"]);
               mykampanya.KampanyaBilgileri = kampanyaRdr["kitapAd"].ToString();
               mykampanya.KampanyaIndirimOran =Convert.ToInt32(kampanyaRdr["kitapBasimYili"]);
               mykampanya.KampanyaBaslangicZaman = Convert.ToDateTime(kampanyaRdr["yayineviID"]);
               mykampanya.KampanyaBitisTarihi = Convert.ToDateTime(kampanyaRdr["kitapFiyat"]);
               mykampanya.KampanyaTanim =kampanyaRdr["kitapSayfaSayisi"].ToString();
   
            }

            return mykampanya;

        }

        //Tüm Kampanyaları Getir (SELECT ALL)
        public DataTable getAllKampanyalar()
        {
            DataTable kampanyalartablosu = BilgiOtelHelperSQL.myexecuteReaderTable("select KampanyaId,KampanyaBilgileri,KampanyaIndirimOran,KampanyaBaslangicZaman,KampanyaBitisTarihi,KampanyaTanim from tbl_kampanyalar", null, "txt");
            return kampanyalartablosu;

        }

        public Kampanyalar TariheGoreKampanyaGetir(Kampanyalar kampanya)
        {
            SqlParameter[] parametre =
            {
                new SqlParameter
                {
                    ParameterName="OdaGirisTarihi",
                    Value=kampanya.KampanyaBaslangicZaman,
                }
            };

            SqlDataReader Kampanyalardr = BilgiOtelHelperSQL.myExecuteReader("sp_KampanyaSorgu", parametre, "sp");

            Kampanyalar myKampanya = new Kampanyalar();
            while (Kampanyalardr.Read())
            {
                myKampanya.KampanyaId = Convert.ToInt32(Kampanyalardr["KampanyaId"]);
                myKampanya.KampanyaBilgileri = Kampanyalardr["KampanyaBilgileri"].ToString();
                myKampanya.KampanyaIndirimOran = Convert.ToInt32(Kampanyalardr["KampanyaIndirimOran"].ToString());
                myKampanya.KampanyaBaslangicZaman = Convert.ToDateTime(Kampanyalardr["KampanyaBaslangicZaman"].ToString());
                myKampanya.KampanyaBitisTarihi = Convert.ToDateTime(Kampanyalardr["KampanyaBitisTarihi"].ToString());
                myKampanya.KampanyaTanim = Kampanyalardr["KampanyaTanim"].ToString();
            }
            Kampanyalardr.Close();
            return myKampanya;
        }
        #endregion

        //Kampanya Kaydet
        public int insertKampanyalar(Kampanyalar eklenecekkampanya)
        {
            SqlParameter[] kampanyaParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="KampanyaId",
                    Value = eklenecekkampanya.KampanyaId
                },
                new SqlParameter
                {
                    ParameterName="KampanyaBilgileri",
                    Value = eklenecekkampanya.KampanyaBilgileri
                },
                new SqlParameter
                {
                    ParameterName="KampanyaIndirimOran",
                    Value = eklenecekkampanya.KampanyaIndirimOran
                },
                new SqlParameter
                {
                    ParameterName="KampanyaBaslangicZaman",
                    Value = eklenecekkampanya.KampanyaBaslangicZaman
                },
                new SqlParameter
                {
                    ParameterName="KampanyaBitisTarihi",
                    Value = eklenecekkampanya.KampanyaBitisTarihi
                },
                new SqlParameter
                {
                    ParameterName="KampanyaTanim",
                    Value = eklenecekkampanya.KampanyaTanim
                }
                

            };



            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_KampyanyaEkleme", kampanyaParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var Olan kampanya Verisini ID sine göre bul DEĞİŞTİR (UPDATE)
        public int updateKampanyalar(Kampanyalar duzenlenecekkampanya)
        {
            SqlParameter[] kitaplarParametreleri =
            {
                new SqlParameter {
                   ParameterName = "KampanyaId ",
                   Value=duzenlenecekkampanya.KampanyaId

                },
                new SqlParameter
                {
                    ParameterName="KampanyaBilgileri",
                    Value = duzenlenecekkampanya.KampanyaBilgileri
                },
                new SqlParameter
                {
                    ParameterName="KampanyaIndirimOran",
                    Value = duzenlenecekkampanya.KampanyaIndirimOran
                },
                new SqlParameter
                {
                    ParameterName="KampanyaBaslangicZaman",
                    Value = duzenlenecekkampanya.KampanyaBaslangicZaman
                },
                new SqlParameter
                {
                    ParameterName="KampanyaBitisTarihi",
                    Value = duzenlenecekkampanya.KampanyaBitisTarihi
                },
                new SqlParameter
                {
                    ParameterName="KampanyaTanim",
                    Value = duzenlenecekkampanya.KampanyaTanim
                }

            };

            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_KampanyaGuncelleme", kitaplarParametreleri, "sp");

            return etkilenenSatir;
        }

        //Var olan Kitap Verisini ID sine göre SİL (DELETE)
        public int deleteKampanyalar(Kampanyalar silinecekkampanya)
        {
            SqlParameter[] KampanyaParametreleri =
            {
                new SqlParameter {
                   ParameterName = "KampanyaId",
                   Value=silinecekkampanya.KampanyaId
                }
            };

            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_KampanyaSilme", KampanyaParametreleri, "sp");

            return etkilenenSatir;

        }


    }
}
