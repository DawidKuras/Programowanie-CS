using System;

class Program
{
    // Program wprowadza 10 liczb i oblicza sumę, iloczyn, średnią, min i max
    static void Main()
    {
        double[] liczby = new double[10];

        // Wprowadzanie liczb
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Podaj liczbe [" + i + "]: ");
            liczby[i] = double.Parse(Console.ReadLine());
        }

        double suma = 0;
        double iloczyn = 1;
        double min = liczby[0];
        double max = liczby[0];

        // Obliczenia
        for (int i = 0; i < 10; i++)
        {
            suma += liczby[i];
            iloczyn *= liczby[i];

            if (liczby[i] < min) min = liczby[i];
            if (liczby[i] > max) max = liczby[i];
        }

        double srednia = suma / 10;

        // Wyniki
        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Iloczyn: " + iloczyn);
        Console.WriteLine("Srednia: " + srednia);
        Console.WriteLine("Min: " + min);
        Console.WriteLine("Max: " + max);
    }
}
