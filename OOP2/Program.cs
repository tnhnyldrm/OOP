﻿
using OOP2;

GercekMusteri musteri1 = new GercekMusteri();
musteri1.MusteriNo = "12345";
musteri1.Adi = "engin";
musteri1.Soyadi = "demiroğ";
musteri1.TcNo = "12345678910";


TuzelMusteri musteri2 = new TuzelMusteri();
musteri2.Id = 2;
musteri2.MusteriNo = "54321";
musteri2.SirketAdi = "kodlama.io";
musteri2.VergiNo = "1234567890";

Musteri musteri3 = new GercekMusteri();
Musteri musteri4 = new TuzelMusteri();

MusteriManager musteriManager = new MusteriManager();
musteriManager.Ekle(musteri1);
musteriManager.Ekle(musteri2);