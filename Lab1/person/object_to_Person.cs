using System;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("nowak", 21);

            //Person - klasa
            //person - obiekt

            person.getSalary();
            person.goShopping();

            Console.WriteLine(person.ToString());

            Console.ReadKey(true);
        }
        
    }
}
