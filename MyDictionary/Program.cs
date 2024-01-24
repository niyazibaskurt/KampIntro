using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Dictionary oluşturma - Anahtar/Değer kümesi
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();

        //Anahtar-Değer ekleme
        myDictionary.Add("Anahtar1", 50);
        myDictionary.Add("Anahtar2", 100);
        myDictionary["Anahtar3"] = 150;     //Alternatif olarak anahtar-değer ekleme yöntemi
        myDictionary["Anahtar4"] = 200;

        //Değerlere erişim
        int deger1 = myDictionary["Anahtar1"];
        Console.WriteLine($"Anahtar1'in değeri: {deger1}");

        //Tüm anahtar ve değerlere erişim
        foreach (var anahtar in myDictionary.Keys)
        {
            int deger = myDictionary[anahtar];
            Console.WriteLine($"{anahtar} : {deger}");
        }

        //Belirli bir anahtarı içerip içermediğini kontrol etme
        bool anahtarVarMi = myDictionary.ContainsKey("Anahtar2");
        Console.WriteLine($"Anahtar2 Var Mı? : {anahtarVarMi}");

        //Belirli bir değeri içerip içermediğini kontrol etme
        bool degerVarMi = myDictionary.ContainsValue(50);
        Console.WriteLine($"Değer 15 Var Mı? {degerVarMi}");

        //Dictionary'den bir anahtar-değer çiftini kaldırma
        myDictionary.Remove("Anahtar1");

        //Tüm anahtar-değer çiftlerini temizleme
        myDictionary.Clear();
    }
}
