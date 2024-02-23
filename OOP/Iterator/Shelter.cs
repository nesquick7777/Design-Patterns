namespace Iterator
{
    internal class Shelter : IAbstractCollection
    {
        private List<Dog> dogs;
        public Shelter() { this.dogs = new List<Dog>(); }
        public IAbstractIterator CreateIterator() { return new Iterator(this); }
        public int Count { get { return this.dogs.Count; } }
        public void Add(Dog dog) { this.dogs.Add(dog); }
        public Dog this[int index] { get { return this.dogs[index]; } }

    }
}