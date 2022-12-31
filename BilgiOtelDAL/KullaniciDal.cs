using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilgiOtel_Entity;
using BilgiOtelDAL;

namespace BilgiOtelDAL
{
    public class KullaniciDal
    {
        public int KullanıcıKaydet (Kullanici eklenecekkullanici,Personeller personel,Yetkiler yetki)
        {
            SqlParameter[] kullaniciParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="KullaniciTipiId",
                    Value = eklenecekkullanici.KullaniciTipiId
                },
                new SqlParameter
                {
                    ParameterName="KullaniciAd",
                    Value = eklenecekkullanici.KullaniciAd
                },
                new SqlParameter
                {
                    ParameterName="KullaniciParola",
                    Value = eklenecekkullanici.KullaniciParola
                },
                new SqlParameter
                {
                    ParameterName="KullaniciEposta",
                    Value = eklenecekkullanici.KullaniciEposta
                },
                new SqlParameter
                {
                    ParameterName="KullaniciKayıtTarihi",
                    Value = eklenecekkullanici.KullaniciKayıtTarihi
                },
                new SqlParameter
                {
                    ParameterName="KullaniciSonGirisTarihi",
                    Value = eklenecekkullanici.KullaniciSonGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName="PersonelId",
                    Value =personel.PersonelId
                },
                new SqlParameter
                {
                    ParameterName="YetkiId",
                    Value =yetki.YetkiId
                },

            };

            int etkilenenSatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_KullaniciYetkiKayıt", kullaniciParametreleri, "sp");

            return etkilenenSatir;
        }
    }
}
