using System;

class Program
{
    static void Main(string[] args)
    {
        
        int guess = 0;
        int score = 0;
        string play = "yes";
        Console.WriteLine("\nHi! Welome to the Guessing Game! Guess a number from 1 to 100!\n");

        while (play.ToLower() == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);

            while (guess != number)
            {
                Console.Write("Your guess: ");
                string guessed = Console.ReadLine();
                guess = int.Parse(guessed);
                score++;

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
                    Console.WriteLine($"\n{number} is correct! Took you {score} tries!");
                    
                }

            }

            Console.Write("\nDo you want to play again? ");
            play = Console.ReadLine();

            if (play == "no")
            {
                Console.WriteLine("\nThanks for playing! See you next time!\n");
            }

        } 
        
    }
}