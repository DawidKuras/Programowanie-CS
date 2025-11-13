using System;

class Program
{
    // Program w nieskończoność pyta o liczby aż do podania ujemnej
    static void Main()
    {
        while (true) // pętla nieskończona
        {
            Console.Write("Podaj liczbe calkowita: ");
            int x = int.Parse(Console.ReadLine());

            if (x < 0)
            {
                Console.WriteLine("Wprowadzono liczbe ujemna. Koniec programu.");
                break; // przerwanie pętli
            }

            Console.WriteLine("Podales: " + x);
        }
    }
}
