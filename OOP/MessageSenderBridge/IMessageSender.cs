using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSenderBridge
{
    internal interface IMessageSender
    {
        public void SendMessage(String subject, String body);
    }
}
