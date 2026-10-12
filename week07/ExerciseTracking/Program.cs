using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("12 Oct 2026", 30, 10);
        activities.Add(running);

        Cycling cycling = new Cycling("13 Oct 2026", 60, 12);
        activities.Add(cycling);

        Swimming swimming = new Swimming("14 Oct 2026", 45, 13);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }

    }
}