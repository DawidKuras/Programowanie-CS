using System;

class Sumator
{
    // Prywatne pole - tablica liczb
    private int[] liczby;

    // Konstruktor
    public Sumator(int[] liczby)
    {
        this.liczby = liczby;
    }

    // Metoda Suma - suma wszystkich elementow
    public int Suma()
    {
        int suma = 0;
        for (int i = 0; i < liczby.Length; i++)
        {
            suma += liczby[i];
        }
        return suma;
    }

    // Metoda SumaPodziel2 - suma liczb podzielnych przez 2
    public int SumaPodziel2()
    {
        int suma = 0;
        for (int i = 0; i < liczby.Length; i++)
        {
            if (liczby[i] % 2 == 0)
            {
                suma += liczby[i];
            }
        }
        return suma;
    }

    // Metoda IleElementow - ile elementow jest w tablicy
    public int IleElementow()
    {
        return liczby.Length;
    }

    // Metoda wypisujaca wszystkie elementy
    public void WypiszWszystkie()
    {
        Console.Write("Wszystkie liczby: ");
        for (int i = 0; i < liczby.Length; i++)
        {
            Console.Write(liczby[i] + " ");
        }
        Console.WriteLine();
    }

    // Metoda wypisujaca elementy z zakresu indeksow [lowIndex, highIndex]
    public void WypiszZakres(int lowIndex, int highIndex)
    {
        // Poprawiamy indeksy, zeby nie wychodzily poza tablice
        if (lowIndex < 0)
        {
            lowIndex = 0;
        }
        if (highIndex >= liczby.Length)
        {
            highIndex = liczby.Length - 1;
        }

        // Jesli zakres jest "odwrocony", nic nie wypisujemy
        if (lowIndex > highIndex)
        {
            Console.WriteLine("Zakres jest pusty.");
            return;
        }

        Console.Write("Liczby od indeksu " + lowIndex + " do " + highIndex + ": ");
        for (int i = lowIndex; i <= highIndex; i++)
        {
            Console.Write(liczby[i] + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        // Przykladowa tablica
        int[] dane = { 1, 2, 3, 4, 5, 6 };

        Sumator s = new Sumator(dane);

        s.WypiszWszystkie();

        Console.WriteLine("Suma wszystkich: " + s.Suma());
        Console.WriteLine("Suma liczb podzielnych przez 2: " + s.SumaPodziel2());
        Console.WriteLine("Liczba elementow: " + s.IleElementow());

        // Przykladowe zakresy
        s.WypiszZakres(1, 4);   // elementy o indeksach 1..4
        s.WypiszZakres(-5, 2);  // poprawi lowIndex na 0
        s.WypiszZakres(3, 100); // poprawi highIndex na ostatni element

        Console.WriteLine("Nacisnij Enter, aby zakonczyc.");
        Console.ReadLine();
    }
}
