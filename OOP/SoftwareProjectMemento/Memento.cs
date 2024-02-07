using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProjectMemento
{
    internal class Memento
    {
        public string TeamLead { get;}
        public int BugCount { get; }
        public int Cost { get; }

        public Memento(string teamLead, int bugCount, int cost) { this.TeamLead = teamLead;this.BugCount = bugCount;this.Cost = cost; }


    }
}
