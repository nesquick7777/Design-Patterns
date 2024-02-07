namespace CryptoObserver
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            BitCoin bitCoin = new BitCoin("Bitcoin", 1000);
            Investor rx580Owner = new Investor("RX 580 owner");
            Investor gtx1080Tiowner = new Investor("GTX 1080Ti owner");

            bitCoin.Attach(rx580Owner);
            bitCoin.Attach(gtx1080Tiowner);

            bitCoin.Price = 1010;
            bitCoin.Price = 1600;
            bitCoin.Detach(rx580Owner);
            bitCoin.Price = 1210;
            bitCoin.Price = 1300;
        }
    }
}



