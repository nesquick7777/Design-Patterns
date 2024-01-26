using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Mozak
    {
        private static Mozak instance;
        private static readonly object padlock = new object();


        private Mozak() {
            Console.WriteLine("Mozak je kreiran");
        }

        public static Mozak GetMozak()
        {
            lock(padlock) {
                if (instance == null)
                {
                    instance = new Mozak();
                }

                return instance;
            }
            
        }


        public void LiftLeftArm()
        {
            Console.WriteLine("Left arm lifted.");
        }

    }
}
