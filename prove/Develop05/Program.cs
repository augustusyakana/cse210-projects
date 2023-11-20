using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        int totalPoints = 0;
        List<string> goals = new List<string>();
        List<Goal> goalObjects = new List<Goal>();


        Console.WriteLine("\nWelcome to the Eternal Quest Program!");
        Console.WriteLine("Loading up the program.. ");
        Thread.Sleep(5000);
        Console.Clear();
        
        
        int response = 0;

        while (response != 6)
        {
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine("\n1. Create New Goal");
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
                    Console.WriteLine("\n");
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
                    goalObjects.Add(simpleGoal);
                    Console.WriteLine("Goal Added!\n");

                } else if (type == 2)
                {
                    string goalType = "Eternal Goal";
                    bool complete = false;

                    Console.Write("What is the name of this goal? ");
                    string name = Console.ReadLine();
                    
                    Console.Write("Provide a short description of this goal: ");
                    string description = Console.ReadLine();

                    Console.Write("What is the base point amount for this goal? ");
                    string points = Console.ReadLine();
                    int basePoints = int.Parse(points);

                    Eternal eternalGoal = new Eternal(complete, goalType, name, description, basePoints);
                    goals.Add(eternalGoal.AssembleGoal());
                    goalObjects.Add(eternalGoal);
                    Console.WriteLine("Goal Added!\n");

                } else if (type == 3)
                {
                    string goalType = "Checklist Goal";
                    bool complete = false;
                    bool bonusComplete = false;

                    Console.Write("What is the name of this goal? ");
                    string name = Console.ReadLine();

                    Console.Write("Provide a short description of this goal: ");
                    string description = Console.ReadLine();

                    Console.Write("What is the base points amount for this goal? ");
                    string points = Console.ReadLine();
                    int basePoints = int.Parse(points);

                    Console.Write("How many times does this goal need to be accomplished to earn bonus points? ");
                    string times = Console.ReadLine();
                    int bonusTimes = int.Parse(times);

                    Console.Write("What is the bonus amount for this goal? ");
                    string bonus = Console.ReadLine();
                    int bonusPoints = int.Parse(bonus);

                    Checklist checklistGoal = new Checklist(bonusComplete, bonusPoints, bonusTimes, complete, goalType, name, description, basePoints);
                    goals.Add(checklistGoal.AssembleGoal());
                    goalObjects.Add(checklistGoal);
                    Console.WriteLine("Goal Added!\n");

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
            else if (response == 3)
            {
                Console.WriteLine("What is the name of the file you want to save to? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFIle = new StreamWriter(fileName))
                {
                    outputFIle.WriteLine(totalPoints);
                    
                    foreach (Goal goal in goalObjects)
                    {
                        outputFIle.WriteLine(goal.saveInfo());
                    }
                }
            }

        }

    }
}  