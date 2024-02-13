
using ClassMetotDemo;

public class Program
{
    public static void Main(string[] args)
    {
        //Müşteri class'ından nesne oluşturuldu ve farklı kullanımlarla müşteriler oluşturuldu. 
        Musteri musteri1 = new Musteri();

        musteri1.Id = 1;
        musteri1.Ad = "Niyazi";
        musteri1.Soyad = "Başkurt";

        Musteri musteri2 = new Musteri() { Id = 2, Ad = "Alperen", Soyad = "Başkurt" };         //Parametresiz constructorı çağırır 
        Musteri musteri3 = new Musteri { Id = 3, Ad = "Ali", Soyad = "Başkurt" };               //Parametresiz burası da 
        Musteri musteri4 = new Musteri(4, "Ömer Taha", "Başkurt");                              //Parametreli contructorı çağırır

        //Console.WriteLine(musteri4.Ad + " " + musteri4.Soyad);                      // Parametreli constructor içerisinde yapılan atamadan dolayı burası çalıştı

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