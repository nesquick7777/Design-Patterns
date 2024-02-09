using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class DivideNumbers : IChain
    {
        private IChain nextInChain;
    public void setNextChain(IChain nextChain)
        {

            nextInChain = nextChain;

        }

    public void calculate(Numbers request)
        {

            if (request.getCalcWanted() == "div")
            {

                Console.WriteLine(request.getNumber1() + " / " + request.getNumber2() + " = " +
                        (request.getNumber1() / request.getNumber2()));

            }
            else
            {

                Console.WriteLine("Only works for add, sub, mult, and div");

            }
        }
    }
}
