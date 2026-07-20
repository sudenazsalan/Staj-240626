using System;

class Program
{
    class Musteri
    {
        public int ID;
        public string AD;
        public string Tel;
    }

    class Urun
    {
        public int ID;
        public string Ad;
        public double Fiyat;

        public Urun(int id, string ad, double fiyat)
        {
            ID = id;
            Ad = ad;
            Fiyat = fiyat;
        }

        public void BilgiGoster()
        {
            Console.WriteLine("Ürün ID : " + ID);
            Console.WriteLine("Ürün Adı : " + Ad);
            Console.WriteLine("Fiyat : " + Fiyat + " TL");
        }
    }

    class Siparis
    {
        public int SiparisNo;
        public Musteri MusteriBilgi;

        public Siparis(int no, Musteri musteri)
        {
            SiparisNo = no;
            MusteriBilgi = musteri;
        }

        public void SiparisGoster()
        {
            Console.WriteLine("Sipariş No : " + SiparisNo);
            Console.WriteLine("Müşteri : " + MusteriBilgi.AD);
            Console.WriteLine("Telefon : " + MusteriBilgi.Tel);
        }
    }

    class SiparisKalem
    {
        public Urun UrunBilgi;
        public int Adet;

        public SiparisKalem(Urun urun, int adet)
        {
            UrunBilgi = urun;
            Adet = adet;
        }

        public void KalemGoster()
        {
            Console.WriteLine("Ürün : " + UrunBilgi.Ad);
            Console.WriteLine("Adet : " + Adet);
            Console.WriteLine("Toplam : " + (UrunBilgi.Fiyat * Adet) + " TL");
        }
    }

    static void Main(string[] args)
    {
        Musteri m1 = new Musteri();
        m1.ID = 1;
        m1.AD = "ugur";
        m1.Tel = "05551112233";

        Console.WriteLine($"{m1.ID} {m1.AD} {m1.Tel}");

        Urun u1 = new Urun(1, "Klavye", 500);

        Siparis siparis = new Siparis(1001, m1);

        SiparisKalem kalem1 = new SiparisKalem(u1, 2);

        Console.WriteLine();

        siparis.SiparisGoster();

        Console.WriteLine();

        kalem1.KalemGoster();

        Console.WriteLine();

        u1.BilgiGoster();

        Console.WriteLine();
        Console.WriteLine("Çıkmak için bir tuşa bas");
        Console.ReadKey();
    }
}