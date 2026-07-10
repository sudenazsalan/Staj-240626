using System;
using System.Collections.Generic;

namespace StokTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi
            string[] kategoriler = { "Elektronik", "Gıda", "Temizlik" };

            // List
            List<string> urunler = new List<string>();

            // Dictionary
            Dictionary<string, int> stoklar = new Dictionary<string, int>();

            int secim = -1;

            while (secim != 0)
            {
                Console.Clear();

                Console.WriteLine("STOK TAKİP UYGULAMASI");
                Console.WriteLine("1- Ürün Ekle");
                Console.WriteLine("2- Ürünleri Listele");
                Console.WriteLine("3- Stok Güncelle");
                Console.WriteLine("4- Ürün Sil");
                Console.WriteLine("5- Kategorileri Göster");
                Console.WriteLine("0- Çıkış");
                Console.Write("Seçiminiz: ");

                int.TryParse(Console.ReadLine(), out secim);

                switch (secim)
                {
                    case 1:

                        Console.Write("Ürün Adı: ");
                        string urun = Console.ReadLine() ?? "";

                        Console.Write("Stok Miktarı: ");
                        int stok;
                        int.TryParse(Console.ReadLine(), out stok);

                        if (!stoklar.ContainsKey(urun))
                        {
                            urunler.Add(urun);
                            stoklar.Add(urun, stok);

                            Console.WriteLine("Ürün eklendi");
                        }
                        else
                        {
                            Console.WriteLine("Bu ürün kayıtlı");
                        }

                        break;

                    case 2:

                        if (stoklar.Count == 0)
                        {
                            Console.WriteLine("Stokta ürün bulunamadı");
                        }
                        else
                        {
                            Console.WriteLine("Ürün Listesi");

                            foreach (var item in stoklar)
                            {
                                Console.WriteLine("Ürün : " + item.Key);
                                Console.WriteLine("Stok : " + item.Value);
                                Console.WriteLine(".");
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Güncellenecek ürün adı: ");
                        string guncelle = Console.ReadLine() ?? "";

                        if (stoklar.ContainsKey(guncelle))
                        {
                            Console.Write("Yeni stok miktarı: ");
                            int yeniStok;
                            int.TryParse(Console.ReadLine(), out yeniStok);

                            stoklar[guncelle] = yeniStok;

                            Console.WriteLine("Stok güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Ürün bulunamadı");
                        }

                        break;

                    case 4:

                        Console.Write("Silinecek ürün adı: ");
                        string sil = Console.ReadLine() ?? "";

                        if (stoklar.ContainsKey(sil))
                        {
                            stoklar.Remove(sil);
                            urunler.Remove(sil);

                            Console.WriteLine("Ürün silindi");
                        }
                        else
                        {
                            Console.WriteLine("Ürün bulunamadı");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Kategoriler");

                        foreach (string kategori in kategoriler)
                        {
                            Console.WriteLine(kategori);
                        }

                        break;

                    case 0:

                        Console.WriteLine("Program bitti");
                        break;

                    default:

                        Console.WriteLine("Hatalı seçim");
                        break;
                }

                if (secim != 0)
                {
                    Console.WriteLine("Devam etmek için bir tuşa bas");
                    Console.ReadKey();
                }
            }
        }
    }
}
