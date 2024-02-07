namespace SortingStrategy
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            ISortStrategy ascStrategy = new SortAscending();
            List<String> students = new List<String>() { "Bojan", "Dejan", "Marko"};
            ProgrammingClass rppoon = new ProgrammingClass(ascStrategy,students);

            rppoon.Sort();
            Console.WriteLine(rppoon);
            rppoon.Strategy = new SortDescending();
            rppoon.Sort(); Console.WriteLine(rppoon);
        }
    }
}



