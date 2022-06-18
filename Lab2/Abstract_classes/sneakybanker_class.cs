using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class SneakyBaker : Banker
    {
        public SneakyBaker(string name) : base(name){}

        public override float Count(float x, float y)
        {
            return (x + y) * 0.8f;
        }
    }
}
