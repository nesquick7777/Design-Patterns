using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class EntertainmentDevice
    {
        public int deviceState;

        public int maxSetting;

        public int volumeLevel = 0;

        public abstract void buttonFivePressed();
        public abstract void buttonSixPressed();

        public void deviceFeedback()
        {
            if (deviceState < 0 || deviceState > maxSetting) {

                deviceState = 0;

                Console.WriteLine("On device state: " + deviceState);
            }
        }

        public void buttonSevenPressed()
        {
            volumeLevel++;

            Console.WriteLine("Volume at: " + volumeLevel);
        }

        public void buttonEightPressed()
        {
            volumeLevel--;

            Console.WriteLine("Volume at: " + volumeLevel);
        }

    }
}
