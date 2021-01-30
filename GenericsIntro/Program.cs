using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();//BİR CLASS'I BUŞEKİLDE OLUŞTURUP VE REFERANS ALIYORDUK.
            isimler.Add("Engin");



            Console.WriteLine("Hello World!");


        }
    }
}
