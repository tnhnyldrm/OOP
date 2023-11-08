using OOP;

Urun urun1 = new Urun();
urun1.Adi = "elma";
urun1.Fiyati = 15;
urun1.Aciklama = "amasya elması";

Urun urun2 = new Urun();
urun2.Adi = "elma";
urun2.Fiyati = 15;
urun2.Aciklama = "amasya elması";

Urun[] urunler = new Urun[] {urun1,urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyati);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("---------------------------");
}

Console.WriteLine("-------------Metotlar-------------");

//instance - örnek
//encapsulation

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("armut","yesil",12,9);
sepetManager.Ekle2("elma", "yesil elma", 12, 8);