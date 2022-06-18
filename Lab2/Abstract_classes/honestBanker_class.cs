using System;
using System.Collections.Generic;
using System.Text;

namespace Programowanie
{
    class HonestBanker : Banker
    {
        public HonestBanker(string name) : base(name) { }

        public override float Count(float x, float y)
        {
            return x + y;

        }
    }
}
