using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(Pizza newPizza) : base(newPizza)
        {
            
            Console.WriteLine("Adding TomatoSauce to Pizza");
        }

        override public double getCost()
        {
            return tempPizza.getCost() + 0.35;
        }

        override public string getDescription()
        {
            return tempPizza.getDescription() + ", TomatoSauce";
        }
    }
}
