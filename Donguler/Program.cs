using System;
using System.Collections;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[] { "yazılım kursu", "donanım kursu2", "pyton", "java", "PHP", "GoLang" };
            int len = kurslar.Length;
            int sayac = 0;

            var students = new ArrayList
            {
                "Nesat",
                "Soysal"
            };

            students.ToArray();

            while (sayac != len)// condition=>kosul
            {
                Console.WriteLine(kurslar[sayac]);
                sayac++;
            }

     
            /*
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }


            Console.WriteLine("sayfa sonu - footer");*/
        }
    }
}