using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//T :bana bir tip ver demek: MYLİST'imde tek bir tip ile çalışıcam demek.
    {

        T[] items;
        //Constructor
        public MyList()
        {
            items = new T[0];// bir class'ı new'leyince eleman sayısı: 0. bunu tanımladık.
        }

        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length+1];//class'ı new'leyince yeni referans aldı. eski değerleri unutuyor.
            for (int i = 0; i < tempArray.Length; i++)//unutmaması için eski değerleri hatırlatıyoruz.
            {
                items[i] = tempArray[i];
                                    
            }
            items[items.Length - 1] = item;//son elman sizin gönderdiğiniz item.

        }
    }
}
