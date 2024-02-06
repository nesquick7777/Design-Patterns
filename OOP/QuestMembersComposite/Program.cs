namespace QuestMembersComposite
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            List<IQuestMember> questMembers = new List<IQuestMember>();

            Player conan = new Player("Conan", new Damage(100, 0));
            Player gandalf = new Player("Gandalf", new Damage(5, 100));
            Party bridgeBurners = new Party("Bridge Burners");
            bridgeBurners.AddMember(new Player("Whiskey Jack", new Damage(50, 0)));
            Party mages = new Party("Mages");
            mages.AddMember(new Player("Hedge", new Damage(20, 70)));
            bridgeBurners.AddMember(mages);

            questMembers.Add(conan);
            questMembers.Add(gandalf);
            questMembers.Add(bridgeBurners);

            Damage totalDamage = new Damage();

            foreach (IQuestMember member in questMembers)
            {
                totalDamage += member.TotalDamge;
                Console.WriteLine(member.Name);

            }
            Console.WriteLine("Total Damage done: "+totalDamage);
        }
    }
}



