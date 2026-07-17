using System;

class Program
{
    class Musteri
    {
        public int ID;
        public string AD;
        public string Tel;
    }
    static void Main(string[] args)
    {
        Musteri m1 = new Musteri();
        m1.ID = 1;
        m1.AD = "ugur";
        m1.Tel = "05551112233";

        Console.WriteLine($"{m1.ID} {m1.AD} {m1.Tel}");


        //Urun u1 = new Urun(1, "Klavye", 500);

        //Urun indirimliUrun = new Urun(2, "Mouse", 300, 20);

        //Siparis siparis = new Siparis(1001, m1);

        //SiparisKalem kalem1 = new SiparisKalem(u1, 2);
        //SiparisKalem kalem2 = new SiparisKalem(u2, 1);

        //siparis.UrunEkle(kalem1);
        //siparis.UrunEkle(kalem2);

        //siparis.SiparisGoster();

        //Console.WriteLine();
        //Console.WriteLine("Polymorphism Örneği");
        //Console.WriteLine();

        //u1.BilgiGoster();
        //Console.WriteLine();
        //u2.BilgiGoster();

        //Console.WriteLine();
        //Console.WriteLine("Çıkmak için bir tuşa bas");
        //Console.ReadKey();
    }
} 