
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
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

