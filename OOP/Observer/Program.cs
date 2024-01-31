using System.Numerics;

namespace Observer
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            BitCoin bitCoin = new BitCoin("BCO",8000);
            Investor rx570owner = new Investor("rx570owner");
            Investor gtx1080Tiowner = new Investor("gtx1080Tiowner");
            bitCoin.Attach(rx570owner);
            bitCoin.Attach(gtx1080Tiowner);

            bitCoin.Price = 8010.00;
            bitCoin.Price = 8500.02;
            bitCoin.Detach(rx570owner);
            bitCoin.Price = 8710.54;
            bitCoin.Price = 9000.45;


        }
    }
}



