namespace Singleton
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Mozak mozak = Mozak.GetMozak();
            mozak.LiftLeftArm();
        }
    }
}

    

