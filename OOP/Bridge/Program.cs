namespace Bridge
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            RemoteButton theTv = new TvRemoteMute(new TvDevice(200,1));

            RemoteButton theTv2 = new TvRemotePause(new TvDevice(200, 1));

            Console.WriteLine("Test Tv with mute");

            theTv.buttonFivePressed();
            theTv.buttonSixPressed();
            theTv.buttonNinePressed();

            Console.WriteLine("Test Tv with pause");
            theTv2.buttonFivePressed();
            theTv2.buttonSixPressed();
            theTv2.buttonSixPressed();
            theTv2.buttonSixPressed();
            theTv2.buttonSixPressed();
            theTv2.buttonNinePressed();
            theTv2.deviceFeedback();
        }
    }
}