// Supplies random prompts whenever needed

using System.Globalization;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was something someone did for you today that meant the most to you?",
        "What was one thing that you learned today?",
        "How did you see the hand of the Lord today?",
        "What did you study in your scripture study today?",
        "What was the best thing you ate today?",
        "What is one goal you have for tomorrow?",
        "What is one regret you have from today?",
        "Who did you serve today, and what did you do to serve them?",
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int amount = _prompts.Count();
        int numberIndex = random.Next(amount);
        return _prompts[numberIndex];
    }
}