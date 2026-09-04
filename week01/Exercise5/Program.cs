using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(username, squareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("What is your name?");
        string username = Console.ReadLine();
        return username;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("What is your number? ");
        string input = Console.ReadLine();
        int userNumber = int.Parse(input);
        return userNumber;
    }
    static int SquareNumber(int userNumber)
    {
        int squareNumber = userNumber * userNumber;
        return squareNumber;
    }
    static void DisplayResult(string userName, int squareNumber)
    {
        Console.WriteLine($"Hello {userName}, your number squared is {squareNumber}");
    }
}   
