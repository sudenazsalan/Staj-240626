using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Satis
    {
        public int ID;
        public required string UrunAdi;
        public required string Kategori;
        public int Adet;
        public double Fiyat; 
    }

    static void Main(string[] args)
    {
        List<Satis> satislar = new List<Satis>();

        satislar.Add(new Satis { ID = 1, UrunAdi = "Klavye", Kategori = "Teknoloji", Adet = 2, Fiyat = 500 });
        satislar.Add(new Satis { ID = 2, UrunAdi = "Mouse", Kategori = "Teknoloji", Adet = 3, Fiyat = 300 });
        satislar.Add(new Satis { ID = 3, UrunAdi = "Defter", Kategori = "Kırtasiye", Adet = 5, Fiyat = 80 });
        satislar.Add(new Satis { ID = 4, UrunAdi = "Kalem", Kategori = "Kırtasiye", Adet = 10, Fiyat = 30 });
        satislar.Add(new Satis { ID = 5, UrunAdi = "Kulaklık", Kategori = "Teknoloji", Adet = 1, Fiyat = 750 });

        Console.WriteLine("100 TL'den büyük satış");

        var liste = satislar.Where(x => x.Fiyat > 100);

        foreach (var item in liste)
        {
            Console.WriteLine(item.UrunAdi + " - " + item.Fiyat + " TL");
        }

        Console.WriteLine();

        Console.WriteLine("Satılan Ürünler");

        var urunler = satislar.Select(x => x.UrunAdi);

        foreach (var item in urunler)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();

        Console.WriteLine("Fiyat Sıralama");

        var sirala = satislar.OrderBy(x => x.Fiyat);

        foreach (var item in sirala)
        {
            Console.WriteLine(item.UrunAdi + " - " + item.Fiyat);
        }

        Console.WriteLine();

        Console.WriteLine("Kategori Gruplama");

        var grup = satislar.GroupBy(x => x.Kategori);

        foreach (var item in grup)
        {
            Console.WriteLine(item.Key);

            foreach (var satis in item)
            {
                Console.WriteLine(satis.UrunAdi);
            }

            Console.WriteLine();
        }

        Console.WriteLine("İlk Satış");

        Satis? ilk = satislar.FirstOrDefault();

        string urunAdi1 = ilk.UrunAdi;
        string urunAdi = urunAdi1;
        Console.WriteLine(urunAdi);

        Console.WriteLine();

        Console.WriteLine("500 TL'den büyük satış var mı?");
        Console.WriteLine(satislar.Any(x => x.Fiyat > 500));

        Console.WriteLine();

        Console.WriteLine("Tüm satışların adedi 0'dan büyük mü?");
        Console.WriteLine(satislar.All(x => x.Adet > 0));

        Console.WriteLine();

        Console.WriteLine("Toplam Satış Sayısı");
        Console.WriteLine(satislar.Count());

        Console.WriteLine();

        Console.WriteLine("Toplam Ciro");

        double toplam = satislar.Sum(x => x.Fiyat * x.Adet);

        Console.WriteLine(toplam + " TL");

        Console.ReadKey();
    }
}