using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class PlainPizza : Pizza
    {
        public PlainPizza() {
            Console.WriteLine("Adding Dough");
        }

        public double getCost()
        {
            return 4.00;
        }

        public string getDescription()
        {
            return "Thin Dough";
        }
    }
}
