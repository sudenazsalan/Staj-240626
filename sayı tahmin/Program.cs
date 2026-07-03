using System;

namespace SayiTahminOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tutulanSayi = rnd.Next(1, 101);
            int tahmin = 0;
            int hak = 7;

            Console.WriteLine("SAYI TAHMİN");
            Console.WriteLine("1 ile 100 arasında bir sayı tut.");
            Console.WriteLine("Toplam 7 tahmin hakkın var.");

            while (hak > 0)
            {
                Console.Write("\nTahminini gir: ");

                if (!int.TryParse(Console.ReadLine(), out tahmin))
                {
                    Console.WriteLine("Lütfen geçerli bir sayı gir.");
                    continue;
                }

                if (tahmin == tutulanSayi)
                {
                    Console.WriteLine("Tebrikler ederim.");
                    break;
                }
                else if (tahmin < tutulanSayi)
                {
                    Console.WriteLine("Daha büyük bir sayı dene.");
                }
                else
                {
                    Console.WriteLine("Daha küçük bir sayı dene.");
                }

                hak--;

                if (hak > 0)
                {
                    Console.WriteLine("Kalan hak: " + hak);
                }
            }

            if (tahmin != tutulanSayi)
            {
                Console.WriteLine("\nTahmin hakların bitti.");
                Console.WriteLine("Tutulan sayı: " + tutulanSayi);
            }

            Console.WriteLine("\nOyundan çıkmak için bir tuşa bas.");
            Console.ReadKey();
        }
    }
}