namespace AbstractFactory
{
    internal class AnimalWorld
    {
        private Herbivore herbivore;
        private Carnivore carnivore;
        // Constructor
        public AnimalWorld(ContinentFactory factory)
        {
            carnivore = factory.CreateCarnivore();
            herbivore = factory.CreateHerbivore();
        }
        public void RunFoodChain()
        {
            herbivore.Eat();
            carnivore.Eat(herbivore);
        }
    }
    }