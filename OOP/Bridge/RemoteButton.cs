using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal abstract class RemoteButton
    {
        private EntertainmentDevice theDevice;

        public RemoteButton(EntertainmentDevice newDevice)
        {
            theDevice = newDevice;
        }

        public void buttonFivePressed()
        {
            theDevice.buttonFivePressed();
        }

        public void buttonSixPressed()
        {
            theDevice.buttonSixPressed();
        }

        public void deviceFeedback()
        {
            theDevice.deviceFeedback();
        }

        public abstract void buttonNinePressed();

    }
}
