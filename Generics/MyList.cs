using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class MyList<T>
    {
        T[] items;

        public MyList()
        {
            items = new T[0]; //items adinda ilk array olusturuldu. Constructor icerisinde. 
        }

        public void Add(T item) // Burada 1 elemanli liste olusturmak icin new leriz. ==> items = new T[items.Length + 1];
        {
            T[] tempArray = items; //ref numarsini tutmak icin. asagida ref degismesin diye. önceki ref tuttarak icerisindeki verinin ucmamasini sagliyoruz
            items = new T[items.Length + 1];

            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length-1] = item;

        }

        public int Length { get { return items.Length; } }

        public T[] Items
        {
            get { return items; }
        }
    }
}
