namespace AbstractFactory
{
    internal class AfricaFactory : ContinentFactory
    {
        public override Herbivore CreateHerbivore() { return new Gazelle(); }
        public override Carnivore CreateCarnivore() { return new Lion(); }
    }
}