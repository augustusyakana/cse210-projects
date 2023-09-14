using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Capitalized first letters of firstName and lastName
        // made the rest of the string lower case, incase the user typed it all caps
        firstName = char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
        lastName = char.ToUpper(lastName[0]) + lastName.Substring(1).ToLower();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}