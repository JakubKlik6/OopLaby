using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            Book book2 = new Book();
            book2.title = "LoTR";
            book2.author = "Tolkein";
            book2.pages = 700;

            Console.WriteLine(book1.title, book1.author, book1.pages);

            Console.ReadKey(true);
        }
    }
}


//class

using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Book
    {
        public string title, author;
        public int pages;               //class atribiute
    }


}
