using System;
// EXCEEDING EXPECTATIONS: Added some usability features with Console.Clear() and Thread.Sleep(), also added lots of exception handlers.
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}