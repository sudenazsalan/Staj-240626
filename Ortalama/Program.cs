using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("NOT ORTALAMASI HESAPLAMA");

        Console.Write("Kaç ders girilecek? : ");
        int dersSayisi = Convert.ToInt32(Console.ReadLine());

        int toplamNot = 0;

        for (int i = 1; i <= dersSayisi; i++)
        {
            Console.Write(i + ". ders notunu giriniz: ");
            int not = Convert.ToInt32(Console.ReadLine());

            toplamNot += not;
        }

        double ortalama = (double)toplamNot / dersSayisi;

        Console.WriteLine("***");
        Console.WriteLine("Ortalamanız: " + ortalama);

        if (ortalama >= 50)
        {
            Console.WriteLine(" Sonuc: GEÇTİ");
        }
        else
        {
            Console.WriteLine("Sonuc: KALDI");
        }

        Console.WriteLine("***");
        Console.WriteLine("Çıkmak için bir tuşa bas...");
        Console.ReadKey();
    }
}