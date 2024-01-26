using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface RobotBuilder
    {
        public void buildRobotHead();
        public void buildRobotTorso();
        public void buildRobotArms();
        public void buildRobotLegs();

        public Robot getRobot();

    }
}
