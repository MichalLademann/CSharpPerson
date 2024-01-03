using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObiektoweCSharp
{
    public class person
    {

        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public char Plec { get; set; }
        public DateTime DataUrodzenia { get; set; }


        public person(string imie, string nazwisko, char plec, DateTime dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Plec = plec;
            DataUrodzenia = dataUrodzenia;
        }

        public void WyswietlInformacje()
        {
            Console.WriteLine($"Imię: {Imie}");
            Console.WriteLine($"Nazwisko: {Nazwisko}");
            Console.WriteLine($"Płeć: {Plec}");
            Console.WriteLine($"Data urodzenia: {DataUrodzenia.ToShortDateString()}");
        }
    }
}

  