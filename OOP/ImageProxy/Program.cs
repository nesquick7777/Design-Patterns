namespace ImageProxy
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            ImageProxy imageProxy = new ImageProxy("bleh");
            imageProxy.ShowImage();
        }
    }
}



