create proc sp_PersonelEkleme
(                     @PersonelAd nvarchar(150)
                     ,@PersonelSoyad nvarchar(150)
                     ,@PersonelTcKimlik nvarchar(15)
                     ,@PersonelDogumTarihi datetime
                     ,@PersonelUyrukId int
                     ,@PersonelEposta nvarchar(250)
                     ,@PersonelTelefon nvarchar(20)
                     ,@PersonelPasaportNo nvarchar(20)
                     ,@CinsiyetId      int
                     ,@PersonelIseGirisTarihi datetime
                     ,@PersonelIstenCikisTarihi datetime
                     ,@PersonelSaatlikUcret decimal(8,2)
                     ,@PersonelMaas decimal(8,2)
                     ,@PersonelSicilNo nvarchar(50)
                     ,@GorevId int
                     ,@PersonelKategoriID int
                     ,@PersonelEngelDurumu bit
                     ,@PersonelHesKodu nvarchar(20)
                     ,@IlId int
                     ,@IlceId int
                     ,@UlkeId int
                     ,@PersonelAdres nvarchar(250)
                     ,@PersonelAcilDurumKisiAd nvarchar(150)
                     ,@PersonelAcilDurumKisiTelefon nvarchar(20)
                     ,@ResimId  int
)
as
BEGIN
INSERT INTO [dbo].[tbl_Personel]
           ([PersonelAd]
           ,[PersonelSoyad]
           ,[PersonelTcKimlik]
           ,[PersonelDogumTarihi]
           ,[PersonelUyrukId]
           ,[PersonelEposta]
           ,[PersonelTelefon]
           ,[PersonelPasaportNo]
           ,[CinsiyetId]
           ,[PersonelIseGirisTarihi]
           ,[PersonelIstenCikisTarihi]
           ,[PersonelSaatlikUcret]
           ,[PersonelMaas]
           ,[PersonelSicilNo]
           ,[GorevId]
           ,[PersonelKategoriID]
           ,[PersonelEngelDurumu]
           ,[PersonelHesKodu]
           ,[IlId]
           ,[IlceId]
           ,[UlkeId]
           ,[PersonelAdres]
           ,[PersonelAcilDurumKisiAd]
           ,[PersonelAcilDurumKisiTelefon]
           ,[ResimId])
     VALUES
           (@PersonelAd
           ,@PersonelSoyad
           ,@PersonelTcKimlik
           ,@PersonelDogumTarihi
           ,@PersonelUyrukId
           ,@PersonelEposta
           ,@PersonelTelefon
           ,@PersonelPasaportNo
           ,@CinsiyetId
           ,@PersonelIseGirisTarihi
           ,@PersonelIstenCikisTarihi
           ,@PersonelSaatlikUcret
           ,@PersonelMaas
           ,@PersonelSicilNo
           ,@GorevId
           ,@PersonelKategoriID
           ,@PersonelEngelDurumu
           ,@PersonelHesKodu
           ,@IlId
           ,@IlceId
           ,@UlkeId
           ,@PersonelAdres
           ,@PersonelAcilDurumKisiAd
           ,@PersonelAcilDurumKisiTelefon
           ,@ResimId
		   )
END


