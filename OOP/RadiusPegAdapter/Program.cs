using System;

namespace RadiusPegAdapter
{
    public static class program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            RoundHole roundHole = new RoundHole(5);
            RoundPeg roundPeg = new RoundPeg(5);
            SquarePeg littleSquarePeg = new SquarePeg(2);
            SquarePeg largeSquarePeg = new SquarePeg(20);

            List<IRound> pegs = new List<IRound>()
            {
                roundPeg, new SquarePegAdapter(littleSquarePeg), new SquarePegAdapter(largeSquarePeg)
            };


            foreach (IRound peg in pegs) { 
            Console.WriteLine(peg.GetRadius());
                if (roundHole.WillItFit(peg))
                {
                    Console.WriteLine("It fits");
                }
                else
                {
                    Console.WriteLine("It doesnt fit.");
                }
            
            
            }
        }
    }
}



