using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        int totalPoints = 0;
        List<Goal> goals = new List<Goal>();


        Console.WriteLine("\nWelcome to the Eternal Quest Program!");
        Console.WriteLine("Please choose an option from the following menu: ");
        Thread.Sleep(5000);
        
        
        int response = 0;

        while (response != 6)
        {
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit Program");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            response = int.Parse(choice);

            if (response == 1)
            {
                
            }

        }

    }
}