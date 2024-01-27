using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    internal class TvRemoteMute : RemoteButton
    {
        public TvRemoteMute(EntertainmentDevice newDevice) : base(newDevice)
        {
        }

        public override void buttonNinePressed()
        {
            Console.WriteLine("Tv was muted");
        }
    }
}
