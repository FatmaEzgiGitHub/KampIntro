using System;

namespace ClassMySelf
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Satılık Araba İlanına Hoş Geldiniz");
            Console.WriteLine("Ürün" +" : "+ "Son Saat/Hafta/Ay" +" : "+ "Kişi Tarafından İncelendi");
            Platform group1 = new Platform();
            group1.FiyatiDusenler = "Mercedes";
            group1.SonZaman = "48 saat";
            group1.KacKisiİnceledi = 15 ;

            Platform group2 = new Platform();
            group2.FiyatiDusenler = "BMW";
            group2.SonZaman = "2 Hafta";
            group2.KacKisiİnceledi = 20;

            Platform group3 = new Platform();
            group3.FiyatiDusenler = "Bugatti";
            group3.SonZaman = "1 Ay";
            group3.KacKisiİnceledi = 5;

            Platform[] platformdakiler = new Platform[] { group1, group2, group3 };

            //foreach (Platform   platform in platformdakiler)
            //{
            //    Console.WriteLine( platform.FiyatiDusenler+ " : " + platform.SonZaman+ " : "+ platform.KacKisiİnceledi );
            //}

            // int  i;

            //for (i = 0; i < platformdakiler.Length; i++)
            //{
            //    Console.WriteLine(platformdakiler[i].FiyatiDusenler + " " + platformdakiler[i].SonZaman + " " + platformdakiler[i].KacKisiİnceledi);
            //}

            int index = 0;

            while (index<3)
            {
                Console.WriteLine(platformdakiler[index].FiyatiDusenler + " " + platformdakiler[index].SonZaman + " " + platformdakiler[index].KacKisiİnceledi);
                index = index + 1;
            }

        }
    }


    }
        class Platform
        {
            public string FiyatiDusenler { get; set; }
            public string SonZaman { get; set; }
            public int KacKisiİnceledi { get; set; }
         

        }
    
