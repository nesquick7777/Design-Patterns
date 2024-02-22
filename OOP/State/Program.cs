namespace State
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Order blackFridayOrder = new Order(new NewState());
            blackFridayOrder.Customer = "John Doe";
            blackFridayOrder.Id = "ID123494";
            Console.WriteLine(blackFridayOrder);
            Console.WriteLine("Can cancel: " + blackFridayOrder.CanCancel());
            Console.WriteLine("Can ship: " + blackFridayOrder.CanShip());
            blackFridayOrder.Ship();
            Console.WriteLine(blackFridayOrder);
            Console.WriteLine("Can cancel: " + blackFridayOrder.CanCancel());
            Console.WriteLine("Can ship: " + blackFridayOrder.CanShip());

        }
    }
}



