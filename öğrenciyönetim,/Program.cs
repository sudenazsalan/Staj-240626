using System;
using System.Collections.Generic;

namespace OgrenciYonetim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array (Dizi)
            string[] bolumler = { "Bilgisayar Programcılığı", "Elektrik", "Makine" };

            // List
            List<int> numaralar = new List<int>();

            // Dictionary
            Dictionary<int, string> ogrenciler = new Dictionary<int, string>();

            int secim = -1;

            while (secim != 0)
            {
                Console.Clear();
                Console.WriteLine( " ÖĞRENCİ YÖNETİM ");
                Console.WriteLine("1 - Öğrenci Ekle");
                Console.WriteLine("2 - Öğrencileri Listele");
                Console.WriteLine("3 - Öğrenci Güncelle");
                Console.WriteLine("4 - Öğrenci Sil");
                Console.WriteLine("5 - Bölümleri Göster");
                Console.WriteLine("0 - Çıkış");
                Console.Write("Seçim: ");

                bool sonuc = int.TryParse(Console.ReadLine(), out secim);

                if (!sonuc)
                {
                    Console.WriteLine("Lütfen geçerli bir sayı giriniz ");
                    Console.ReadKey();
                    continue;
                }

                switch (secim)
                {
                    case 1:

                        Console.Write("Öğrenci Numarası: ");
                        bool noKontrol = int.TryParse(Console.ReadLine(), out int no);

                        if (!noKontrol)
                        {
                            Console.WriteLine("Geçersiz numara");
                            Console.ReadKey();
                            break;
                        }

                        if (ogrenciler.ContainsKey(no))
                        {
                            Console.WriteLine("Bu numara kayıtlı.");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Ad Soyad: ");
                        string ad = Console.ReadLine() ?? "";

                        ogrenciler.Add(no, ad);
                        numaralar.Add(no);

                        Console.WriteLine("Öğrenci eklendi");
                        Console.ReadKey();
                        break;

                    case 2:

                        if (ogrenciler.Count == 0)
                        {
                            Console.WriteLine("Kayıtlı öğrenci yok");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci Listesi");

                            foreach (KeyValuePair<int, string> ogrenci in ogrenciler)
                            {
                                Console.WriteLine("No : " + ogrenci.Key);
                                Console.WriteLine("Ad : " + ogrenci.Value);
                                Console.WriteLine(" . ");
                            }
                        }

                        Console.ReadKey();
                        break;

                    case 3:

                        Console.Write("Güncellenecek Öğrenci Numarası: ");
                        bool guncel = int.TryParse(Console.ReadLine(), out int gNo);

                        if (!guncel)
                        {
                            Console.WriteLine("Geçersiz numara ");
                            Console.ReadKey();
                            break;
                        }

                        if (ogrenciler.ContainsKey(gNo))
                        {
                            Console.Write("Yeni Ad Soyad: ");
                            string yeniAd = Console.ReadLine() ?? "";

                            ogrenciler[gNo] = yeniAd;

                            Console.WriteLine("Bilgiler güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci bulunamadı");
                        }

                        Console.ReadKey();
                        break;

                    case 4:

                        Console.Write("Silinecek Öğrenci Numarası: ");
                        bool sil = int.TryParse(Console.ReadLine(), out int sNo);

                        if (!sil)
                        {
                            Console.WriteLine("Geçersiz numara ");
                            Console.ReadKey();
                            break;
                        }

                        if (ogrenciler.ContainsKey(sNo))
                        {
                            ogrenciler.Remove(sNo);
                            numaralar.Remove(sNo);

                            Console.WriteLine("Öğrenci silindi.");
                        }
                        else
                        {
                            Console.WriteLine("Öğrenci bulunamadı.");
                        }

                        Console.ReadKey();
                        break;

                    case 5:

                        Console.WriteLine("Bölümler");

                        foreach (string bolum in bolumler)
                        {
                            Console.WriteLine("- " + bolum);
                        }

                        Console.ReadKey();
                        break;

                    case 0:

                        Console.WriteLine("Program bitti");
                        break;

                    default:

                        Console.WriteLine("Geçersiz");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}