using System;
// EXCEEDING EXPECTATIONS: gave a prompt at the end of how long you used the program for this session
class Program
{
    static void Main(string[] args)
    {
        DateTime startTime = DateTime.Now;
        int input = 0;
        while (input != 4)
        {
            Console.Clear();
            Console.WriteLine("Choose a selection:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run();
                    break;
                case 2:
                    ReflectingActivity reflectingActivity = new ReflectingActivity();
                    reflectingActivity.Run();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run();
                    break;
            }
        }
        TimeSpan totalTime = DateTime.Now - startTime;
        Console.WriteLine($"Thank you for using the Mindfullness Program. You spent {totalTime.TotalSeconds:0} seconds in this session.");
    }
}