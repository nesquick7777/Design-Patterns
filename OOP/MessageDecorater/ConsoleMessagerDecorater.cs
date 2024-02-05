using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageDecorater
{
    internal abstract class ConsoleMessagerDecorater : IMessage
    {

        IMessage message;

        public ConsoleMessagerDecorater(IMessage message)
        {
            this.message = message;
        }

        public virtual void Print()
        {
            message.Print();
        }
    }
}
