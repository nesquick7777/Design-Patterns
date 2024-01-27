using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class TvRemotePause : RemoteButton
    {
        public TvRemotePause(EntertainmentDevice newDevice) : base(newDevice) { }

        public override void buttonNinePressed()
        {
            Console.WriteLine("Tv was paused");
        }

    }
}
