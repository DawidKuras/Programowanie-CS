using System;

class BankAccount
{
    // Prywatne pole saldo
    private decimal saldo;

    // Wlasciwosc tylko do odczytu (brak set)
    public decimal Saldo
    {
        get { return saldo; }
    }

    // Wlasciwosc Wlasciciel (moze byc zwykla)
    public string Wlasciciel { get; set; }

    // Konstruktor z wlascicielem i saldem poczatkowym
    public BankAccount(string wlasciciel, decimal saldoPoczatkowe)
    {
        Wlasciciel = wlasciciel;

        if (saldoPoczatkowe < 0)
        {
            throw new ArgumentException("Saldo poczatkowe nie moze byc ujemne.");
        }

        saldo = saldoPoczatkowe;
    }

    // Metoda Wplata - zwieksza saldo
    public void Wplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wplaty musi byc dodatnia.");
            return;
        }

        saldo += kwota;
        Console.WriteLine("Wplacono: " + kwota + ". Nowe saldo: " + saldo);
    }

    // Metoda Wyplata - sprawdza saldo i zmniejsza
    public void Wyplata(decimal kwota)
    {
        if (kwota <= 0)
        {
            Console.WriteLine("Kwota wyplaty musi byc dodatnia.");
            return;
        }

        if (kwota > saldo)
        {
            Console.WriteLine("Brak wystarczajacych srodkow. Saldo: " + saldo);
            return;
        }

        saldo -= kwota;
        Console.WriteLine("Wyplacono: " + kwota + ". Nowe saldo: " + saldo);
    }
}

class Program
{
    static void Main()
    {
        // Przykladowe uzycie z tresci zadania
        BankAccount konto = new BankAccount("Jan Kowalski", 1000);
        konto.Wplata(500);
        konto.Wyplata(200);
        Console.WriteLine("Saldo: " + konto.Saldo);

        Console.WriteLine("Nacisnij Enter, aby zakonczyc.");
        Console.ReadLine();
    }
}
