using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Musteri
    {
        public Musteri()
        {

        }

        public Musteri(int id, string ad, string soyad)
        {
            //Console.WriteLine("İnstance oluşturulunca önce Parametre alan yapıcı metot çalıştı");
            //Console.WriteLine("--------------------------------");

            Id = id;
            Ad = ad;
            Soyad = soyad;
        }
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
