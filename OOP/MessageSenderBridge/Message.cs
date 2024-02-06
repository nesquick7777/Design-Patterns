using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSenderBridge
{
    internal abstract class Message
    {
        public string Subject { get; set; }
        public String Body { get; set; }

        public IMessageSender MessageSender { get; set; }

        public abstract void Send();
    }
}
