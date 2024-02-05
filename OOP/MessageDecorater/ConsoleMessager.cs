using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageDecorater
{
    internal class ConsoleMessager : IMessage
    {
        public string Text { get;private set; }

        public ConsoleMessager(string text)
        {
            this.Text = text;
        }

        public void Print()
        {
            Console.WriteLine(this.Text);
        }
    }
}
