using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal abstract class ToppingDecorator : Pizza
    {
        protected Pizza tempPizza;

        public ToppingDecorator(Pizza newPizza)
        {
            tempPizza = newPizza;
        }

        

        public virtual double getCost()
        {
            return tempPizza.getCost();
        }

        public virtual string getDescription()
        {
            return tempPizza.getDescription(); 
        }
    }
}
