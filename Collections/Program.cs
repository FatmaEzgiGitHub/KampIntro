﻿using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //    string[] isimler = new string[] {"engin","murat","kerem","halil" };
            //    Console.WriteLine(isimler[0]);
            //    Console.WriteLine(isimler[1]);
            //    Console.WriteLine(isimler[2]);
            //    Console.WriteLine(isimler[3]);
            //    isimler = new string[];//yeni referans aldın.eskileri unuttu.
            //    isimler[4] = "ilker";//dizileri genişletemiyoruz.genişletirsek eski elemanları kaybederiz.
            //ama koleksiyonlarda değerleri kaybetmemizi engelleyecek bir alt yapı var
            //    Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);//bşr önceki değerleri kaybetti.referansı değiştiği için.

            List<string> isimler2 = new List<string> { "engin", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
