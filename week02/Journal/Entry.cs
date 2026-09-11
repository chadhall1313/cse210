// Represents a single journal entry

using System.Xml.Serialization;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";


    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}\n{_promptText}\n{_entryText}\n");

    }
}