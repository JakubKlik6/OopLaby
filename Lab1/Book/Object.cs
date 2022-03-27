using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Harry potter", " the Sorcerer's Stone", true);

            Console.WriteLine(book.ToString());

            Console.ReadKey(true);
        }

    }
}
