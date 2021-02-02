using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{ //interface kurallar içerir.

    interface IKrediManager //class idi interface yaptık."I" Okunurluğu arttırmak için,interface oldğ. anlaak için büyük I.
    {
        public void Hesapla();//tüm kredi türlerinde  hesaplama ortaktır ancak kodları farklıdır.
        
    }
}
