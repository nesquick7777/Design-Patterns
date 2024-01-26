namespace Builder
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args) {
        
            RobotBuilder oldRobotBuilder = new OldRobotBuilder();

            RobotEngineer robotEngineer = new RobotEngineer(oldRobotBuilder);

            robotEngineer.makeRobot();

            Robot firstRobot = robotEngineer.getRobot();

            Console.WriteLine("Robot Head Type: " + firstRobot.getRobotHead());
            Console.WriteLine("Robot Torso Type: " + firstRobot.getRobotTorso());
            Console.WriteLine("Robot Arms Type: " + firstRobot.getRobotArms());
            Console.WriteLine("Robot Legs Type: " + firstRobot.getRobotLegs());

        }
    }


}