namespace OralExamFacade
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            OralExamScheduler scheduler = new OralExamScheduler();

            List<String> ids = new List<String>() { { "PR115"}, { "PEK150"}, {"PR120" }, };

            foreach(string id in ids)
            {
                if (scheduler.isEligibleForOralExam(id))
                {
                    Console.WriteLine(id + " enter and pick a card");
                }
                else
                {
                    Console.WriteLine(id + " go home");
                }
            }
        }
    }
}