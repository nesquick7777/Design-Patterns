using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Person
    {
        public String Nick { get; private set; }
        public ChatRoom Room { get; set; }
        private List<String> chatLog = new List<String>();
        public Person(String nick) { Nick = nick; }
        public void Receive(string sender, string message)
        {
            String messageDisplay = String.Format("[{0} chat] {1}: {2}", Nick, sender, message);
            Console.WriteLine(messageDisplay);
            chatLog.Add(messageDisplay);
        }
        public void Say(string message) { Room.Broadcast(Nick, message); }
        public void PrivateMessage(string who, string message) { Room.DirectMessage(Nick, who, message); }

    }
}
