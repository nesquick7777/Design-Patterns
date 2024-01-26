using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal interface RobotPlan
    {
        public void setRobotHead(string head);
        public void setRobotTorso(string torso);
        public void setRobotArms(string arms);
        public void setRobotLegs(string legs);

    }
}
