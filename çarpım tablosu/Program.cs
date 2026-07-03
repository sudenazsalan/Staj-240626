using System;

namespace CarpimTablosu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Çarpım Tablosu");

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write((i * j).ToString().PadLeft(4));
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
