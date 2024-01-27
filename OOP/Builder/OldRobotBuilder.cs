using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class OldRobotBuilder : RobotBuilder
    {

        private Robot robot;

        public OldRobotBuilder()
        {
            this.robot = new Robot();
        }

        public void buildRobotArms()
        {
            robot.setRobotArms("Blowtorch Arms");
        }

        public void buildRobotHead()
        {
            robot.setRobotHead("Tin Head");
        }

        public void buildRobotLegs()
        {
            robot.setRobotLegs("Roller Skates");
        }

        public void buildRobotTorso()
        {
            robot.setRobotTorso("Tin Torso");
        }

        public Robot getRobot()
        {
            return robot;
        }
    }
}
