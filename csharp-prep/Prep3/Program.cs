using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        // Console.WriteLine(number);

        Console.Write("Guess a number from 1 to 100: ");
        string guessed = Console.ReadLine();
        int guess = int.Parse(guessed);

        if (guess > number)
        {
            Console.WriteLine("Lower!");
        }
        else if (guess < number)
        {
            Console.WriteLine("Higher!");
        }
        else
        {
            Console.WriteLine($"You guessed it! The magic number is {number}");
        }
    }
}