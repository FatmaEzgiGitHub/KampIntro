﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class KonutKrediManager : IKrediManager
    {
        public void Hesapla()//interface implement ettik.
        {
            Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
        }
    }
}
