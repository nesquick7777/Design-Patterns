namespace AbstractFactory
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            // Create and run the African animal world
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();
            // Create and run the American animal world
            ContinentFactory europe = new EuropeFactory();
            world = new AnimalWorld(europe);
            world.RunFoodChain();

        }
    }
}



