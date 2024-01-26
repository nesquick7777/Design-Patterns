using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    internal class Robot : RobotPlan
    {
        private String robotHead;
        private String robotTorso;
        private String robotArms;
        private String robotLegs;

        public string getRobotArms() { return robotArms; }

        public void setRobotArms(string arms)
        {
            robotArms = arms;
        }

        public string getRobotHead() { return robotHead; }

        public void setRobotHead(string head)
        {
            robotHead = head;
        }

        public string getRobotTorso() { return robotTorso; }

        public void setRobotLegs(string legs)
        {
            robotLegs = legs;
        }

        public String getRobotLegs() {  return robotLegs; }

        public void setRobotTorso(string torso)
        {
            robotTorso = torso;
        }
    }
}
