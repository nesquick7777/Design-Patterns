using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    internal class SoftwareProject
    {
        public String TeamLead { get; set; }
        public int Cost { get; set; }
        public int BugCount { get; set; }

        public Memento Store()
        {
            return new Memento(TeamLead,BugCount,Cost);
        }

        public void Restore(Memento memento)
        {
            this.TeamLead = memento.TeamLead;
            this.Cost = memento.Cost;
            this.BugCount = memento.BugCount;

        }

        public override String ToString() { return TeamLead + ", " + BugCount + ", " + Cost; }
    }
}
