using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestMembersComposite
{
    internal interface IQuestMember
    {
        string Name { get; }
        Damage TotalDamge { get; }
    }
}
