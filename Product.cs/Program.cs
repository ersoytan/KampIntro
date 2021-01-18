using System;

namespace Product.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.UrunAdi = "kulaklık";
            urun1.Fiyat = 150;
            urun1.Ozellik = "air pods";

            Product urun2 = new Product
            {
                UrunAdi = "monitor",
                Fiyat = 750,
                Ozellik = "gaming"
            };


            Product urun3 = new Product();
            urun3.UrunAdi = "klavye";
            urun3.Fiyat = 70;
            urun3.Ozellik = "laser";

            Product[] products = new Product[] { urun1, urun2, urun3 };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(products[i].UrunAdi);
                Console.WriteLine(products[i].Fiyat);
                Console.WriteLine(products[i].Ozellik);
                Console.WriteLine(new String('-', 20));

            }

        }
        class Product
        {
            public string UrunAdi { get; set; }
            public int Fiyat { get; set; }
            public string Ozellik { get; set; }
        }
    }
}
