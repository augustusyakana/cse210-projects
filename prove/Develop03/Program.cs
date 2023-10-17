using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorizing App!\n");

        string book = "Mosiah";
        int chapter = 2;
        int verse = 17;
        string scriptureText = "And behold, I tell you these things that ye may learn wisdom; that ye may learn that when ye are in the service of your fellow beings ye are only in the service of your God.";
        Reference reference = new Reference(book, chapter, verse);
        string scriptureReference = reference.getReference();

        Scripture scripture = new Scripture(scriptureReference, scriptureText);
        string response = "playing";
        // scripture.seeWords();
        

        while (response != "quit"){
            Console.WriteLine(scripture.getScripture());
            Console.Write("\nPress Enter to hide words in the scripture, or enter 'quit' to exit: ");
            response = Console.ReadLine();
            scripture.hideWords();
            Console.Clear();
        }

        
        




        
    }
}