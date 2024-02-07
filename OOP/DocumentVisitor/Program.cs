namespace DocumentVisitor
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Document doc = new Document();
            HtmlVisitor visitor = new HtmlVisitor();
            doc.Add(new PlainText("Hello friends, I am prince of Nigeria."));
            doc.Add(new BoldText("I have bussiness proposal."));
            doc.Add(new Hyperlink("www.suspiciouswebpage.nope"));

            doc.Accept(visitor);
            Console.WriteLine(visitor.Output);
        }
    }
}



