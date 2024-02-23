using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    internal class Iterator : IAbstractIterator
    {
        private Shelter shelter;
        private int current;
        public Iterator(Shelter shelter) { this.shelter = shelter; this.current = 0; }
        public Dog CurrentDog { get { return this.shelter[current]; } }
        public bool IsDone { get { return this.current >= this.shelter.Count; } }
        public Dog First() { return this.shelter[0]; }
        public Dog Next()
        {
            current++;
            if (!IsDone)
            {
                return this.shelter[current];
            }
            else
            {
                return null;
            }
        }
    }
}
