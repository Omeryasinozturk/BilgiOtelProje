using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiOtel_Entity;

namespace BilgiOtelDAL
{
    public class ErkenRezervasyonDAL
    {
        //ErkenRez Kaydet
        public int insertErkenRez(ErkenRezervasyonindirim eklenecekerkenrez,int OdaSatistip)
        {
            SqlParameter[] ErkenRezParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="ErkenRezGunSayisi",
                    Value = eklenecekerkenrez.ErkenRezGunSayisi
                },
                new SqlParameter
                {
                    ParameterName="ErkenRezindirimOranı",
                    Value = eklenecekerkenrez.ErkenRezindirimOranı
                },
                new SqlParameter
                {
                    ParameterName="ErkenRezAciklama",
                    Value = eklenecekerkenrez.ErkenRezAciklama
                },
                new SqlParameter
                {
                    ParameterName="ErkenRezAktifMi",
                    Value = eklenecekerkenrez.ErkenRezAktifMi
                },
                new SqlParameter
                {
                    ParameterName="OdaSatisTipId",
                    Value = OdaSatistip
                }


            };



            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_erkenrezindirimkayıt", ErkenRezParametreleri, "sp");

            return etkilenenSatir;

        }

        //Var Olan ErkenREZ Verisini ID sine göre bul DEĞİŞTİR (UPDATE)
        public int updateErkenRez(ErkenRezervasyonindirim duzenlenecekerkenrez,int odasatistip)
        {
            SqlParameter[] erkenrezguncelleme =
            {
                new SqlParameter {
                   ParameterName = "ErkenRezGunSayisi ",
                   Value=duzenlenecekerkenrez.ErkenRezGunSayisi

                },
                new SqlParameter
                {
                    ParameterName="ErkenRezindirimOranı",
                    Value = duzenlenecekerkenrez.ErkenRezindirimOranı
                },
                new SqlParameter
                {
                    ParameterName="ErkenRezAciklama",
                    Value = duzenlenecekerkenrez.ErkenRezAciklama
                },
                new SqlParameter
                {
                    ParameterName="ErkenRezAktifMi",
                    Value = duzenlenecekerkenrez.ErkenRezAktifMi
                },
                new SqlParameter
                {
                    ParameterName="OdaSatisTipId",
                    Value = odasatistip
                },
                new SqlParameter
                {
                    ParameterName="ErkenRezindirimID",
                    Value = duzenlenecekerkenrez.ErkenRezindirimID
                },
               /* new SqlParameter
                {
                    ParameterName="EskiSatisTipId",
                    Value = 
                }*/
            };

            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_erkenrezupdate", erkenrezguncelleme, "sp");

            return etkilenenSatir;
        }

        //Var olan Kitap Verisini ID sine göre SİL (DELETE)
        public int deleteErkenRez(Kampanyalar silinecekkampanya)
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
