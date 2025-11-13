using System;

class Program
{
    // Program wypisuje liczby od 20 do 0, pomija wybrane przy użyciu continue
    static void Main()
    {
        for (int i = 20; i >= 0; i--)
        {
            // Pomiń wybrane liczby
            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
            {
                continue; // pomiń resztę pętli i idź dalej
            }

            Console.WriteLine(i);
        }
    }
}
