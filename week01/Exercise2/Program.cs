using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade in number form?");
        string numberGrade = Console.ReadLine();
        int percent = int.Parse(numberGrade);
        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else if (percent < 60)
        {
            letter = "F";
        }



        Console.WriteLine($"Your letter grade is a {letter}");
        if (percent > 70)
        {
            Console.WriteLine("You passed the course!");
        }
        else if (percent < 70)
        {
            Console.WriteLine("You failed the course, do better next time");
        }

        
    }
}