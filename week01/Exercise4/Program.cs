using System;
using System.Diagnostics.CodeAnalysis;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int number = 0;
        do
        {
            Console.WriteLine("Number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        double sum = 0;
        foreach (int i in numbers)
        {
            sum = sum + i;
        }
        double average = sum / numbers.Count();
        int highest = numbers[0];
        foreach (int i in numbers)
        {
            if (i > highest)
            {
                highest = i;
            }
        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Highest: {highest}");
    }
}