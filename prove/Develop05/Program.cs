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
        Thread.Sleep(2000);
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
                    string goalType = "SimpleGoal";
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
                    string goalType = "EternalGoal";
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
                    string goalType = "ChecklistGoal";
                    bool complete = false;

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

                    Checklist checklistGoal = new Checklist(bonusPoints, bonusTimes, complete, goalType, name, description, basePoints);
                    goals.Add(checklistGoal.AssembleGoal());
                    goalObjects.Add(checklistGoal);
                    Console.WriteLine("Goal Added!\n");

                }
                
            } 
            else if (response == 2)
            {
                
                Console.WriteLine("\nYour goals are:");

                for (int i = 0; i <= goals.Count - 1; i++)
                {
                    Console.WriteLine($"{i+1}. {goals[i]}");
                } 
            }
            else if (response == 3)
            {
                Console.Write("What is the name of the file you want to save to? ");
                string fileName = Console.ReadLine();

                using (StreamWriter outputFIle = new StreamWriter(fileName))
                {
                    outputFIle.WriteLine(totalPoints);

                    foreach (Goal goal in goalObjects)
                    {
                        outputFIle.WriteLine(goal.saveInfo());
                    }
                }

                Console.WriteLine("File saved!\n");
            } 
            else if (response == 4)
            {
                Console.Write("What is the name of the file you want to load? ");
                string fileName = Console.ReadLine();
                List<string> lines = File.ReadAllLines(fileName).ToList();
                string points = lines[0];
                totalPoints = int.Parse(points);

                lines = File.ReadAllLines(fileName).Skip(1).ToList();
                Console.WriteLine("");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(":");
                    string key = parts[0];
                    string data = parts[1];
                    
                    string[] value = data.Split(",");
                    string name = value[0];
                    string description = value[1];
                    string bPoints = value[2];
                    int basePoints = int.Parse(bPoints);
                    

                    if (key.ToLower() == "simplegoal")
                    {
                        string status = value[3];
                        bool complete = bool.Parse(status);
                        Simple simpleGoal = new Simple(complete, key, name, description, basePoints);
                        goals.Add(simpleGoal.AssembleGoal());
                        goalObjects.Add(simpleGoal);
                    } 
                    else if (key.ToLower() == "eternalgoal")
                    {
                        bool complete = false;
                        Eternal eternalGoal = new Eternal(complete, key, name, description, basePoints);
                        goals.Add(eternalGoal.AssembleGoal());
                        goalObjects.Add(eternalGoal);
                    }
                    else if (key.ToLower() == "checklistgoal")
                    {
                        string status = value[3];
                        bool complete = bool.Parse(status);
                        string bnsPoints = value[4];
                        int bonusPoints = int.Parse(bnsPoints);
                        string length = value[5];
                        int goalLength = int.Parse(length);
                        string times = value[6];
                        int timesCompleted = int.Parse(times);
                        Checklist checklistGoal = new Checklist(bonusPoints, goalLength, complete, key, name, description, basePoints);
                        goals.Add(checklistGoal.AssembleGoal());
                        goalObjects.Add(checklistGoal);
                    }

                }

                Console.WriteLine("\nLoading goals ...");
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("\nGoals Loaded!\n");
                Thread.Sleep(1000);
            }
            else if (response == 5)
            {
                Console.WriteLine("Which goal did you complete?");
                for (int i = 0; i <= goalObjects.Count - 1; i++)
                {
                    Console.WriteLine($"{i+1}. {goalObjects[i].getName()}");
                } 
                Console.Write("> ");
                string goalChoice = Console.ReadLine();
                int choiceNumber = int.Parse(goalChoice);
                int index = choiceNumber - 1;
                Goal goal = goalObjects[index];
                string type = goal.getType();

                if (type.ToLower() == "simplegoal")
                {
                    bool complete = true;
                    goal.setStatus(complete);
                    goals[index] = goal.AssembleGoal();
                    totalPoints = goal.EarnPoints(totalPoints);
                    
                } else if (type.ToLower() == "checklistgoal")
                {
                    totalPoints = goal.EarnPoints(totalPoints);
                    goals[index] = goal.AssembleGoal();
                    
                } else if (type.ToLower() == "eternalgoal")
                {
                    totalPoints = goal.EarnPoints(totalPoints);
                    goals[index] = goal.AssembleGoal();
                }
                
                int earned = goal.getBasePoints();
                Console.WriteLine($"\nCongratulations, you earned {earned} points.");
            }
            else if (response == 6)
            {
                break;
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("\nIncorrect input entered!");
                Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Please try again!");
                Thread.Sleep(2000);
                Console.Clear();

            }

        }

    }
}  