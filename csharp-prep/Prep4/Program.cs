using System;

class Program
{
    static void Main(string[] args)
    {   
        int runningTotal = 0;
        int largestNumber = 0;
        int average = 0;
        
        
        Console.WriteLine("\nPlease enter as many numbers as you want, enter 0 to stop!\n");

        List <int> numbers = new List<int>();

        int input = -1;

        while (input != 0)
        {
            Console.Write("Enter Number ");
            input = int.Parse(Console.ReadLine());
            numbers.Add(input);

            if (input == 0)
            {
                foreach (int number in numbers)
                {
                    if (largestNumber < number)
                    {
                        largestNumber = number;
                    }
                    runningTotal += number;
                }

                average = runningTotal / (numbers.Count - 1);

                Console.WriteLine($"\nSum: {runningTotal}");
                Console.WriteLine($"Average: {average}");
                Console.WriteLine($"Largest Number: {largestNumber}\n");

            }
        }

    }
}