
This is just a stub for C# code challenges.  The intention is just to remove the cruft and get to the good stuff when doing code challenges.

1. I don't like using (or seeing) a ton of static methods in my Main so I always start out by making a seperate class and executing that.
1. It doesn't stop you from using main, feel free
1. I also sneak in my personal, and very basic, logging solution.  Anywhere in the class you can call
    - ```Logger.LogEntry("Hi! I just ran!");``` OR
    - ```Logger.LogEntry("Hi! I just ran!", LogLevels.Info);```  if you want to set a color and alert level
1. It has a test project so you can explore a candidate's ability to write tests, or do TDD 