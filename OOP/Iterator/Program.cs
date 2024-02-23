namespace Iterator
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Shelter shelter = new Shelter();
            shelter.Add(new Dog("Lassie")); shelter.Add(new Dog("Odie"));
            shelter.Add(new Dog("Toto")); shelter.Add(new Dog("Rex"));
            IAbstractIterator iterator = shelter.CreateIterator();
            for (Dog dog = iterator.First(); iterator.IsDone == false; dog = iterator.Next())
            {
                Console.WriteLine(dog.Name);
            }

        }
    }
}



