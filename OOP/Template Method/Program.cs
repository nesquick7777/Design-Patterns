using Template_Method;

namespace TemplateMethod
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Game game = new Slapsgiving(2);
            game.Play();
        }
    }
}



