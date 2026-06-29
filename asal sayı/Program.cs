using System;

class Program
{
    static void Main()
    {
        char cevap;

        do
        {
            Console.Clear();
            Console.WriteLine(" ASAL SAYI KONTROL");
            Console.WriteLine();

            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine()!);

            bool asal = true;

            if (sayi <= 1)
            {
                asal = false;
            }
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    if (sayi % i == 0)
                    {
                        asal = false;
                        break;
                    }
                }
            }

            Console.WriteLine();

            if (asal)
            {
                Console.WriteLine(sayi + " asal bir sayı");
            }
            else
            {
                Console.WriteLine(sayi + " asal bir sayı değil.");
            }

            Console.WriteLine();
            Console.Write("Tekrar kontrol yapmak ister misiniz? (E/H): ");
            cevap = Convert.ToChar(Console.ReadLine()!.ToUpper());

        } while (cevap == 'E');

        Console.WriteLine();
        Console.WriteLine("Program bitti.");
        Console.ReadKey();
    }
}