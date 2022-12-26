using BilgiOtel_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class MusterilerDAL
    {
        // Kurumsal Musteri Ekleme
        public int KurumsalMusteriEkleme(Musteri EklenecekKurumsalMusteri,int EkleyenPersonelID)
        {

            SqlParameter[] Kurumsalmusteriparametreleri =
            {
                new SqlParameter
                {
                 ParameterName= "MusteriAd",
                 Value=EklenecekKurumsalMusteri.MusteriAd

                },
                new SqlParameter
                {
                ParameterName= "MusteriSoyad",
                Value=EklenecekKurumsalMusteri.MusteriSoyad

                },
                new SqlParameter
                {
                 ParameterName="MusteriPasaportNo",
                 Value=EklenecekKurumsalMusteri.MusteriPasaportNo
                },
                new SqlParameter
                {
                    ParameterName="MusteriUnvan",
                    Value=EklenecekKurumsalMusteri.MusteriUnvan
                },
                new SqlParameter
                {
                    ParameterName="MusteriYetkiliAdSoyad",
                    Value=EklenecekKurumsalMusteri.MusteriYetkiliAdSoyad
                },
                new SqlParameter
                {
                    ParameterName="MusteriVergiNo",
                    Value=EklenecekKurumsalMusteri.MusteriVergiNo
                },
                new SqlParameter
                {
                    ParameterName="MusteriVergiDairesi",
                    Value=EklenecekKurumsalMusteri.MusteriVergiDairesi
                },
                new SqlParameter
                {
                    ParameterName="MusteriTelefon",
                    Value=EklenecekKurumsalMusteri.MusteriTelefon
                },
                new SqlParameter
                {
                    ParameterName="MusteriPosta",
                    Value=EklenecekKurumsalMusteri.MusteriPosta
                },
                new SqlParameter
                {
                    ParameterName="MusteriAdres",
                    Value=EklenecekKurumsalMusteri.MusteriAdres
                },
                new SqlParameter
                {
                    ParameterName="IlID",
                    Value=EklenecekKurumsalMusteri.IlID
                },
                new SqlParameter
                {
                    ParameterName="IlceID",
                    Value=EklenecekKurumsalMusteri.IlceID
                },
                new SqlParameter
                {
                    ParameterName="UlkeID",
                    Value=EklenecekKurumsalMusteri.UlkeID
                },
                new SqlParameter
                {
                    ParameterName="MusteriAciklama",
                    Value=EklenecekKurumsalMusteri.MusteriAciklama
                },
                new SqlParameter
                {
                    ParameterName="MusteriKurumsalOK",
                    Value=EklenecekKurumsalMusteri.MusteriKurumsalOK
                },
                new SqlParameter
                {
                    ParameterName="DilID",
                    Value=EklenecekKurumsalMusteri.DilID
                },
                new SqlParameter
                {
                    ParameterName="PersonelID",
                    Value=EkleyenPersonelID
                }
            };

          int eklemedonus =  BilgiOtelHelperSQL.myExecuteNonQuery("sp_KurumsalMusteriEkleme", Kurumsalmusteriparametreleri, "sp");

            return eklemedonus;

        }
        // Bireysel Musteri Ekleme
        public int BireyselMusteriEkleme(Misafir EklenecekBireyselMusteri,int EkleyenPersonelID)
        {
            SqlParameter[] bireyselmusteriparametreleri =
            {
                new SqlParameter
                {
                 ParameterName= "MusteriAd",
                 Value=EklenecekBireyselMusteri.MisafirAd

                },
                new SqlParameter
                {
                ParameterName= "MusteriSoyad",
                Value=EklenecekBireyselMusteri.MisafirSoyad

                },
                new SqlParameter
                {
                 ParameterName="MusteriTCKimlik",
                 Value=EklenecekBireyselMusteri.MisafirTcKimlik
                },
                new SqlParameter
                {
                    ParameterName="MusteriPasaportNo",
                    Value=EklenecekBireyselMusteri.MisafirPasaportNo
                },
                new SqlParameter
                {
                    ParameterName="MisafirDogumTarihi",
                    Value=EklenecekBireyselMusteri.MisafirDogumTarihi
                },
                new SqlParameter
                {
                    ParameterName="MusteriTelefon",
                    Value=EklenecekBireyselMusteri.MisafirTelefon
                },
                new SqlParameter
                {
                    ParameterName="MusteriPosta",
                    Value=EklenecekBireyselMusteri.MisafirEposta
                },
                new SqlParameter
                {
                    ParameterName="MusteriAdres",
                    Value=EklenecekBireyselMusteri.MisafirAdres
                },
                new SqlParameter
                {
                    ParameterName="IlID",
                    Value=EklenecekBireyselMusteri.IlId
                },
                new SqlParameter
                {
                    ParameterName="IlceID",
                    Value=EklenecekBireyselMusteri.IlceId
                },
                new SqlParameter
                {
                    ParameterName="UlkeID",
                    Value=EklenecekBireyselMusteri.UlkeId
                },
                new SqlParameter
                {
                    ParameterName="MusteriAciklama",
                    Value=EklenecekBireyselMusteri.MisafirAciklama
                },
                new SqlParameter
                {
                    ParameterName="DilID",
                    Value=EklenecekBireyselMusteri.dilId
                },
                new SqlParameter 
                {
                    ParameterName="CinsiyetId",
                    Value=EklenecekBireyselMusteri.CinsiyetId
                },
                new SqlParameter
                {
                    ParameterName="PersonelID",
                    Value=EkleyenPersonelID
                }
            };

            int eklemedonus = BilgiOtelHelperSQL.myExecuteNonQuery("sp_BireyselMusteriEkleme", bireyselmusteriparametreleri, "sp");

            return eklemedonus;

        }
        //Kurumsal Musteri Guncelleme
        public int KurumsalMusteriGuncelleme(Musteri GuncellenecekKurumsalMusteri)
        {
            SqlParameter[] GuncellenecekKurumsalMusteriparametreleri =
            {
                new SqlParameter
                {
                    ParameterName="MusteriID",
                    Value=GuncellenecekKurumsalMusteri.MusteriID
                },
                new SqlParameter
                {
                 ParameterName= "MusteriAd",
                 Value=GuncellenecekKurumsalMusteri.MusteriAd

                },
                new SqlParameter
                {
                ParameterName= "MusteriSoyad",
                Value=GuncellenecekKurumsalMusteri.MusteriSoyad

                },
                new SqlParameter
                {
                 ParameterName="MusteriPasaportNo",
                 Value=GuncellenecekKurumsalMusteri.MusteriPasaportNo
                },
                new SqlParameter
                {
                    ParameterName="MusteriUnvan",
                    Value=GuncellenecekKurumsalMusteri.MusteriUnvan
                },
                new SqlParameter
                {
                    ParameterName="MusteriYetkiliAdSoyad",
                    Value=GuncellenecekKurumsalMusteri.MusteriYetkiliAdSoyad
                },
                new SqlParameter
                {
                    ParameterName="MusteriVergiNo",
                    Value=GuncellenecekKurumsalMusteri.MusteriVergiNo
                },
                new SqlParameter
                {
                    ParameterName="MusteriVergiDairesi",
                    Value=GuncellenecekKurumsalMusteri.MusteriVergiDairesi
                },
                new SqlParameter
                {
                    ParameterName="MusteriTelefon",
                    Value=GuncellenecekKurumsalMusteri.MusteriTelefon
                },
                new SqlParameter
                {
                    ParameterName="MusteriPosta",
                    Value=GuncellenecekKurumsalMusteri.MusteriPosta
                },
                new SqlParameter
                {
                    ParameterName="MusteriAdres",
                    Value=GuncellenecekKurumsalMusteri.MusteriAdres
                },
                new SqlParameter
                {
                    ParameterName="IlID",
                    Value=GuncellenecekKurumsalMusteri.IlID
                },
                new SqlParameter
                {
                    ParameterName="IlceID",
                    Value=GuncellenecekKurumsalMusteri.IlceID
                },
                new SqlParameter
                {
                    ParameterName="UlkeID",
                    Value=GuncellenecekKurumsalMusteri.UlkeID
                },
                new SqlParameter
                {
                    ParameterName="MusteriAciklama",
                    Value=GuncellenecekKurumsalMusteri.MusteriAciklama
                },
                new SqlParameter
                {
                    ParameterName="MusteriKurumsalOK",
                    Value=GuncellenecekKurumsalMusteri.MusteriKurumsalOK
                },
                new SqlParameter
                {
                    ParameterName="DilID",
                    Value=GuncellenecekKurumsalMusteri.DilID
                }
            };

            int GuncellemeDonus = BilgiOtelHelperSQL.myExecuteNonQuery("sp_KurumsalMusteriGuncelleme", GuncellenecekKurumsalMusteriparametreleri, "sp");
            return GuncellemeDonus;
        }
        // Bireysel Musteri Guncelleme
        public int BireyselMusteriGuncelleme(Misafir GuncellenecekMusteri)
        {
            SqlParameter[] Guncellenecekbireyselmusteriparametreleri =
            {
                new SqlParameter
                {
                    ParameterName="MusteriID",
                    Value=GuncellenecekMusteri.MisafirId
                },
                new SqlParameter
                {
                 ParameterName= "MusteriAd",
                 Value=GuncellenecekMusteri.MisafirAd

                },
                new SqlParameter
                {
                ParameterName= "MusteriSoyad",
                Value=GuncellenecekMusteri.MisafirSoyad

                },
                new SqlParameter
                {
                 ParameterName="MusteriTCKimlik",
                 Value=GuncellenecekMusteri.MisafirTcKimlik
                },
                new SqlParameter
                {
                    ParameterName="MusteriPasaportNo",
                    Value=GuncellenecekMusteri.MisafirPasaportNo
                },
                new SqlParameter
                {
                    ParameterName="MisafirDogumTarihi",
                    Value=GuncellenecekMusteri.MisafirDogumTarihi
                },
                new SqlParameter
                {
                    ParameterName="MusteriTelefon",
                    Value=GuncellenecekMusteri.MisafirTelefon
                },
                new SqlParameter
                {
                    ParameterName="MusteriPosta",
                    Value=GuncellenecekMusteri.MisafirEposta
                },
                new SqlParameter
                {
                    ParameterName="MusteriAdres",
                    Value=GuncellenecekMusteri.MisafirAdres
                },
                new SqlParameter
                {
                    ParameterName="IlID",
                    Value=GuncellenecekMusteri.IlId
                },
                new SqlParameter
                {
                    ParameterName="IlceID",
                    Value=GuncellenecekMusteri.IlceId
                },
                new SqlParameter
                {
                    ParameterName="UlkeID",
                    Value=GuncellenecekMusteri.UlkeId
                },
                new SqlParameter
                {
                    ParameterName="MusteriAciklama",
                    Value=GuncellenecekMusteri.MisafirAciklama
                },
                new SqlParameter
                {
                    ParameterName="CinsiyetId",
                    Value=GuncellenecekMusteri.CinsiyetId
                },
                 new SqlParameter
                {
                    ParameterName="DilID",
                    Value=GuncellenecekMusteri.dilId
                }
            };

            int eklemedonus = BilgiOtelHelperSQL.myExecuteNonQuery("sp_BireyselMusteriGuncelleme", Guncellenecekbireyselmusteriparametreleri, "sp");

            return eklemedonus;

        }



     /*   public DataTable MusteriGetirTcveyaVergiNoGore(SqlParameter[] parametre)
        {
            



           // return;
        }*/
    }
}
