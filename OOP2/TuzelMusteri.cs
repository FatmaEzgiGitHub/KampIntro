using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate
    // class yanına :musteri yazdı bu miras =inheritance
    class TuzelMusteri:Musteri//tüzelmüşteri de bir müşteridir.Musteri=ebeveyndir.
    {
       
        public string SirketAdi { get; set; }//prop yaz tab tab yap
        public string VergiNo { get; set; }
    }
}
