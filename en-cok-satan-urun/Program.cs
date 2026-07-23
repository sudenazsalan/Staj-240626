using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Urun
    {
        public int ID;
        public required string Ad;
        public int SatisAdedi;
    }

    static void Main(string[] args)
    {
        List<Urun> urunler = new List<Urun>();

        urunler.Add(new Urun { ID = 1, Ad = "Klavye", SatisAdedi = 15 });
        urunler.Add(new Urun { ID = 2, Ad = "Mouse", SatisAdedi = 28 });
        urunler.Add(new Urun { ID = 3, Ad = "Kulaklık", SatisAdedi = 10 });
        urunler.Add(new Urun { ID = 4, Ad = "Monitör", SatisAdedi = 7 });
        urunler.Add(new Urun { ID = 5, Ad = "Webcam", SatisAdedi = 20 });

        var enCokSatan = urunler.OrderByDescending(x => x.SatisAdedi).FirstOrDefault();

        Console.WriteLine("En Çok Satan Ürün");
        Console.WriteLine(".");
        Console.WriteLine(value: "Ürün Adı : " + enCokSatan.Ad);
        Console.WriteLine("Satış Adedi : " + enCokSatan.SatisAdedi);

        Console.WriteLine();

        Console.WriteLine("Toplam Ürün Sayısı : " + urunler.Count());

        Console.WriteLine("Toplam Satış : " + urunler.Sum(x => x.SatisAdedi));

        Console.WriteLine();

        Console.WriteLine("10'dan fazla satan ürünlerrr");

        var liste = urunler.Where(x => x.SatisAdedi > 10);

        foreach (var item in liste)
        {
            Console.WriteLine(item.Ad + " - " + item.SatisAdedi);
        }

        Console.ReadKey();
    }
}