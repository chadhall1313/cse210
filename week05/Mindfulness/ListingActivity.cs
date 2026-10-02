using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    private int _count = 0;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.WriteLine("List as many responses to the following prompt:\n");
        Console.WriteLine($"--> {GetRandomPrompt()} <--\n");
        Console.Write("You may begin in... ");
        ShowCountdown(5);
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            string item = Console.ReadLine();
            _count += 1;
        }
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
    
    // private List<string> GetListFromUser()
    // {
        // append item to list but this feature is unused
    // }
}