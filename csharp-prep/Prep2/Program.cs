using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);
        
        string letter;
        string passed = "Congratulations you passed!";
        string failed = "Sorry, You didn't pass this time!";


        if (grade >= 90)
        {
            if (grade <= 93)
            {
                letter = "A-";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            else
            {
                letter = "A";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            
        }
        else if (grade < 90 && grade >= 80)
        {
            if (grade >= 87)
            {
                letter = "B+";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            else if (grade <= 83)
            {
                letter = "B-";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            else 
            {
                letter = "B";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            
        }
        else if (grade < 80 && grade >= 70)
        {
            if (grade >= 77)
            {
                letter = "C+";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            else if (grade <= 73)
            {
                letter = "C-";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            else
            {
                letter = "C";
                Console.WriteLine($"Grade: {letter} : {passed}");
            }
            
        }
        else if (grade < 70 && grade >= 60)
        {
            if (grade >= 67)
            {
                letter = "D+";
                Console.WriteLine($"Grade: {letter} : {failed}");
            }
            else if (grade <= 63)
            {
                letter = "D-";
                Console.WriteLine($"Grade: {letter} : {failed}");
            }
            else 
            {
                letter = "D";
                Console.WriteLine($"Grade: {letter} : {failed}");
            }
        }
        else 
        {
            letter = "F";
            Console.WriteLine($"Grade: {letter} : {failed}");
        }
    }
}