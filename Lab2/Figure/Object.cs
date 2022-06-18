using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(34);
            figure.Draw();

            Line line = new Line(654);
            line.Draw();

            Square square = new Square(233);
            square.Draw();
        }

    }
}   
