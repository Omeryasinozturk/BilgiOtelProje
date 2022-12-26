using BilgiOtel_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiOtelDAL
{
    public class PersonellerDAL
    {
        //Crud op

        // Personel Ekleme
        public int PersonelEkleme(Personeller eklenecekpersonel)
        {
            SqlParameter[] personelparametreleri =
            {
                new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=eklenecekpersonel.PersonelId
                },
                new SqlParameter
                {
                    ParameterName= "PersonelAd",
                    Value=eklenecekpersonel.PersonelAd
                },
                new SqlParameter
                {
                    ParameterName= "PersonelSoyad",
                    Value=eklenecekpersonel.PersonelSoyad
                },
                new SqlParameter
                {
                    ParameterName= "PersonelTcKimlik",
                    Value=eklenecekpersonel.PersonelTcKimlik
                },
                new SqlParameter
                {
                    ParameterName= "PersonelDogumTarihi",
                    Value=eklenecekpersonel.PersonelDogumTarihi
                },
                new SqlParameter
                {
                    ParameterName= "PersonelUyrukId",

                    Value=eklenecekpersonel.PersonelUyrukId
                },
                new SqlParameter
                {
                    ParameterName= "PersonelEposta",
                    Value=eklenecekpersonel.PersonelEposta
                },
                new SqlParameter
                {
                    ParameterName= "PersonelTelefon",
                    Value=eklenecekpersonel.PersonelTelefon
                },
                new SqlParameter
                {
                    ParameterName= "PersonelPasaportNo",
                    Value=eklenecekpersonel.PersonelPasaportNo
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = eklenecekpersonel.CinsiyetId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelIseGirisTarihi",
                    Value = eklenecekpersonel.PersonelIseGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName = "PersonelIstenCikisTarihi",
                    Value = eklenecekpersonel.PersonelIstenCikisTarihi
                },
                new SqlParameter
                {
                    ParameterName = "PersonelSaatlikUcret",
                    Value = eklenecekpersonel.PersonelSaatlikUcret
                },
                new SqlParameter
                {
                    ParameterName = "PersonelMaas",
                    Value = eklenecekpersonel.PersonelMaas
                },
                new SqlParameter
                {
                    ParameterName = "PersonelSicilNo",
                    Value = eklenecekpersonel.PersonelSicilNo
                },
                new SqlParameter
                {
                    ParameterName = "GorevId",
                    Value = eklenecekpersonel.GorevId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelKategoriID",
                    Value = eklenecekpersonel.PersonelKategoriID
                },
                new SqlParameter
                {
                    ParameterName = "PersonelEngelDurumu",
                    Value = eklenecekpersonel.PersonelEngelDurumu
                },
                new SqlParameter
                {
                    ParameterName = "PersonelHesKodu",
                    Value = eklenecekpersonel.PersonelHesKodu
                },
                new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = eklenecekpersonel.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = eklenecekpersonel.IlceId
                },
                new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = eklenecekpersonel.UlkeId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelAdres",
                    Value = eklenecekpersonel.PersonelAdres
                },
                new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiAd",
                    Value=eklenecekpersonel.PersonelAcilDurumKisiAd
                },
                new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiTelefon",
                    Value=eklenecekpersonel.PersonelAcilDurumKisiTelefon
                },
                new SqlParameter
                {
                    ParameterName="ResimId",
                    Value=eklenecekpersonel.ResimId
                },
            };


            int eklenensatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_PersonelEkleme", personelparametreleri, "sp");


            return eklenensatir;
        }

        // Personel Güncelleme
        public int PersonelGuncelleme(Personeller guncellenececekpersonel)
        {
            SqlParameter[] Guncellenecekpersonelparametreleri =
            {
                new SqlParameter
                {
                    ParameterName= "PersonelId",
                    Value=guncellenececekpersonel.PersonelId
                },
                new SqlParameter
                {
                    ParameterName= "PersonelAd",
                    Value=guncellenececekpersonel.PersonelAd
                },
                new SqlParameter
                {
                    ParameterName= "PersonelSoyad",
                    Value=guncellenececekpersonel.PersonelSoyad
                },
                new SqlParameter
                {
                    ParameterName= "PersonelTcKimlik",
                    Value=guncellenececekpersonel.PersonelTcKimlik
                },
                new SqlParameter
                {
                    ParameterName= "PersonelDogumTarihi",
                    Value=guncellenececekpersonel.PersonelDogumTarihi
                },
                new SqlParameter
                {
                    ParameterName= "PersonelUyrukId",

                    Value=guncellenececekpersonel.PersonelUyrukId
                },
                new SqlParameter
                {
                    ParameterName= "PersonelEposta",
                    Value=guncellenececekpersonel.PersonelEposta
                },
                new SqlParameter
                {
                    ParameterName= "PersonelTelefon",
                    Value=guncellenececekpersonel.PersonelTelefon
                },
                new SqlParameter
                {
                    ParameterName= "PersonelPasaportNo",
                    Value=guncellenececekpersonel.PersonelPasaportNo
                },
                new SqlParameter
                {
                    ParameterName = "CinsiyetId",
                    Value = guncellenececekpersonel.CinsiyetId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelIseGirisTarihi",
                    Value = guncellenececekpersonel.PersonelIseGirisTarihi
                },
                new SqlParameter
                {
                    ParameterName = "PersonelIstenCikisTarihi",
                    Value = guncellenececekpersonel.PersonelIstenCikisTarihi
                },
                new SqlParameter
                {
                    ParameterName = "PersonelSaatlikUcret",
                    Value = guncellenececekpersonel.PersonelSaatlikUcret
                },
                new SqlParameter
                {
                    ParameterName = "PersonelMaas",
                    Value = guncellenececekpersonel.PersonelMaas
                },
                new SqlParameter
                {
                    ParameterName = "PersonelSicilNo",
                    Value = guncellenececekpersonel.PersonelSicilNo
                },
                new SqlParameter
                {
                    ParameterName = "GorevId",
                    Value = guncellenececekpersonel.GorevId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelKategoriID",
                    Value = guncellenececekpersonel.PersonelKategoriID
                },
                new SqlParameter
                {
                    ParameterName = "PersonelEngelDurumu",
                    Value = guncellenececekpersonel.PersonelEngelDurumu
                },
                new SqlParameter
                {
                    ParameterName = "PersonelHesKodu",
                    Value = guncellenececekpersonel.PersonelHesKodu
                },
                new SqlParameter
                {
                    ParameterName = "IlId",
                    Value = guncellenececekpersonel.IlId
                },
                new SqlParameter
                {
                    ParameterName = "IlceId",
                    Value = guncellenececekpersonel.IlceId
                },
                new SqlParameter
                {
                    ParameterName = "UlkeId",
                    Value = guncellenececekpersonel.UlkeId
                },
                new SqlParameter
                {
                    ParameterName = "PersonelAdres",
                    Value = guncellenececekpersonel.PersonelAdres
                },
                new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiAd",
                    Value=guncellenececekpersonel.PersonelAcilDurumKisiAd
                },
                new SqlParameter
                {
                    ParameterName="PersonelAcilDurumKisiTelefon",
                    Value=guncellenececekpersonel.PersonelAcilDurumKisiTelefon
                },
                new SqlParameter
                {
                    ParameterName="ResimId",
                    Value=guncellenececekpersonel.ResimId
                },
            };

            int guncellenensatir = BilgiOtelHelperSQL.myExecuteNonQuery("sp_PersonelGuncelleme", Guncellenecekpersonelparametreleri, "sp");

            return guncellenensatir;
        }

        // TC göre PersonelGetirme
        public Personeller IdGorePersonelGetirme(int PersonelTC)
        {
            SqlParameter[] PersonelParametreleri =
            {
                new SqlParameter
                {
                    ParameterName="PersonelTcKimlik",
                    Value=PersonelTC
                }

            };
            SqlDataReader personellerdr = BilgiOtelHelperSQL.myExecuteReader("sp_IDGorePersonelGetirme", PersonelParametreleri, "sp");
            Personeller gelenyazar = null;
            while (personellerdr.Read())
            {
                gelenyazar.PersonelId = Convert.ToInt32(personellerdr[0]);
                gelenyazar.PersonelAd = personellerdr[1].ToString();
                gelenyazar.PersonelSoyad = personellerdr[2].ToString();
                gelenyazar.PersonelTcKimlik = personellerdr[3].ToString();
                gelenyazar.PersonelDogumTarihi = Convert.ToDateTime(personellerdr[4]);
                gelenyazar.PersonelUyrukId = Convert.ToInt32(personellerdr[5]);
                gelenyazar.PersonelEposta = personellerdr[6].ToString();
                gelenyazar.PersonelTelefon = personellerdr[7].ToString();
                gelenyazar.PersonelPasaportNo = personellerdr[8].ToString();
                gelenyazar.CinsiyetId = Convert.ToInt32(personellerdr[9]);
                gelenyazar.PersonelIseGirisTarihi = Convert.ToDateTime(personellerdr[10]);
                gelenyazar.PersonelIstenCikisTarihi = Convert.ToDateTime(personellerdr[11]);
                gelenyazar.PersonelSaatlikUcret = Convert.ToDecimal(personellerdr[12]);
                gelenyazar.PersonelMaas = Convert.ToDecimal(personellerdr[13]);
                gelenyazar.PersonelSicilNo = personellerdr[14].ToString();
                gelenyazar.GorevId = Convert.ToInt32(personellerdr[15]);
                gelenyazar.PersonelKategoriID = Convert.ToInt32(personellerdr[16]);
                gelenyazar.PersonelEngelDurumu = Convert.ToBoolean(personellerdr[17]);
                gelenyazar.PersonelHesKodu = personellerdr[18].ToString();
                gelenyazar.IlId = Convert.ToInt32(personellerdr[19]);
                gelenyazar.IlceId = Convert.ToInt32(personellerdr[20]);
                gelenyazar.UlkeId = Convert.ToInt32(personellerdr[21]);
                gelenyazar.PersonelAdres = personellerdr[22].ToString();
                gelenyazar.PersonelAcilDurumKisiAd = personellerdr[23].ToString();
                gelenyazar.PersonelAcilDurumKisiTelefon = personellerdr[24].ToString();
                gelenyazar.ResimId = Convert.ToInt32(personellerdr[25]);

            }
            return gelenyazar;
        }

        // Tüm Personelleri Getir
        public List<Personeller> TumPersonelleriGetir()
        {

            SqlDataReader personeldr = BilgiOtelHelperSQL.myExecuteReader("sp_TumMusterilerinListesi",null,"sp");
            List<Personeller> tumpersoneller = new List<Personeller>();

            while (personeldr.Read())
            {
                Personeller mymusteri = new Personeller();
                mymusteri.PersonelId = Convert.ToInt32(personeldr[0]);
                mymusteri.PersonelAd = personeldr[1].ToString();
                mymusteri.PersonelSoyad = personeldr[2].ToString();
                mymusteri.PersonelTcKimlik = personeldr[3].ToString();
                mymusteri.PersonelDogumTarihi = Convert.ToDateTime(personeldr[4]);
                mymusteri.PersonelUyrukId = Convert.ToInt32(personeldr[5]);
                mymusteri.PersonelEposta = personeldr[6].ToString();
                mymusteri.PersonelTelefon = personeldr[7].ToString();
                mymusteri.PersonelPasaportNo = personeldr[8].ToString();
                mymusteri.CinsiyetId = Convert.ToInt32(personeldr[9]);
                mymusteri.PersonelIseGirisTarihi = Convert.ToDateTime(personeldr[10]);
                mymusteri.PersonelIstenCikisTarihi = Convert.ToDateTime(personeldr[11]);
                mymusteri.PersonelSaatlikUcret = Convert.ToDecimal(personeldr[12]);
                mymusteri.PersonelMaas = Convert.ToDecimal(personeldr[13]);
                mymusteri.PersonelSicilNo = personeldr[14].ToString();
                mymusteri.GorevId = Convert.ToInt32(personeldr[15]);
                mymusteri.PersonelKategoriID = Convert.ToInt32(personeldr[16]);
                mymusteri.PersonelEngelDurumu = Convert.ToBoolean(personeldr[17]);
                mymusteri.PersonelHesKodu = personeldr[18].ToString();
                mymusteri.IlId = Convert.ToInt32(personeldr[19]);
                mymusteri.IlceId = Convert.ToInt32(personeldr[20]);
                mymusteri.UlkeId = Convert.ToInt32(personeldr[21]);
                mymusteri.PersonelAdres = personeldr[22].ToString();
                mymusteri.PersonelAcilDurumKisiAd = personeldr[23].ToString();
                mymusteri.PersonelAcilDurumKisiTelefon = personeldr[24].ToString();
                mymusteri.ResimId = Convert.ToInt32(personeldr[25]);

                tumpersoneller.Add(mymusteri);
            }
            personeldr.Close();
            return tumpersoneller;

        }
    }
}
