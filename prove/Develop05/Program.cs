using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        int totalPoints = 0;
        List<string> goals = new List<string>();


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
                    string goalType = "Simple Goal";
                    bool complete = false;
                    Console.Write("What is the name of this goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Provide a short description of the goal: ");
                    string description = Console.ReadLine();

                    Console.Write("What is the base point amount for this goal? ");
                    string points = Console.ReadLine();
                    int simplePoints = int.Parse(points);

                    Simple simpleGoal = new Simple(complete, goalType, name, description, simplePoints);

                    goals.Add(simpleGoal.AssembleGoal());

                }
                
            } 
            else if (response == 2)
            {
                Console.WriteLine("Your goals are:");

                for (int i = 0; i <= goals.Count - 1; i++)
                {
                    Console.WriteLine($"{i+1}. {goals[i]}");
                } 
            }

        }

    }
}