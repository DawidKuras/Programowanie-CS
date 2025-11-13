using System;

class Program
{
    // Program oblicza delte i pierwiastki równania kwadratowego
    static void Main()
    {
        Console.WriteLine("Program oblicza delte oraz pierwiastki równania ax^2 + bx + c");

        Console.Write("Podaj a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Podaj b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Podaj c: ");
        double c = double.Parse(Console.ReadLine());

        // Obliczamy delte
        double delta = b * b - 4 * a * c;
        Console.WriteLine("Delta = " + delta);

        if (delta < 0)
        {
            Console.WriteLine("Brak pierwiastkow rzeczywistych.");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine("Jeden pierwiastek: " + x);
        }
        else
        {
            double sqrtD = Math.Sqrt(delta);
            double x1 = (-b - sqrtD) / (2 * a);
            double x2 = (-b + sqrtD) / (2 * a);

            Console.WriteLine("x1 = " + x1);
            Console.WriteLine("x2 = " + x2);
        }
    }
}
