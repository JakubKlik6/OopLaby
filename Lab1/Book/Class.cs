using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1
{
    class Book

    {
        private string name, title;
        private bool borrowed;

        public Book(string name,string title, bool borrowed)
        {
            this.name = name;
            this.title = title;
            this.borrowed = borrowed;
        }
        public override string ToString()
        {
            return $"Name: {name}\nTitle: {title}\nBorrowed: {borrowed} ";
        }

    }

}
