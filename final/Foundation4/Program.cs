using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        string runningType = "Running";
        double runDistance = 3.0;
        int runLength = 30;

        string cyclingType = "Stationary Bicycles";
        double bikeSpeed = 20.0;
        int bikeLength = 45;

        string swimmingType = "Swimming in Pool";
        int swimLaps = 30;
        int swimLength = 50;

        string date = "09 Dec 2023";

        Running running = new Running(runDistance, runningType, date, runLength);
        Swimming swimming = new Swimming(swimLaps, swimmingType, date, swimLength);
        Cycling cycling = new Cycling(bikeSpeed, cyclingType, date, bikeLength);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Console.WriteLine("\nWorkout Summary: ");
        foreach(Activity activity in activities)
        {
            Console.WriteLine($"\n{activity.GetSummary()}");
        }
        Console.WriteLine("\nGreat Workout!\n");


    }
}