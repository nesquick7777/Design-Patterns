namespace Mediator
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            ChatRoom room = new ChatRoom();
            Person Aristotle = new Person("Aristotle");
            Person Plato = new Person("Plato");
            room.Join(Aristotle);
            room.Join(Plato);
            Aristotle.Say("Wise men speak because they have something to say; Fools because they have to say something.");
            Plato.Say("Opinion is the medium between knowledge and ignorance.");
            Person Pero = new Person("Pero");
            room.Join(Pero);
            Pero.Say("Pozdrav ekipa!");
            Plato.PrivateMessage(Aristotle.Nick, "Who's this guy?");

        }
    }
}
