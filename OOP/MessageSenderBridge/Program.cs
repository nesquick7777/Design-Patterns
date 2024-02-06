using MessageSenderBridge;

namespace Singleton
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            List<IMessageSender> senders = new List<IMessageSender>()
            {
                new EmailSender(), new MSMQSender(), new WebServiceSender()
            };
            Message message = new SystemMessage();
            message.Subject = "Test Message";
            message.Body = "This is test message";

            foreach (IMessageSender sender in senders) {
            message.MessageSender = sender;
                message.Send();
            }

            UserMessage userMessage = new UserMessage();
            userMessage.Subject = "Test Message";
            userMessage.Body = "This is test message";
            userMessage.UserComment = "I can add comments";
            userMessage.MessageSender = new EmailSender();
            userMessage.Send();
        }
    }
}



