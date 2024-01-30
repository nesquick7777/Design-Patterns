using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface Visitor
    {
        public double visit(Liquor liquorItem);
        public double visit(Tobacco tobacco);

        public double visit(Necessity necessity);
    }
}
