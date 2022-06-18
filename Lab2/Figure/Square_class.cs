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
            for (int i = 1; i <= this.width; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
    }


}
