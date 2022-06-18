using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Square : Figure
    {
        public Square(double width) : base(width) { }

        public override void Draw()
        {
            Console.WriteLine();
            for (int i = 1; i <= width; i++)
            {
                for (int j = 1; j <= width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
