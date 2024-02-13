using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;         // items isimli generic diziyi tanımla

        public MyList()   // Bu class bir yerde newlenince yapıcı metot yani constructor otomatik olarak çalışıyor.
        {
            items = new T[0];   // items isimli generic diziyi sıfırla
        }

        public void Add(T item)
        {
            T[] tempArray = items;                 //items isimli generic diziyi yedekle
            items = new T[items.Length + 1];       // Eklenecek olan veri için generic diziyi 1 arttır

            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];                  // tempArray de geçici tutulan her bir veriyi items içerisine geri al
            }

            items[items.Length - 1] = item;
        }

        public int Length
        {
            get { return items.Length; }

        }

        public T[] Items
        {
            get { return items; }

        }

    }
}