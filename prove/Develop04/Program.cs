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
                string endingMsg = "Thank you for participating in the breathing program";
                Activity activity1 = new Activity(title, time, description, endingMsg);
                activity1.displayStartingMessage();
                Thread.Sleep(2000);
                activity1.animation();
                activity1.displayEndingMessage();


            } else if (response == 2) 
            {
                Console.WriteLine("You chose the Reflection Activity");
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