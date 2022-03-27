using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point punkt = new Point(10, 10);

            Console.WriteLine("Wczytywanie... \n" + punkt);

            punkt.Reset();

            Console.WriteLine("Zerowanie... \n" + punkt);

            punkt.Move(1,2);

            Console.WriteLine("Przesuwanie... \n" + punkt);

            Console.ReadKey(true);
        }

    }
}
