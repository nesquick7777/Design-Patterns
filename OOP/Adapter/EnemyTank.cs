using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EnemyTank : EnemyAttacker
    {
        Random random = new Random();

        public void assignDriver(string driverName)
        {
            Console.WriteLine(driverName + " is driving the Tank");
        }

        public void driveForward()
        {
            int movement = random.Next(1, 5);

            Console.WriteLine("Enemy Tank moves " + movement + " Spaces");
        }

        public void fireWeapon()
        {
            int attackDamage = random.Next(1,10);

            Console.WriteLine("Enemy Tank deals " + attackDamage + " Damage");
        }
    }
}
