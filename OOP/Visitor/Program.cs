namespace Visitor
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
           TaxVisitor visitor = new TaxVisitor();
            TaxHolidayVisitor holidayVisitor = new TaxHolidayVisitor();


            Necessity milk = new Necessity(3.47);
            Liquor vodka = new Liquor(11.99);
            Tobacco cigars = new Tobacco(19.99);

            Console.WriteLine(milk.accept(visitor));
            Console.WriteLine(vodka.accept(visitor));
            Console.WriteLine(cigars.accept(visitor));

            Console.WriteLine("Holiday time");
            Console.WriteLine(milk.accept(holidayVisitor));
            Console.WriteLine(vodka.accept(holidayVisitor));
            Console.WriteLine(cigars.accept(holidayVisitor));

        }
    }
}



