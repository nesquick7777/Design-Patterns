namespace CarBuilder { 
internal static class CarBuilderTester
{
        [STAThread]
        public static void Main(string[] args)
    {
            

        CarBuilder carBuilder = new CarBuilder();
        Director director = new Director();
        director.ConstructPorsche(carBuilder);
        Car porsche = carBuilder.Build();
        Console.WriteLine(porsche);

    }
}
}