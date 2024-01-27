using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class TvDevice : EntertainmentDevice
    {

        public TvDevice(int newMaxSetting, int newDeviceState)
        {
            deviceState = newDeviceState;
            maxSetting = newMaxSetting;
        }

        public override void buttonFivePressed()
        {
            Console.WriteLine("Channel Down");

            deviceState--;
        }

        public override void buttonSixPressed()
        {
            Console.WriteLine("Channel Up");
            deviceState++;
        }
    }
}
