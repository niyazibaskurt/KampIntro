﻿using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varış";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Pyhton";
            kurs3.Egitmen = "Niyazi BAŞKURT";
            kurs3.IzlenmeOrani = 64;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Ali BAŞKURT";
            kurs3.IzlenmeOrani = 98;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " Dersi: " + kurs.Egitmen + " tarafından verilmektedir.");
                Console.WriteLine("-------------------------------");
            }

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}


