using System;
using System.Collections.Generic;

namespace TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] operatorler = { "Turkcell", "Vodafone", "Turk Telekom" }; 

          
            List<string> telefonNumaralari = new List<string>();

          
            Dictionary<string, string> rehber = new Dictionary<string, string>();

            int secim;

            do
            {
                Console.Clear();

                Console.WriteLine("TELEFON REHBERİ");
                Console.WriteLine("1Kişi Ekle");
                Console.WriteLine("2 Kişileri Listele");
                Console.WriteLine("3Kişi Güncelle");
                Console.WriteLine("4 Kişi Sil");
                Console.WriteLine("5 Operatörleri Göster");
                Console.WriteLine("0 Çıkış");
                Console.Write("Seçiminiz: ");

                int.TryParse(Console.ReadLine(), out secim);

                switch (secim)
                {
                    case 1:

                        Console.Write("İsim: ");
                        string isim = Console.ReadLine() ?? "";

                        Console.Write("Telefon: ");
                        string telefon = Console.ReadLine() ?? "";

                        if (!rehber.ContainsKey(isim))
                        {
                            rehber.Add(isim, telefon);
                            telefonNumaralari.Add(telefon);

                            Console.WriteLine("Kişi eklendi");
                        }
                        else
                        {
                            Console.WriteLine("Bu kişi zaten kayıtlı");
                        }

                        break;

                    case 2:

                        if (rehber.Count == 0)
                        {
                            Console.WriteLine("Rehber boş");
                        }
                        else
                        {
                            Console.WriteLine("Kişiler");

                            foreach (var kisi in rehber)
                            {
                                Console.WriteLine("Ad: " + kisi.Key);
                                Console.WriteLine("Telefon: " + kisi.Value);
                                Console.WriteLine(".");
                            }
                        }

                        break;

                    case 3:

                        Console.Write("Güncellenecek kişinin adı: ");
                        string guncelle = Console.ReadLine() ?? "";

                        if (rehber.ContainsKey(guncelle))
                        {
                            Console.Write("Yeni telefon: ");
                            string yeniTelefon = Console.ReadLine() ?? "";

                            rehber[guncelle] = yeniTelefon;

                            Console.WriteLine("Telefon numarası güncellendi");
                        }
                        else
                        {
                            Console.WriteLine("Kişi bulunamadı");
                        }

                        break;

                    case 4:

                        Console.Write("Silinecek kişinin adı: ");
                        string sil = Console.ReadLine() ?? "";

                        if (rehber.ContainsKey(sil))
                        {
                            telefonNumaralari.Remove(rehber[sil]);
                            rehber.Remove(sil);

                            Console.WriteLine("Kişi silindi");
                        }
                        else
                        {
                            Console.WriteLine("Kişi bulunamadı");
                        }

                        break;

                    case 5:

                        Console.WriteLine("Operatörler");

                        foreach (string op in operatorler)
                        {
                            Console.WriteLine(op);
                        }

                        break;

                    case 0:

                        Console.WriteLine("Program kapatıldı");
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

            } while (secim != 0);  
        }
    }
}