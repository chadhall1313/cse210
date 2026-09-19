
//EXCEEDING EXPECTATIONS: added a behavior for Scripture class to show all words at the end of the program for continuos memorizing
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string input = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        do
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to hide words. Type 'quit' to quit.");
            input = Console.ReadLine();
            if (scripture.IsCompletelyHidden())
            {
                scripture.ShowAllWords();
            }
            scripture.HideRandomWords(3);
            Console.Clear();
        } while (input != "quit");

        
    }
}