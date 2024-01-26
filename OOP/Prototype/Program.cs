namespace Prototype
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            CloneFactory animalMaker = new CloneFactory();

            Sheep sally = new Sheep();

            Sheep clonedSheep = (Sheep) animalMaker.getClone(sally);

            Sheep clonedSheep2 = (Sheep)sally.makeCopy();


            Console.WriteLine(sally);

            Console.WriteLine(clonedSheep);
            Console.WriteLine(clonedSheep2);

            Console.WriteLine(sally.GetHashCode());
            Console.WriteLine(clonedSheep.GetHashCode());
            Console.WriteLine(clonedSheep2.GetHashCode());
        }
    }
}