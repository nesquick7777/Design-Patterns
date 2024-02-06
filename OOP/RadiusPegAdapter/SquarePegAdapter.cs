using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadiusPegAdapter
{
    internal class SquarePegAdapter : IRound
    {
        SquarePeg squarePeg;
        public SquarePegAdapter(SquarePeg squarePeg)
        {
            this.squarePeg = squarePeg;
        }

        public double GetRadius()
        {
            return Math.Sqrt(2* squarePeg.GetWidth() * squarePeg.GetWidth())/2;
        }
    }
}
