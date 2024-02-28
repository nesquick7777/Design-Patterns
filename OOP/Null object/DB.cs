using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Null_object
{
    internal class DB
    {
        public static Employee GetEmployee(String s)
        {
            return Employee.NULL;
        }
    }
}
