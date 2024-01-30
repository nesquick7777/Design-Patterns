using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class TaxVisitor : Visitor
    {

        public TaxVisitor() { } 

        public double visit(Liquor liquorItem)
        {
            Console.WriteLine("Liquor item: Price with Tax");
            return (liquorItem.getPrice() * .18) + liquorItem.getPrice();
        }

        public double visit(Tobacco tobaccoItem)
        {
            Console.WriteLine("Liquor item: Price with Tax");
            return (tobaccoItem.getPrice() * .32) + tobaccoItem.getPrice();
        }

        public double visit(Necessity necessityItem)
        {
            Console.WriteLine("Liquor item: Price with Tax");
            return (necessityItem.getPrice() * .0) + necessityItem.getPrice();
        }
    }
}
