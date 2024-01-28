using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal interface EnemyAttacker
    {
        public void fireWeapon();
        public void driveForward();
        public void assignDriver(string driverName);
    }
}
