using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Dog : Animal
    {
        public Dog() {
            setSound("Bark");
        }

        public void digHole()
        {
            Console.WriteLine("Dug a hole");
        }


    }
}
