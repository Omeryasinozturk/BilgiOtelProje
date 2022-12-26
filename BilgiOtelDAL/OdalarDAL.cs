﻿using BilgiOtel_Entity;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class OdalarDAL
    {

        //OdaID ye göre Oda Getir (SELECT with ID)(SATIS EKRANINDA KULLANILIYOR)
        public Odalar IdGoreOdaBilgileriGetirme(string OdaID)
        {
            SqlParameter[] odaparametreleri =
            {
                new SqlParameter 
                {
                   ParameterName = "OdaId",
                   Value=OdaID
                },
            };

            SqlDataReader Odard = BilgiOtelHelperSQL.myExecuteReader("sp_Odaozellikgetirme", odaparametreleri, "sp");
            Odalar myoda = new Odalar();
            while (Odard.Read())
            {
                myoda.OdaId = Convert.ToInt32(Odard["OdaId"].ToString());
                myoda.OdaTipiId =Convert.ToInt32(Odard["OdaTipiId"].ToString());
                myoda.OdaFiyat = Convert.ToDecimal(Odard["OdaFiyat"].ToString());
                myoda.OdaYatakTipi = Convert.ToString(Odard["OdaYatakTipi"].ToString());
                myoda.OdaMiniBarOk = Convert.ToBoolean(Odard["OdaMiniBarOk"].ToString());
                myoda.OdaKlimaOk =Convert.ToBoolean( Odard["OdaKlimaOk"].ToString());
                myoda.OdaKurutmaOk = Convert.ToBoolean(Odard["OdaKurutmaOk"].ToString());
                myoda.OdaWifiOk = Convert.ToBoolean(Odard["OdaWifiOk"].ToString());
                myoda.OdaKasaOk = Convert.ToBoolean(Odard["OdaKasaOk"].ToString());
                myoda.OdaBalkonOk = Convert.ToBoolean(Odard["OdaBalkonOk"].ToString());
                myoda.OdaTvOk = Convert.ToBoolean(Odard["OdaTvOk"].ToString());
                myoda.OdaAciklama = Odard["OdaAciklama"].ToString();
                myoda.OdaEbatBoyut = Odard["OdaEbatBoyut"].ToString();
                myoda.OdaNo = Odard["OdaNo"].ToString();
                myoda.OdaKat = Convert.ToInt32(Odard["OdaKat"].ToString());
                myoda.OdaKisiSayisi = Convert.ToInt32(Odard["OdaKisiSayisi"].ToString().FirstOrDefault());
            }
            return myoda;
        }

        #region kontrol et
        //Tüm Odaları Getir (SELECT ALL)
        public Kampanyalar getKitaplarAll()
        {
            SqlDataReader Kampanyalardr = BilgiOtelHelperSQL.myExecuteReader("?????????????", null, "sp");

            Kampanyalar myKampanya = null;
            while (Kampanyalardr.Read())
            {
                myKampanya.KampanyaId = Convert.ToInt32(Kampanyalardr["KampanyaId"]);
                myKampanya.KampanyaBilgileri = Kampanyalardr["KampanyaBilgileri"].ToString();
                myKampanya.KampanyaIndirimOran = Convert.ToInt32(Kampanyalardr["KampanyaIndirimOran"]);
                myKampanya.KampanyaBaslangicZaman = Convert.ToDateTime(Kampanyalardr["KampanyaBaslangicZaman"]);
                myKampanya.KampanyaBitisTarihi = Convert.ToDateTime(Kampanyalardr["KampanyaBitisTarihi"]);
                myKampanya.KampanyaTanim = Kampanyalardr["KampanyaTanim"].ToString();

            }
            return myKampanya;
        }

        //Yeni Oda Verisi gir (INSERT)
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



            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("????????", kampanyaParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var Olan Oda Verisini ID sine göre bul DEĞİŞTİR (UPDATE)
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

            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("??????????", kitaplarParametreleri, "sp");

            return etkilenenSatir;
        }

        //Var olan Oda Verisini ID sine göre SİL (DELETE)
        public int deleteKampanyalar(Kampanyalar silinecekkampanya)
        {
            SqlParameter[] KampanyaParametreleri =
            {
                new SqlParameter {
                   ParameterName = "KampanyaId",
                   Value=silinecekkampanya.KampanyaId

                }


            };

            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("???????????", KampanyaParametreleri, "sp");

            return etkilenenSatir;

        }

        #endregion



    }
}
