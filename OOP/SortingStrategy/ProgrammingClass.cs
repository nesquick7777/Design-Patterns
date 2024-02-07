using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SortingStrategy
{
    internal class ProgrammingClass
    {
        private List<String> Students { get; set; }
        public ISortStrategy Strategy{get; set; }
        public ProgrammingClass(ISortStrategy strategy, List<String> students) { this.Strategy=strategy; this.Students=students;}

        public void Add(String studentName) { Students.Add(studentName);}

        public void Sort() { this.Strategy.Sort(this.Students);}    

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach(String studentName in Students) { 
            builder = builder.Append(studentName+ Environment.NewLine);
            }
            return builder.ToString();
        }
    }
}
