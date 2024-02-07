namespace SoftwareProjectMemento
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            SoftwareProject project = new SoftwareProject();
            project.TeamLead = "Bole";
            project.BugCount = 7;
            project.Cost = 1000;

            Console.WriteLine(project);

            SoftwareProjectManager manager = new SoftwareProjectManager();
            manager.Memento = project.Store();

            project.TeamLead = "LeBo";
            project.BugCount = 5;
            project.Cost = 2000;

            Console.WriteLine(project);
            project.Restore(manager.Memento);
            Console.WriteLine(project);

        }
    }
}



