using System;
using System.Collections;
using Programowanie;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure(5);
            figure.Draw();

            Line line = new Line(5);
            line.Draw();

            Square square = new Square(10);
            square.Draw();

            Rectangle rectangle = new Rectangle(10,5);
            rectangle.Draw();
        }

    }
}   
