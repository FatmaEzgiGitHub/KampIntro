using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            // string[] meyveler = new string[] {"elma","karpuz"};


            Urun urun1 = new Urun();//Class
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)//urunler dizisi içinden her bir elemanı tek tek gez, foreach ürün sayısı kadar döner.burada 2 kez.
                                          //ilk Urun=veri tipidir.diğer urun=x 


            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------------------");

            }

            Console.WriteLine("-------------Methods------------------");
            //instance-örnek
            //encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);


            //sepetManager.Ekle2("Armut", "Yeşil armut", 12, 5);
            //sepetManager.Ekle2("elma", "yeşil elma", 15, 6);
            //sepetManager.Ekle2("karpuz", "diyarbakır karpuzu", 20, 9);
        }
    }
}

