using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto konto = new Konto("Jakub","12345678");

            konto.Deposit(1000);

            Console.WriteLine(konto);

            konto.Get(500);

            Console.WriteLine(konto);

            Console.ReadKey(true);
        }

    }
}
