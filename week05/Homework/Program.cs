using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Chad", "Javascript");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment assignment2 = new MathAssignment("Chad", "C#", "week05", "1-20");
        Console.WriteLine(assignment2.GetHomeworkList());
        Console.WriteLine(assignment2.GetSummary());
        WritingAssignment assignment3 = new WritingAssignment("Chad", "Writing", "Uses of computers");
        Console.WriteLine(assignment3.GetSummary());
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}