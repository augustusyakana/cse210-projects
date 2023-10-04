using System.IO;

class Program
{
    static void Main(string[] args)
    {
        var fulldate = DateTime.Now;
        string date = fulldate.ToString("MM/dd/yyy");
        Entry entry1 = new Entry();
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        
        int choice = 0;

        Console.WriteLine("\nWelcome to the Journal App");
        while (choice != 5) {
            
            Console.WriteLine("\nEnter Action (1-5): ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit\n");

            string answer = Console.ReadLine();
            choice = int.Parse(answer);

            if (choice == 1) {
                string prompt = promptGenerator.getRandomString();
                Console.WriteLine(prompt);
                string entry = Console.ReadLine();
                entry1._date = date;
                entry1._entry = entry;
                entry1._prompt = prompt;
                string pkgdEntry = entry1.pkgEntry();
                journal.entries.Add(pkgdEntry);
            } else if (choice == 2){
                journal.displayEntries();
            } else if (choice == 3){
                journal.saveEntries();
                Console.WriteLine("\nSaved");
            } else if (choice == 4){
                journal.loadEntries();
                Console.WriteLine("\nLoaded");
            } else if (choice == 5){
                Console.WriteLine("Come back later!\n");
                break;
            } else {
                Console.WriteLine("\nWrong input! Try Again");
            }
        }
    }
}