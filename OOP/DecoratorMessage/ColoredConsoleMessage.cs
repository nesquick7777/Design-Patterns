using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMessage
{
    internal class ColoredConsoleMessage : ConsoleMessageDecorator
    {
        ConsoleColor color = ConsoleColor.Cyan;
        public ColoredConsoleMessage(IMessage message) : base(message) { }
        public override void Print()
        {
            Console.ForegroundColor = this.color;
            base.Print();
            Console.ResetColor();
        }
    }
}
