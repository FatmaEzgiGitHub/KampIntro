using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string adi = " Engin";
            //int yas = 36;

            Kurs kurs1 = new Kurs();      //tip tanımladım kurs1 in tipi kurs demek.
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = " Engin Demirog";
            kurs1.IzlenmeOranı = 68;

            Kurs kurs2 = new Kurs();      //tip tanımladım kurs1 in tipi kurs demek.
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = " Kerem";
            kurs2.IzlenmeOranı = 64;

            Kurs kurs3 = new Kurs();      //tip tanımladım kurs1 in tipi kurs demek.
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = " Berkay";
            kurs3.IzlenmeOranı = 80;


            // Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in kurslar)// veri tipi Kurs ya
            {
                Console.WriteLine(kurs.KursAdi+ " : "+ kurs.Egitmen);
            }

        }

    }
    class Kurs // TİP Tanımladım.
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOranı { get; set; }
    }

}
