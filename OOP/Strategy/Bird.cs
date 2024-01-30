using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Bird : Animal
    {
        public Bird() {
            setSound("Chirps");
            flyingType = new ItFlys();
        }

    }
}
