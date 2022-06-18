using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Rectangle : Figure
    {
        private double height;

        public Rectangle(double width, double height) : base(width)
        {
            this.height = height;
        }

        public override void Draw()
        {
            Console.WriteLine();
            for (int i = 0; i < this.width; i++)
            {
                for (int j = 0; j < this.height; j++)
                {
                    Console.Write("@ ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
    
}
