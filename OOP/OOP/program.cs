using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public static class program
    {
        [STAThread]
        public static void Main()
        {
            {
                Dog fido = new Dog();
                fido.setName("Fido");
                Console.WriteLine(fido.getName());
                fido.digHole();
            }
        }
    }
}
