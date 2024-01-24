
using System.Collections.Concurrent;

string[] isimler = new string[] { "Niyazi", "Ali", "Alperen", "Ömer Taha" };

List<string> isimler2 = new List<string> { "Niyazi", "Ali", "Alperen", "Ömer Taha" };

Console.WriteLine(isimler2[0]);
Console.WriteLine(isimler2[1]);
Console.WriteLine(isimler2[2]);
Console.WriteLine(isimler2[3]);

Console.WriteLine("--------------------");
isimler2.Add("Muharrem");

Console.WriteLine(isimler2[4]);
Console.WriteLine(isimler2[0]);

