using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Line : Figure
    {
        public Line(double width) : base(width) //dziedziczenie
        {}

        public override void Draw()
        {
            for(int i = 1; i <= this.width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }


    }
}
