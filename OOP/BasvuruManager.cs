using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager) //burada tek bir kredi için basvuru yapıcam
        {
            //Başvuran bilgilerini değerlendirme
            //
            krediManager.Hesapla();

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)//burada müşteriye bbirden fazla krediyi listelicem
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
