using System;
using System.Collections.Generic;

namespace KitapListesiYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] turler = { "Roman", "Hikaye", "Bilim", "Tarih" };

           
            List<int> kitapKodlari = new List<int>();

           
            Dictionary<int, string> kitaplar = new Dictionary<int, string>();

            int secim = -1;

            while (secim != 0)
            {
                Console.Clear();

                Console.WriteLine("KİTAP LİSTESİ YÖNETİMİ");
                Console.WriteLine("1 Kitap Ekle");
                Console.WriteLine("2 Kitapları Listele");
                Console.WriteLine("3 Kitap Güncelle");
                Console.WriteLine("4Kitap Sil");
                Console.WriteLine("5 Kitap Türlerini Göster");
                Console.WriteLine("0 Çıkış");
                Console.Write("Seçiminiz: ");

                int.TryParse(Console.ReadLine(), out secim);

                switch (secim)
                {
                    case 1:

                        Console.Write("Kitap Kodu: ");
                        int.TryParse(Console.ReadLine(), out int kod);

                        if (kitaplar.ContainsKey(kod))
                        {
                            Console.WriteLine("Bu kod daha önce kullanılmış");
                            Console.ReadKey();
                            break;
                        }

                        Console.Write("Kitap Adı: ");
                        string kitapAdi = Console.ReadLine() ?? "";

                        kitapKodlari.Add(kod);
                        kitaplar.Add(kod, kitapAdi);

                        Console.WriteLine("Kitap eklendi.");
                        break;

                    case 2:

                        if (kitaplar.Count == 0)
                        {
                            Console.WriteLine("Kayıtlı kitap bulunmuyo");
                        }
                        else
                        {
                            Console.WriteLine("Kitap Listesi");

                            foreach (var kitap in kitaplar)
                            {
                                Console.WriteLine("Kod : " + kitap.Key);
                                Console.WriteLine("Kitap : " + kitap.Value);
                                Console.WriteLine(".");
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Güncellenecek kitap kodu: ");
                        int.TryParse(Console.ReadLine(), out int guncelKod);

                        if (kitaplar.ContainsKey(guncelKod))
                        {
                            Console.Write("Yeni kitap adı: ");
                            string yeniAd = Console.ReadLine() ?? "";

                            kitaplar[guncelKod] = yeniAd;

                            Console.WriteLine("Kitap bilgisi güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Kitap bulunamadı");
                        }

                        break;

                    case 4:

                        Console.Write("Silinecek kitap kodu: ");
                        int.TryParse(Console.ReadLine(), out int silKod);

                        if (kitaplar.ContainsKey(silKod))
                        {
                            kitaplar.Remove(silKod);
                            kitapKodlari.Remove(silKod);

                            Console.WriteLine("Kitap silindi");
                        }
                        else
                        {
                            Console.WriteLine("Kitap bulunamadı");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Kitap Türleri");

                        foreach (string tur in turler)
                        {
                            Console.WriteLine("- " + tur);
                        }

                        break;

                    case 0:

                        Console.WriteLine("Program sonlandırılıyo");
                        break;

                    default:

                        Console.WriteLine("Geçersiz seçim");
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
