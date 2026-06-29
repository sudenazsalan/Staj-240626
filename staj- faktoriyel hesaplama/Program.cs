using System;

class Program
{
    static void Main()
    {
        char cevap;

        do
        {
            Console.Clear();
            Console.WriteLine("FAKTÖRİYEL HESAPLAMA ");
            Console.WriteLine();

            Console.Write("Bir tam sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine()!);

            if (sayi < 0)
            {
                Console.WriteLine("Negatif sayıların faktöriyeli hesaplanamaz");
            }
            else
            {
                long faktoriyel = 1;

                for (int i = 1; i <= sayi; i++)
                {
                    faktoriyel = faktoriyel * i;
                }

                Console.WriteLine();
                Console.WriteLine("Girilen Sayı : " + sayi);
                Console.WriteLine("Faktöriyel : " + faktoriyel);

                if (sayi == 0)
                {
                    Console.WriteLine("Not: 0! = 1 olarak kabul ediliyor");
                }
            }

            Console.WriteLine();
            Console.Write("Tekrar hesaplama yapmak ister misiniz?: ");
            cevap = Convert.ToChar(Console.ReadLine()!.ToUpper());

        } while (cevap == 's');

        Console.WriteLine();
        Console.WriteLine("Program bitti.");
        Console.ReadKey();
    }
}