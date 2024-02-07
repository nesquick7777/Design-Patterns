using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareProjectMemento
{
    internal class SoftwareProject
    {
        public string TeamLead { get; set; }
        public int BugCount { get; set; }
        public int Cost { get; set; }

        public Memento Store() { return new Memento(this.TeamLead, this.BugCount, this.Cost); }
        public void Restore(Memento memento)
        {
            this.TeamLead = memento.TeamLead;
            this.BugCount = memento.BugCount;
            this.Cost = memento.Cost;
        }

        public override string ToString()
        {
            return this.TeamLead + ", " +this.BugCount + ", " + this.Cost; 
        }
    }
}
