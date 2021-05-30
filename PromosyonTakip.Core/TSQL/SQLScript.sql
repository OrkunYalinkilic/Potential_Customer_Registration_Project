create database PromosyonSepeti
use PromosyonSepeti

create table sistemMagaza
(
id int identity(1,1) primary key,
tanim nvarchar(100),
adres nvarchar(100),
yetkiliKisi nvarchar(100),
kullaniciAdi nvarchar(50) unique,
sifre nvarchar(50)
)

insert into sistemMagaza values('Sefaköy AVM Mağaza - 1','Sefaköy','Cengiz Atilla','cengizatilla','1')
insert into sistemMagaza values('Sefaköy AVM Mağaza - 2','Sefaköy','Hakan Atilla','hamzaatilla','1')
insert into sistemMagaza values('Bayrampaşa AVM Mağaza','Bayrampaşa','Murat Yılgın','muratyilgin','2')

select *from sistemMagaza

create table potansiyelMusteri(
id int identity(1,1) primary key,
tcKimlikNumara nvarchar(15),
isim nvarchar(50),
soyisim nvarchar(50),
dogumTarih datetime,
cinsiyet int,
meslek nvarchar(100),
emailAdres nvarchar(100),
emailBildirimOnay bit,
telefon nvarchar(15),
telefonBildirimOnay bit,
olusturmaTarihi datetime,
olusturmaMagaza int
)

select *from potansiyelMusteri

create table promosyonUrun
(
id int identity(1,1) primary key,
tanim nvarchar(100),
aciklama nvarchar(250),
gecerlilikTarihi datetime,
kullanimDurum bit -- kullanıldı mı?
)


insert into promosyonUrun values ('%10','indirim tüm mağazalarda geçerli','2020.04.01',0)
insert into promosyonUrun values ('%20','indirim tüm mağazalarda geçerli','2020.04.01',0)
insert into promosyonUrun values ('%30','indirim tüm mağazalarda geçerli','2020.04.01',0)
insert into promosyonUrun values ('%40','indirim tüm mağazalarda geçerli','2020.04.01',0)
insert into promosyonUrun values ('%50','indirim tüm mağazalarda geçerli','2020.04.01',0)
insert into promosyonUrun values ('%60','indirim tüm mağazalarda geçerli','2020.04.01',0)
insert into promosyonUrun values ('%70','indirim tüm mağazalarda geçerli','2020.04.01',0)

select top 42 *from promosyonUrun where kullanimDurum = 0 order by newid() -- farklı(Sırasız) 42 ürün getirir.

create table katilimciPromosyon 
( -- hangi müşteri hangi ürünü hangi mağazadan ne zaman almaya hak kazanmış onu göreceğim.
id int identity(1,1) primary key,
potansiyelMusteriID int,
promosyonUrunID int,
olusturmaTarihi datetime,
magazaID int
)

select *from katilimciPromosyon