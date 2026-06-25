using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(" SUDİSİN HESAP MAKINESI ");

        Console.Write("Birinci sayıyı giriniz: ");
        double sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        double sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nİşlem Seçiniz");
        Console.WriteLine("1 - Toplama");
        Console.WriteLine("2 - Çıkarma");
        Console.WriteLine("3 - Çarpma");
        Console.WriteLine("4 - Bölme");

        Console.Write("Seçiminiz: ");
        int secim = Convert.ToInt32(Console.ReadLine());

        double sonuc = 0;
           
        switch (secim)
        {
            case 1:
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç: {sonuc}");
                break;

            case 2:
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç: {sonuc}");
                break;

            case 3:
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: {sonuc}");
                break;

            case 4:
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: {sonuc}");
                }
                else
                {
                    Console.WriteLine("Bir sayı sıfıra bölünemez ");
                }
                break;

            default:
                Console.WriteLine("Geçersiz seçim yaptınız ");
                break;
        }

        Console.WriteLine("Program bitti ");
    }
}
// test






