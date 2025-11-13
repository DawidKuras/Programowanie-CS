using System;

class Osoba
{
    // Prywatne pola
    private string imie;
    private string nazwisko;
    private int wiek;

    // Wlasciwosc Imie z walidacja (min 2 znaki)
    public string Imie
    {
        get { return imie; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
            {
                throw new ArgumentException("Imie musi miec co najmniej 2 znaki.");
            }
            imie = value;
        }
    }

    // Wlasciwosc Nazwisko z walidacja (min 2 znaki)
    public string Nazwisko
    {
        get { return nazwisko; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2)
            {
                throw new ArgumentException("Nazwisko musi miec co najmniej 2 znaki.");
            }
            nazwisko = value;
        }
    }

    // Wlasciwosc Wiek z walidacja (musi byc dodatni)
    public int Wiek
    {
        get { return wiek; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Wiek musi byc liczba dodatnia.");
            }
            wiek = value;
        }
    }

    // Konstruktor przyjmujacy wszystkie 3 wartosci
    public Osoba(string imie, string nazwisko, int wiek)
    {
        Imie = imie;          // uzywamy wlasciwosci, zeby dzialala walidacja
        Nazwisko = nazwisko;
        Wiek = wiek;
    }

    // Metoda wyswietlajaca informacje o osobie
    public void WyswietlInformacje()
    {
        Console.WriteLine("Osoba: {0} {1}, wiek: {2}", Imie, Nazwisko, Wiek);
    }
}

class Program
{
    static void Main()
    {
        // Przykladowe uzycie klasy Osoba
        Osoba o1 = new Osoba("Jan", "Kowalski", 30);
        o1.WyswietlInformacje();

        Console.WriteLine("Nacisnij Enter, aby zakonczyc.");
        Console.ReadLine();
    }
}
