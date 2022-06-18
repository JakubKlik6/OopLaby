using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class Figure
    {
        protected double width;     //protected - daje możlwiość dziedziczenia

        public Figure(double width)
        {
            this.width = width;
        }

        public virtual void Draw()      //virtual - daje dostęp do nadpisywania
        {
            Console.WriteLine("I'm shape");
        }
    }
}
