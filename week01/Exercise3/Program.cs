using System;

class Program
{
    static void Main(string[] args)
    {
        string keepPlaying = "yes";
        while (keepPlaying == "yes")
        {
            Random randomGenerator = new Random();
            int correctNumber = randomGenerator.Next(1, 100);
            int guess = -1;
            int guessCount = 0;

            while (guess != correctNumber)
            {
                Console.WriteLine("What is your guess?");
                string number = Console.ReadLine();
                guess = int.Parse(number);
                guessCount++;
                if (guess < correctNumber)
                {
                    Console.WriteLine("Guess higher");
                }
                else if (guess > correctNumber)
                {
                    Console.WriteLine("Guess lower");
                }
                else if (guess == correctNumber)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine($"You had {guessCount} guesses.");
                }

            }
            Console.WriteLine("Do you want to keep playing?");
            keepPlaying = Console.ReadLine();
        }
    }
}