namespace Mediator
{
    internal class ChatRoom
    {
        private List<Person> people = new List<Person>();
        public void Broadcast(string source, string message)
        {
            foreach (Person person in people)
            {
                if (person.Nick != source) { person.Receive(source, message); }
            }
        }
        public void Join(Person person)
        {
            String welcomeMessage = String.Format("{0} joins the chat", person.Nick);
            Broadcast("room", welcomeMessage);
            person.Room = this;
            people.Add(person);
        }
        public void DirectMessage(string source, string destination, string message)
        {
            Person person = people.FirstOrDefault(p => p.Nick == destination);
            if (person != null)
            {
                person.Receive(source, message);
            }
        }

    }
}