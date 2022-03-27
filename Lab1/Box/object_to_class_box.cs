using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(10, 10, 10);

            Console.WriteLine(box.ToString());

            Console.WriteLine("Volume \n" + box.Volume());

            Console.ReadKey(true);
        }

    }
}
