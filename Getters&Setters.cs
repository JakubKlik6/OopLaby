using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The avengers", "Joss Whedon", "PG-13");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //G, PG, Pg-13, R, NR -> rating 
            //How to make, that the only posibble ratings for the movies are one of these?

            Console.WriteLine(shrek.Rating);

            Console.ReadLine();
        }
    }
}


//Class

using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Movie
    {
        private string title, director, rating; //only code inside this class is able to acess these

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating;       //we are using capital R to get it through setting rating
        }

        public string Rating        // seting rating 
        {
            get { return rating; }     //getter
            set                        //setter
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR") 
                {
                    rating = value;

                }
                else { rating = "NR"; }
            }
        }
    }
}
