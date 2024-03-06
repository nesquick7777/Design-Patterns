namespace AbstractFactory
{
    internal class GranadaHare : Herbivore
    {
        public override void Eat()
        {
            Console.WriteLine(this.GetType().Name + ": I love eating your flowers.");
        }

    }
}