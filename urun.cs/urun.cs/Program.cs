public class Urun
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public double Fiyat { get; set; }

    public Urun(int id, string ad, double fiyat)
    {
        Id = id;
        Ad = ad;
        Fiyat = fiyat;
    }

    public virtual void BilgiGoster()
    {
        Console.WriteLine($"Ürün : {Ad}");
        Console.WriteLine($"Fiyat : {Fiyat} TL");
    }
}
