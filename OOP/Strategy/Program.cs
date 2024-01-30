using OOP;
using Strategy;

namespace Singleton
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Animal tweety = new Bird();
            Animal fido = new Dog();

            Console.WriteLine("Dog " + fido.tryToFly());

            Console.WriteLine("Bird " + tweety.tryToFly());

            fido.setFlyingAbillity(new ItFlys());
            Console.WriteLine("Dog " + fido.tryToFly());
        }
    }
}



