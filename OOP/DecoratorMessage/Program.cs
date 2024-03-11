namespace DecoratorMessage
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            IMessage simple = new ConsoleMessage("A demo message");
            IMessage colored = new ColoredConsoleMessage(simple);
            IMessage entitled = new EntitledConsoleMessage("Title", simple);
            IMessage colorEntitled = new EntitledConsoleMessage("Title and color", colored);
            IMessage entitledColor = new ColoredConsoleMessage(entitled);
            simple.Print();
            colored.Print();
            entitled.Print();
            colorEntitled.Print();
            entitledColor.Print();

        }
    }
}



