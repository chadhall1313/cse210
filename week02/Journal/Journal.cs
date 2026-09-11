// Stores list of journal entries
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        PromptGenerator generator = new PromptGenerator();
        string prompt = generator.GetRandomPrompt();

        DateTime today = DateTime.Today;
        string strToday = today.ToShortDateString();

        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Entry newEntry = new Entry();
        newEntry._date = strToday;
        newEntry._promptText = prompt;
        newEntry._entryText = response;

        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            Console.WriteLine();
            entry.DisplayEntry();
        
        }
    }

    public void SaveToFile()
    {
        Console.WriteLine("What is your file name?");
        string fileName = Console.ReadLine();
        using (StreamWriter file = new StreamWriter(fileName))
        {
            foreach (Entry i in _entries)
            {
                file.WriteLine($"{i._date}|{i._promptText}|{i._entryText}");
            }
        }
    }

    public void LoadFromFile()
    {

        Console.WriteLine("What is your file name?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            _entries.Add(newEntry);
        }
    }

    public void SearchByDate()
    {
        Console.WriteLine("What date would you like to search? (Use format: M/d/yyyy)");
        string searchDate = Console.ReadLine();
        Console.WriteLine("What is your file name?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            Entry newEntry = new Entry();
            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];
            if (newEntry._date == searchDate)
            {
                Console.WriteLine();
                newEntry.DisplayEntry();
            }
        }
    }
}