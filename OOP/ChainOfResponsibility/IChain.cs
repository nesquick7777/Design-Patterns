using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal interface IChain
    {
        public void setNextChain(IChain nextChain);

        public void calculate(Numbers request);
    }
}
