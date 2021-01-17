using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bu kodun Java'da karşılığı: String (s büyük harf) ve console.writeLine yerine ystem.out.println()

            string kurs1 = "Yazılım Geliştirici Yetiştime Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array=dizi 

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştime Kampı" ,
                "Programlamaya başlangıç için temel kurs" ,"Java","python","C++"};


            //donguler=birbirlerine benzeyen işleri tekrar etmek için kullanılır.

            //for (int i = 0; i <kurslar.Length; i++)// i++ or i=i+1 or i+=1
            //{
            //    Console.WriteLine(kurslar[i]);
            //}


            foreach (string X in kurslar)// dizi temelli yapıları döndürür.
            {
                Console.WriteLine(X);
            } 

            Console.WriteLine("Sayfa Sonu");
            Console.ReadLine();
        }

    }
}
