using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "isimli müşteri eklendi");
            Console.WriteLine("--------------------------------");
        }

        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + " isimli müşteri silindi");
            Console.WriteLine("--------------------------------");
        }

        public void GetAllMusteriList(List<Musteri> musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " " + "isimli müşteri listelendi");
            }
        }
    }
}
