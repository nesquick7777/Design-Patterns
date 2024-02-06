using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusPegAdapter
{
    internal class RoundHole : IRound
    {

        private double radius;

        public RoundHole(double radius)
        {
            this.radius = radius;
        }

        public double GetRadius()
        {
            return radius;
        }

        public bool WillItFit(IRound peg)
        {
            return this.GetRadius() >= peg.GetRadius();
        }
    }
}
