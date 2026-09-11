using System;
// EXCEED EXPECTATIONS: added a feature to search by date
class Program
{
    static void Main(string[] args)
    {
        string input = "";
        Journal journal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        do
        {
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("6. Search by Date");

            Console.WriteLine("Which would you like to do?");

            input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    journal.LoadFromFile();
                    break;
                case "4":
                    journal.SaveToFile();
                    break;
                case "6":
                    journal.SearchByDate();
                    break;
            }
            



            input = Console.ReadLine();
        } while (input != "5");
    }
}