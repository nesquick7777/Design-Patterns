namespace Adapter
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            EnemyTank rx7 = new EnemyTank();
            
            EnemyRobot fredTheRobot = new EnemyRobot();

            EnemyAttacker robotAdapter = new EnemyRobotAdapter(fredTheRobot);

            Console.WriteLine("Robot");

            fredTheRobot.smashWithHands();
            fredTheRobot.moveForward();
            fredTheRobot.reactToHuman("Frank");

            Console.WriteLine("Tank");
            rx7.fireWeapon();
            rx7.driveForward();
            rx7.assignDriver("Frank");

            Console.WriteLine("The Robot with Adapter");
            robotAdapter.fireWeapon();
            robotAdapter.driveForward();
            robotAdapter.assignDriver("Frank");
        }
    }
}