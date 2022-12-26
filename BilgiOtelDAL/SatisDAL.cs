using BilgiOtel_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BilgiOtelDAL
{
    public class SatisDAL
    {

        #region OdaSatıs

        /// <summary>
        ///  Satış için gerekli parametreleri doldurun. Dönüş olarak size satış ıd gelecektir.
        /// </summary>
        public int OdaSatis(Satis satis,int personelID)
        {
            SqlParameter[] satisparametreleri =
            {
                new SqlParameter
                {
                    ParameterName="SatisOdaGirisTarihi",
                    Value=satis.SatisOdaGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName="SatisOdaCikisTarihi",
                    Value=satis.SatisOdaCikisTarihi
                },
                new SqlParameter
                {
                    ParameterName="OdaId",
                    Value=satis.OdaId
                },
                new SqlParameter
                {
                    ParameterName="SatisIndirim",
                    Value=satis.SatisIndirim
                },
                new SqlParameter
                {
                    ParameterName="OdaSatisTutar",
                    Value=satis.OdaSatisTutar
                },
                new SqlParameter
                {
                    ParameterName="OdaSatisOdemeTipiId",
                    Value=satis.OdaSatisOdemeTipiId
                },
                 new SqlParameter
                {
                    ParameterName="OdaKdvTutar",
                    Value=satis.OdaSatisKDV
                },
                 new SqlParameter
                {
                    ParameterName="SatisAktifMi",
                    Value=satis.SatisAktifMi
                },
                new SqlParameter {
                    ParameterName="PersonelID",
                    Value=personelID
                }

            };

            int donensatisID = (int)BilgiOtelHelperSQL.myExecuteScalar("sp_Satis", satisparametreleri, "sp");
            return donensatisID;

        }
        #endregion
        #region sonra bak kapatmak için yaptım
        public void OdaSatisAraTablo(Musteri musteri,Misafir misafir,Satis satis)
        {
            SqlParameter[] aratabloparametreleri =
            {
                new SqlParameter
                {
                    ParameterName="MusteriID",
                    Value=musteri.MusteriID
                },
                new SqlParameter
                {
                    ParameterName="MisafirID",
                    Value=misafir.MisafirId
                },
                new SqlParameter
                {
                    ParameterName="SatisID",
                    Value=satis.SatisId
                },
                new SqlParameter
                {
                    ParameterName="OdaID",
                    Value=satis.OdaId
                },
            };

            BilgiOtelHelperSQL.myExecuteNonQuery("sp_musterimisafirsatis", aratabloparametreleri, "sp");

        }

        public decimal OdaSatisTipKatsayiDondurme(int secilen)
        {
            SqlParameter[] secim =
            {
                new SqlParameter
                {
                    ParameterName="secim",
                    Value=secilen
                }
              
            };
             decimal donenoran=(decimal)BilgiOtelHelperSQL.myExecuteScalar("sp_odasatistipkatsayisecimegore",secim,"sp");


            return donenoran;
        }
        #endregion
        public List<string> OdaDurumlarıKontrol(Satis satis)
        { 
            List<string> odalistesi = new List<string>();
            SqlParameter[] tarihparametreleri =
            {
                new SqlParameter
                {
                    ParameterName="ilktarih",
                    Value=satis.SatisOdaGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName="ikincitarih",
                    Value=satis.SatisOdaCikisTarihi
                }
            };
          SqlDataReader dr =  BilgiOtelHelperSQL.myExecuteReader("sp_TarihlereGoreOdaSorgu", tarihparametreleri, "sp");
            while (dr.Read())
            {
                odalistesi.Add(dr[0].ToString());
            }
            return odalistesi;
            dr.Close();
        }


    }
}
