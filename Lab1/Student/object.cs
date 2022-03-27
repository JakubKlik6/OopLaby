using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jakub", "Klik", 5, 5);

            Console.WriteLine(student.ToString());

            Console.ReadKey(true);
        }

    }
}
