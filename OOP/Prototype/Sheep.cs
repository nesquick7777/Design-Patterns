using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    internal class Sheep : Animal
    {
        public Sheep()
        {
            Console.WriteLine("Sheep is made");
        }
        public object Clone()
        {
            throw new NotImplementedException();
        }

        public Animal makeCopy()
        {
            Console.WriteLine("Sheep is being made");

            Sheep sheepObject = null;

            sheepObject = (Sheep) base.MemberwiseClone();

            return sheepObject;
        }

        public String toString()
        {
            return "Dolly is a sheep bee";
        }
    }
}
