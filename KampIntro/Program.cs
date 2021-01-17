using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            // do not repeat yourself =kendini tekrarlama, değişkeni değer tutucuya(alias=takma isim) ata!


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.4;
            bool sistemeGirisYapmişMi = true;//gerçek hayatta bu true or false bir veri kaynağından gelir.
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu göster");

            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu göster");
            }
            else
            {
                Console.WriteLine("Değişmedi göster");
            }


            if (sistemeGirisYapmişMi == true) 
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);


            Console.ReadLine();
        }


    }
}
