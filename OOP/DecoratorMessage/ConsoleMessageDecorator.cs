using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMessage
{
    internal abstract class ConsoleMessageDecorator : IMessage
    {
        IMessage message;
        public ConsoleMessageDecorator(IMessage message)
        {
            this.message = message;
        }
        public virtual void Print()
        {
            message.Print();
        }

    }
}
