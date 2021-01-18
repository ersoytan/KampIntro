using System;

namespace eticaretBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.UrunAdi = "Araba Kokusu";
            product1.MagazaAdi = "Glade";
            product1.Fiyat = 12;
            product1.Kargo = "Ücretli";

            Product product2 = new Product();
            product2.UrunAdi = "Pasta Cila";
            product2.MagazaAdi = "Valet Pro";
            product2.Fiyat = 123;
            product2.Kargo = "Ücretsiz";


            Product[] products = new Product[] { product1, product2 };

            foreach (var product in products)
            {
                Console.WriteLine(product.MagazaAdi + ":" + product.UrunAdi);
            }

            Console.WriteLine("-------------------");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Ürün Adı: " + products[i].UrunAdi);
                Console.WriteLine("Mağaza Adı: " + products[i].MagazaAdi);
                Console.WriteLine("Fiyatı : " + products[i].Fiyat + " TL");
                Console.WriteLine("Kargo : " + products[i].Kargo);
                Console.WriteLine("-----------------");
            }

            int x = 0;
            while (x < products.Length)
            {
                Console.WriteLine(products[x].UrunAdi);
                Console.WriteLine(products[x].MagazaAdi);
                Console.WriteLine(products[x].Fiyat);
                Console.WriteLine(products[x].Kargo);
                x++;
            }
        }
        class Product
        {
            public string UrunAdi { get; set; }
            public string MagazaAdi { get; set; }
            public int Fiyat { get; set; }
            public string Kargo { get; set; }

        }
