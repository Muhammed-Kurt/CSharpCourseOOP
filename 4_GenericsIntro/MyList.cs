using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_GenericsIntro
{
    internal class MyList<T>/*T = Type = isimlendirme amaçlı*/
    {
        T[] items;
        //Constructor (Yapıcı Metot)
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item) // T item genel bir isimlendirmedir.
        {
            T[] tempArray = items; //Temporary Array = Geçici Dizi
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i]; //tempArray'deki verileri items'a aktarıyoruz.
            }

            items[items.Length - 1] = item;
        }

    }
}
