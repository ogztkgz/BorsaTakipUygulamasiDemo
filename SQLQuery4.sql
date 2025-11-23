CREATE TABLE musteriler (

musteriId int identity(1,1) NOT NULL PRIMARY KEY,
musteriAd varchar(30) NOT NULL ,
musteriSoyad varchar(30) NOT NULL ,
musteriTel char(11) ,
musteriMail varchar(30)

)

CREATE TABLE personel (

personelId int identity(1,1) NOT NULL PRIMARY KEY,
personelAd varchar(30) NOT NULL ,
personelSoyad varchar(30) NOT NULL ,
personelUnvan varchar(30)
)


Select * from personel
