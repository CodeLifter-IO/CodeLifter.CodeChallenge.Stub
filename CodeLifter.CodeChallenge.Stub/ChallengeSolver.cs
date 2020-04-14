using System;
using CodeLifter.Logging;
using CodeLifter.Logging.Loggers;

namespace CodeLifter.CodeChallenge.Stub
{
    public class ChallengeSolver
    {
        private ILogger Logger { get; set; }

        public ChallengeSolver()
        {
            Logger = new ConsoleLogger();
        }

        public void RunSolver()
        {
            Logger.LogEntry("Hi! I just ran!", LogLevels.Info);
        }
    }
}
