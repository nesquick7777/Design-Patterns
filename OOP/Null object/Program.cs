using Null_object;

namespace NullObject
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Employee e = DB.GetEmployee("Alice");
            if (e.IsTimeToPay(new DateTime())) { Console.WriteLine("Payday."); }

        }
    }
}



