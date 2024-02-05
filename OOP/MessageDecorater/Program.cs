using System.Numerics;

namespace MessageDecorater
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            IMessage simple = new ConsoleMessager("Demo text");
            IMessage colored = new ColoredConsoleMessage(simple);
            IMessage entitled = new EntitledConsoleMessage("Title",simple);
            IMessage coloredEntitled = new EntitledConsoleMessage("Title", colored);
            IMessage entitldColored = new ColoredConsoleMessage(entitled);

            simple.Print();
            colored.Print();
            entitled.Print();
            coloredEntitled.Print();
            entitldColored.Print();
            

        }
    }
}



