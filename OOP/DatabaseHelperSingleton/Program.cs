// See https://aka.ms/new-console-template for more information
using DatabaseHelperSingleton;



namespace DatabaseHelperSingleton
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            DatabaseHelper helper = DatabaseHelper.GetInstance();
            List<User> users = helper.RetrieveAllUsers();
        }
    }
}



