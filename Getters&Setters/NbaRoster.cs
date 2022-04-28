using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Player kuba = new Player("Jakub","Slasher",5.9);
            Player boston = new Player("Mateusz", "PG", 6.1);

            Console.WriteLine(kuba.ToString());
            Console.WriteLine(" ");
            Console.WriteLine(boston.ToString());



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
    class Player
    {
        private string name,position; //only code inside this class is able to acess these
        private double height;

        public Player(string aName, string aPosition, double aHeigh)
        {
            name = aName;
            Position = aPosition;
            height = aHeigh;
        }

        public string Position        // seting rating 
        {
            get { return position; }     //getter
            set                        //setter
            {
                if (value == "PG" || value == "SG" || value == "C")
                {
                    position = value;

                }
                else { position = "Not interested"; }
            }
        }


        public override string ToString()
        {
            return $"Imie: {name} \nPozycja: {position} \nWzrost: {height}";
        }
    }
}
