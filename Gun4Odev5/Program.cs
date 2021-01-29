using System;
using System.Collections.Generic;

namespace Gun4Odev5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> Ogrenci = new Dictionary<int, string>();

            Ogrenci.Add(134, "Tolga Demirer");
            Ogrenci.Add(158, "Ümit Özkan");
            Ogrenci.Add(115, "Kadir Aydemir");
            Ogrenci.Add(174, "Cemal Çiftçi");

            Console.Write("Öğrenci No Giriniz");
            int No = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Ogrenci[No]);
            }
            catch (Exception)
            {
                Console.WriteLine("Öğrenci bulunamadı.");
            }


            MyDictionary<int, string> Talebe = new MyDictionary<int, string>();

            Talebe.Add(134, "Tolga Demirer");
            Talebe.Add(158, "Ümit Özkan");
            Talebe.Add(115, "Kadir Aydemir");
            Talebe.Add(174, "Cemal Çiftçi");

            Console.WriteLine("Öğrenci No Giriniz ");
            int numara = int.Parse(Console.ReadLine());

            try
            {
                Console.WriteLine(Talebe[numara]);
                //hata alıyorum [] tanımlı olmadığına dair
            }
            catch (Exception)
            {
                Console.WriteLine("Öğrenci bulunamadı.");
            }


        }
    }
}
