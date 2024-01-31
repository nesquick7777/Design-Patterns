namespace Memento
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            SoftwareProject project = new SoftwareProject();
            project.BugCount = 170; project.TeamLead = "Bole"; project.Cost = 1000;

            ProjectManagmentSystem managment = new ProjectManagmentSystem();
            managment.Memento = project.Store();
            Console.WriteLine(project);

            project.BugCount = 200; project.TeamLead = "Bojan"; project.Cost = 1500;
            Console.WriteLine(project);

            project.Restore(managment.Memento);
            Console.WriteLine(project);
        }
    }
}



