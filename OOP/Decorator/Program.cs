namespace Decorator
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {

            Pizza pizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine(pizza.getDescription());
            Console.WriteLine(pizza.getCost());
            
        }
    }
}