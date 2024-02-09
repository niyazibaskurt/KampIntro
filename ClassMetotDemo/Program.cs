
using ClassMetotDemo;

public class Program
{
    private static void Main(string[] args)
    {
        //Müşteri class'ından nesne oluşturuldu ve farklı kullanımlarla müşteriler oluşturuldu. 
        Musteri musteri1 = new Musteri();

        musteri1.Id = 1;
        musteri1.Ad = "Niyazi";
        musteri1.Soyad = "Başkurt";

        Musteri musteri2 = new Musteri() { Id = 2, Ad = "Alperen", Soyad = "Başkurt" };
        Musteri musteri3 = new Musteri { Id = 3, Ad = "Ali", Soyad = "Başkurt" };
        Musteri musteri4 = new Musteri { Id = 4, Ad = "Ömer Taha", Soyad = "Başkurt" };

        MusteriManager musteriManager = new MusteriManager();

        musteriManager.Add(musteri1);
        musteriManager.Delete(musteri2);

        List<Musteri> musteriler = new List<Musteri>();

        musteriler.Add(musteri1);
        musteriler.Add(musteri2);
        musteriler.Add(musteri3);
        musteriler.Add(musteri4);

        musteriManager.GetAllMusteriList(musteriler);
    }
}