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
                Console.WriteLine("\nThe types of goals are:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type would you like to create? ");
                string typeChoice = Console.ReadLine();
                int type = int.Parse(typeChoice);

                if (type == 1)
                {
                    // create instance of GOAL derived class
                    // Right here //
                    string goalType = "Simple Goal";

                }
                
            }

        }

    }
}