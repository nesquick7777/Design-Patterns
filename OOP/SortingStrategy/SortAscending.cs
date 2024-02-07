using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    internal class SortAscending : ISortStrategy
    {
        public void Sort(List<string> list)
        {
            list.Sort();
        }
    }
}
