using System;

class Program
{
    static void Main(string[] args)
    {
        Musteri m1 = new Musteri(1, "Ahmet Yılmaz", "05551112233");

        Urun u1 = new Urun(1, "Klavye", 500);

        IndirimliUrun u2 = new IndirimliUrun(2, "Mouse", 300, 20);

        Siparis siparis = new Siparis(1001, m1);

        siparis.UrunEkle(new SiparisKalem(u1, 2));
        siparis.UrunEkle(new SiparisKalem(u2, 1));

        siparis.SiparisGoster();

        Console.WriteLine();
        Console.WriteLine("Polymorphism Örneği");

        u1.BilgiGoster();
        Console.WriteLine();
        u2.BilgiGoster();

        Console.ReadKey();
    }
}