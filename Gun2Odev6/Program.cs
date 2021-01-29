using System;

namespace Gun2Odev6
{
    class Program
    {
        static void Main(string[] args)
        {

            Products Urun1 = new Products();
            Urun1.Bedeni = "S";
            Urun1.Markasi = "DeFacto";
            Urun1.Materyali = "Pamuk";
            Urun1.Modeli = "Kazak";
            Urun1.Rengi = "Beyaz";
            Urun1.Id = 123456789;
            Urun1.Fiyati = 179.99;

            Products Urun2 = new Products();
            Urun2.Bedeni = "L";
            Urun2.Markasi = "Trendyolmilla";
            Urun2.Materyali = "Viskon";
            Urun2.Modeli = "Tayt";
            Urun2.Rengi = "Siyah";
            Urun2.Id = 123456790;
            Urun2.Fiyati = 49.99;

            //dizi tanımlayalım
            Products[] urunler = new Products[] { Urun1, Urun2 };
            //foreach (Products Urun in urunler)
            //{
            //Console.WriteLine(Urun);
            //    Console.WriteLine(Urun.Markasi);
            //    Console.WriteLine(Urun.Modeli);
            //    Console.WriteLine(Urun.Bedeni);
            //    Console.WriteLine(Urun.Rengi);
            //    Console.WriteLine(Urun.Materyali);
            //    Console.WriteLine(Urun.Fiyati);
            //    Console.WriteLine("-----------------");
            //}

            //for (int i = 0; i < urunler.Length; i++)
            //{
            //    Console.WriteLine(urunler[i].Markasi);
            //    Console.WriteLine(urunler[i].Modeli);
            //    Console.WriteLine(urunler[i].Bedeni);
            //    Console.WriteLine(urunler[i].Rengi);
            //    Console.WriteLine(urunler[i].Materyali);
            //    Console.WriteLine(urunler[i].Fiyati);
            //}

            int i = 0;
            while (i<urunler.Length)
            {
                Console.WriteLine(urunler[i].Markasi);
                Console.WriteLine(urunler[i].Modeli);
                Console.WriteLine(urunler[i].Bedeni);
                Console.WriteLine(urunler[i].Rengi);
                Console.WriteLine(urunler[i].Materyali);
                Console.WriteLine(urunler[i].Fiyati);
                i++;
            }
        }
    }
}