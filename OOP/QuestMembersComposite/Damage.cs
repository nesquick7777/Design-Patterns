using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestMembersComposite
{
    internal class Damage
    {
        public int Physical { get; private set; }
        public int Magical { get; private set; }

        public Damage() { }

        public Damage(int physical, int magical)
        {
            this.Physical = physical;
            this.Magical = magical;
        }


        public static Damage operator + (Damage lhs, Damage rhs)
        {
            return new Damage(lhs.Physical + rhs.Physical, lhs.Magical + rhs.Magical);
        }

        public override string ToString()
        {
            return "P: " + this.Physical + ", M: " + this.Magical;
        }
    }
}
