using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasıtKrediManager = new TasıtKrediManager();

            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //TasıtKrediManager tasıtKrediManager = new TasıtKrediManager();

            //interface'de o interface'i implement eden class'ın referans no'sunu tutabiliyor
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager , tasıtKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);


        }
    }
}
