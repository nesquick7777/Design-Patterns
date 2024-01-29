using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Mozzarella : ToppingDecorator
    {
        public Mozzarella(Pizza newPizza) : base(newPizza)
        {
            
            Console.WriteLine("Adding Mozzarella to Pizza");
        }

        override public double getCost()
        {
            return tempPizza.getCost() + 0.50;
        }

        override public string getDescription()
        {
            return tempPizza.getDescription() + ", Mozzarella";
        }
    }
}
