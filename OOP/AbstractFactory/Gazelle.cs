namespace AbstractFactory
{
    internal class Gazelle : Herbivore
    {
        public override void Eat()
        {
            Console.WriteLine(this.GetType().Name + ": I love eating savanna grass.");
        }
    }
}