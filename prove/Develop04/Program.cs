using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the mindfulness program: ");
        int response = 0;

        while (response != 4) 
        {

            Console.WriteLine("Choose an activity below: ");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");

            Console.Write("Your choice: ");
            string choice = Console.ReadLine();
            response = int.Parse(choice);

            if (response == 1) 
            {
                string title = "Breathing Activity";
                string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
                Console.Write("How long do you wish to do this activity? (in seconds): ");
                string num = Console.ReadLine();
                int time = int.Parse(num);
                string endingMsg = $"CONGRATULATIONS on completing {time} seconds of the Breathing Activity";
                Breathing breathing1 = new Breathing(title, time, description, endingMsg);
                Console.Clear();
                breathing1.displayStartingMessage();
                Console.Write("Get ready...");
                breathing1.animation(6);
                Console.WriteLine("");
                breathing1.session();
                Console.WriteLine("Please wait... \n");
                breathing1.animation(6);
                breathing1.displayEndingMessage();
                Thread.Sleep(3000);
                Console.Clear();
                

            } else if (response == 2) 
            {
                string title = "Reflecting Activity";
                string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                Console.Write("How long do you wish to do this activity? (in seconds): ");
                string num = Console.ReadLine();
                int time = int.Parse(num);
                string endingMsg = $"CONGRATULATIONS on completing {time} seconds of the Reflecting Activity";

                Reflecting reflecting = new Reflecting(title, time, description, endingMsg);
                Questions questions1 = new Questions();
                Prompts prompts1 = new Prompts();
               
                string rndmPrompt = prompts1.getRandomPrompt();
                reflecting.setPrompt(rndmPrompt);
                
                Console.Clear();
                reflecting.displayStartingMessage();
                reflecting.animation(6);
                Console.WriteLine("");
                reflecting.session();
                Console.Write("Please wait...");
                reflecting.animation(5);
                Console.WriteLine("");
                reflecting.displayEndingMessage();
                Thread.Sleep(4000);
                Console.Clear();
                

            } else if (response == 3)
            {
                Console.WriteLine("You chose the Listing Activity");
            } else if (response == 4) 
            {
                Console.WriteLine("Thank you!");
                break;
            } else 
            {
                Console.WriteLine("Invalid input! Please choose from 1 - 4 as shown in the menu.");
            }
        }

        

        
    }
}