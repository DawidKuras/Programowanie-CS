using System;

class Licz
{
    // Pole value – prywatne
    private int value;

    // Konstruktor z jednym parametrem
    public Licz(int poczatkowaWartosc)
    {
        value = poczatkowaWartosc;
    }

    // Metoda dodajaca wartosc
    public void Dodaj(int x)
    {
        value += x;
    }

    // Metoda odejmujaca wartosc
    public void Odejmij(int x)
    {
        value -= x;
    }

    // Metoda wypisujaca stan obiektu
    public void WypiszStan()
    {
        Console.WriteLine("Aktualna wartosc: " + value);
    }
}

class Program
{
    static void Main()
    {
        // Tworzymy kilka obiektow Licz
        Licz a = new Licz(10);
        Licz b = new Licz(0);
        Licz c = new Licz(-5);

        // Wykonujemy operacje
        a.Dodaj(5);     // 10 + 5 = 15
        a.Odejmij(3);   // 15 - 3 = 12
        a.WypiszStan();

        b.Dodaj(100);
        b.WypiszStan();

        c.Odejmij(10);  // -5 - 10 = -15
        c.WypiszStan();

        Console.WriteLine("Nacisnij Enter, aby zakonczyc.");
        Console.ReadLine();
    }
}
