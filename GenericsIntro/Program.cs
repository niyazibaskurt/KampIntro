using GenericsIntro;

MyList<string> isimler = new MyList<string>();
isimler.Add("Niyazi");
Console.WriteLine(isimler.Length);

isimler.Add("Alperen");
Console.WriteLine(isimler.Length);

foreach (var item in isimler.Items)
{
    Console.WriteLine(item);
}