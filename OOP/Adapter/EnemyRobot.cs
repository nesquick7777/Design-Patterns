using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EnemyRobot
    {
        Random random = new Random();

        public void smashWithHands()
        {
            int attackDamage = random.Next(1,10);

            Console.WriteLine("Enemy Robot causes " + attackDamage + " with it hands");

        }

        public void moveForward()
        {
            int movement = random.Next(1,5);

            Console.WriteLine("Enemy Robot moves " + movement + " spaces");
        }

        public void reactToHuman(string driverName)
        {
            Console.WriteLine("Enemy Robot tramps on " + driverName);
        }

    }
}
