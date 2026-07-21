using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Urun
    {
        public int ID;
        public string AD;
        public required string Kategori;
        public double Fiyat;
        public int Stok;
    }

    static void Main(string[] args)
    {
        List<Urun> urunler = new List<Urun>();

        urunler.Add(new Urun { ID = 1, AD= "Klavye", Kategori = "Teknoloji", Fiyat = 500, Stok = 10 });
        urunler.Add(new Urun { ID = 2, AD="Mouse", Kategori = "Teknoloji", Fiyat = 300, Stok = 15 });
        urunler.Add(new Urun { ID = 3, AD= "Defter", Kategori = "Kırtasiye", Fiyat = 80, Stok = 25 });
        urunler.Add(new Urun { ID = 4, AD= "Kalem", Kategori = "Kırtasiye", Fiyat = 30, Stok = 50 });
        urunler.Add(new Urun { ID= 5, AD= "Kulaklık",Kategori = "Teknoloji", Fiyat = 750, Stok = 5 });

        Console.WriteLine("Fiyatı 300 TL'den büyük ürünler");
        var filtre = urunler.Where(x => x.Fiyat > 300);

        foreach (var item in filtre)
        {
            Console.WriteLine(item.AD + " - " + item.Fiyat);
        }

        Console.WriteLine();

        Console.WriteLine("Sadece ürün adları");
        var adlar = urunler.Select(x => x.AD);

        foreach (var item in adlar)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Console.WriteLine("Fiyata göre sıralama");
        var sirali = urunler.OrderBy(x => x.Fiyat);

        foreach (var item in sirali)
        {
            Console.WriteLine(item.AD + " - " + item.Fiyat);
        }

        Console.WriteLine();

        Console.WriteLine("Kategoriye göre gruplama");

        var gruplar = urunler.GroupBy(x => x.Kategori);

        foreach (var grup in gruplar)
        {
            Console.WriteLine(grup.Key);

            foreach (var urun in grup)
            {
                Console.WriteLine(urun.AD);
            }

            Console.WriteLine();
        }

        Console.WriteLine("İlk teknoloji ürünü");

        var ilk = urunler.FirstOrDefault(x => x.Kategori == "Teknoloji");

        Console.WriteLine(ilk.AD);

        Console.WriteLine();

        Console.WriteLine("500 TL'den pahalı ürün var mı?");
        Console.WriteLine(urunler.Any(x => x.Fiyat
        > 500));

        Console.WriteLine();

        Console.WriteLine("Hepsinin stoğu var mı?");
        Console.WriteLine(urunler.All(x => x.Stok > 0));

        Console.WriteLine();

        Console.WriteLine("Ürün Sayısı");
        Console.WriteLine(urunler.Count());

        Console.WriteLine();

        Console.WriteLine("Toplam Fiyat");
        Console.WriteLine(urunler.Sum(x => x.Fiyat));

        Console.ReadKey();
    }
}
