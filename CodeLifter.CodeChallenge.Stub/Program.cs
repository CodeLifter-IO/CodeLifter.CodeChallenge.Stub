using System;

namespace CodeLifter.CodeChallenge.Stub
{
    class Program
    {
        private static ChallengeSolver Solver { get; set; }

        static void Main(string[] args)
        {
            Solver = new ChallengeSolver();
            Solver.RunSolver();
        }
    }
}
