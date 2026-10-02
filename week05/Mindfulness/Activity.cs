public class Activity
{
    protected string _name = "";
    protected string _description = "";
    protected int _duration = 0;

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine($"{_description}");
        Thread.Sleep(3000);
        Console.WriteLine("How long in seconds would you like for your session?\n");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(3);
        Console.WriteLine($"You've completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(5);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> {"|", "/", "—", "\\"};
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (DateTime.Now < futureTime)
        {
            foreach (string direction in spinner)
            {
                Console.Write(direction);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}