using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Poter", "JK Rowling",400);
            Book book2 = new Book("Lord of the Rings", "Tolkein",700);

            book2.title = "The hobbit";

            Console.WriteLine(book2.title);

            Console.ReadKey(true);
        }
    }
}

//Class
using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Book
    {
        public string title, author;
        public int pages;

        public Book(string aTitle, string aAuthor,int aPages)       //contructor for Book class
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }


    }


}

