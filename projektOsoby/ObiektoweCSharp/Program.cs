
using ObiektoweCSharp;

internal class Program
{
    static void Main()
    {
        person mojaOsoba = new person("Jan", "Kowalski", 'M', new DateTime(1990, 5, 15));

        mojaOsoba.WyswietlInformacje();

        Console.ReadKey();
    }
}
