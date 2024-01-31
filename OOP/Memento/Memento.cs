using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class Memento
    {
        public String TeamLead { get; }
        public int Cost { get; }
        public int BugCount { get; }

        public Memento(String teamLead, int bugCount, int cost) { 
        
        this.TeamLead = teamLead;
        this.Cost = cost;
        this.BugCount = bugCount;
        }
    }
}
