using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface IFlys
    {
        string fly();
    }

    internal class ItFlys : IFlys
    {
        public string fly()
        {
            return "Flying high";
        }
    }

    internal class CantFly : IFlys
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}
