using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class EnemyRobotAdapter : EnemyAttacker
    {

        EnemyRobot theRobot;

        public EnemyRobotAdapter(EnemyRobot newRobot)
        {
            theRobot = newRobot;
        }

        public void fireWeapon()
        {
            theRobot.smashWithHands();
        }

        public void driveForward()
        {
            theRobot.moveForward();
        }

        public void assignDriver(string driverName)
        {
            theRobot.reactToHuman(driverName);
        }

    }
}
