using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class SubstractNumbers :IChain
    {
        private IChain nextInChain;
        
    public void setNextChain(IChain nextChain)
        {

            nextInChain = nextChain;

        }

        
    public void calculate(Numbers request)
        {

            if (request.getCalcWanted() == "sub")
            {

                Console.WriteLine(request.getNumber1() + " - " + request.getNumber2() + " = " +
                        (request.getNumber1() - request.getNumber2()));

            }
            else
            {

                nextInChain.calculate(request);

            }

        }
    }
}
