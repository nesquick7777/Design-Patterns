using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageSenderBridge
{
    internal class UserMessage : Message
    {
        public String UserComment { get; set; }

        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body+ "\nUserComments: " + UserComment);
        }
    }
}
