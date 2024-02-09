namespace ChainOfResponsibility
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            IChain chainCalc1 = new AddNumbers();
            IChain chainCalc2 = new SubstractNumbers();
            IChain chainCalc3 = new MultiNumbers();
            IChain chainCalc4 = new DivideNumbers();


            chainCalc1.setNextChain(chainCalc2);
            chainCalc2.setNextChain(chainCalc3);
            chainCalc3.setNextChain(chainCalc4);

            Numbers request = new Numbers(4, 2, "add");

            chainCalc1.calculate(request);
        }
    }
}



