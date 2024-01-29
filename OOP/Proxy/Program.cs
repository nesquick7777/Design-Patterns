using Proxy;

namespace Singleton
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            IImage cat = new HighResolutionImage("");
            IImage proxyCat = new ImageProxy("");

            Console.WriteLine(DateTime.Now); 
            cat.ShowImage();
            Console.WriteLine("\n"+DateTime.Now); 
            proxyCat.ShowImage();
        }
    }
}



