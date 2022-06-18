using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    abstract class Banker
    {
        protected string name;

        public Banker(string name)
        {
            this.name = name;
        }

        public abstract float Count(float x, float y);
        public override string ToString()
        {
            return name;
        }

    }
}
