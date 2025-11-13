using System;

class Program
{
    // Program sortuje n liczb metodą bąbelkową
    static void Main()
    {
        Console.Write("Ile liczb chcesz wprowadzic? ");
        int n = int.Parse(Console.ReadLine());

        int[] t = new int[n];

        // Wczytywanie liczb
        for (int i = 0; i < n; i++)
        {
            Console.Write("t[" + i + "] = ");
            t[i] = int.Parse(Console.ReadLine());
        }

        // Sortowanie bąbelkowe
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (t[j] > t[j + 1])
                {
                    int temp = t[j];
                    t[j] = t[j + 1];
                    t[j + 1] = temp;
                }
            }
        }

        // Wynik
        Console.WriteLine("Posortowane liczby:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(t[i] + " ");
        }
    }
}
