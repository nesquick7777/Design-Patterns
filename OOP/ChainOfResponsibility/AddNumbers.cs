﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class AddNumbers : IChain
    {
        private IChain nextInChain;

        // Defines the next Object to receive the
        // data if this one can't use it

        public void setNextChain(IChain nextChain)
        {

            nextInChain = nextChain;

        }

        // Tries to calculate the data, or passes it
        // to the Object defined in method setNextChain()

        public void calculate(Numbers request)
        {

            if (request.getCalcWanted() == "add")
            {

                Console.WriteLine(request.getNumber1() + " + " + request.getNumber2() + " = " +
                        (request.getNumber1() + request.getNumber2()));

            }
            else
            {

                nextInChain.calculate(request);

            }

        }
    }
}
