using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestMembersComposite
{
    internal class Party : IQuestMember
    {
        List<IQuestMember> partyMembers;
        public string Name {get; private set;}

        public Party (string name)
        {
            this.partyMembers = new List<IQuestMember> ();
            Name = name;
        }

        public void AddMember(IQuestMember member)
        {
            this.partyMembers.Add(member);
        }

        public Damage TotalDamge { get { 
            
                Damage totalDamage = new Damage();
                foreach (IQuestMember member in partyMembers)
                {

                    totalDamage += member.TotalDamge;
                }
                    return totalDamage; }
            } 
        }
    }

