using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestMembersComposite
{
    internal class Player : IQuestMember
    {
        public string Name { get; private set; }

        public Damage TotalDamge { get;private set; }

        public Player(string name, Damage damage) {
            this.Name = name;
            this.TotalDamge = damage;
        }
    }
}
