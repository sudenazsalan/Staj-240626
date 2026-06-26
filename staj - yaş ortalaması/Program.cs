using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("YAŞ ORTALAMASI HESAPLAMA");

        Console.Write("Kaç kişinin yaşı girilecek? : ");
        int kisiSayisi = Convert.ToInt32(Console.ReadLine());

        int toplamYas = 0;

        for (int i = 1; i <= kisiSayisi; i++)
        {
            Console.Write(i + ". kişinin yaşını giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            toplamYas += yas;
        }

        double ortalama = (double)toplamYas / kisiSayisi;

        Console.WriteLine();
        Console.WriteLine("Yaş Ortalaması: " + ortalama);

        if (ortalama >= 18)
        {
            Console.WriteLine("Grubun yaş ortalaması 18 ve üzerindedir");
        }
        else
        {
            Console.WriteLine("Grubun yaş ortalaması 18'in altındadır");
        }

        Console.WriteLine();
        Console.WriteLine("Program bitti.");
        Console.ReadKey();
    }
}
