using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4Odev5
{
    class MyDictionary<K, V> //K ve V diye isimlendirilen type ile döndürülecek
    {
        //ana programda class new'lendiği zaman dizi oluşmalıdır bu yüzden
        //metot dışına tanımlamış olduk
        K[] keys; 
        V[] values;

        public MyDictionary()
        {
            //constructer
            keys = new K[0];
            values = new V[0];
        }

        public void Add(K key, V value) //K tipinde key V tipinde value gelicek
        {

            K[] kTempArray = keys;
            //K[] tipi kTempArray isimli keys asında değişkene atandı
            keys = new K[keys.Length + 1];
            //keys değişkeni de sıfırlanmış oldu 1 eleman artırılıp
            V[] vtempArray = values;
            values = new V[values.Length + 1];

            //_kTempArray = _kArray;
            //_vTempArray = _vArray;

            for (int i = 0; i < kTempArray.Length; i++)
            {
                //geçici uzunluğunca elemanları birbirine eşitledik
                keys[i] = kTempArray[i];
            }

            //anlamadım
            keys[keys.Length - 1] = key;


            for (int i = 0; i < vtempArray.Length; i++)
            {
                values[i] = vtempArray[i];
            }

            values[values.Length - 1] = value;

        }
    }
}
