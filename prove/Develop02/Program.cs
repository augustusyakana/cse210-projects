using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // instantiate and assign new date variable with current date
        // and convert to a string with the format (MM/dd/yyyy)
        var fulldate = DateTime.Now;
        string date = fulldate.ToString("MM/dd/yyy");

        Entry entry1 = new Entry(); // new Entry object
        PromptGenerator promptGenerator = new PromptGenerator(); // new PromptGenerator object
        Journal journal = new Journal(); // new Journal object
        User user = new User(); // new User object
        
        // Greetings and getting user info
        Console.WriteLine("\nWelcome to the Journal App");
        Console.Write("Enter your first name: ");
        user._firstName = Console.ReadLine();
        Console.Write("Enter your occupatioin: ");
        user._occupation = Console.ReadLine();
        
        int choice = 0;

        // initiate a loop with "while" so that the user can 
        // keep choosing from the menu until he/she decides to
        // quit the program(5).
        while (choice != 5) {
            
            // a menu for the user to select an action from
            Console.WriteLine("\nEnter Action (1-5): ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit\n");

            string answer = Console.ReadLine();
            choice = int.Parse(answer);

            if (choice == 1) {
                // getting random prompt for the user to respond to 
                // and storing the prompt in a variable
                string prompt = promptGenerator.getRandomString();
                Console.WriteLine(prompt);

                // getting user response and storing in variable
                string entry = Console.ReadLine();

                // sending data(values) to the Entry class object and 
                // using the object method to package (format) the data
                entry1._date = date;
                entry1._entry = entry;
                entry1._prompt = prompt;
                string pkgdEntry = entry1.pkgEntry();
                
                // adding the packaged data to the journal list
                journal._entries.Add(pkgdEntry);

            } else if (choice == 2){
                // displaying user info and logged entries
                user.displayName();
                journal.displayEntries();

            } else if (choice == 3){
                // saving all entries to the file
                journal.saveEntries();
                Console.WriteLine("Saved");

            } else if (choice == 4){
                // loading the file to the program
                journal.loadEntries();
                Console.WriteLine("Loaded");

            } else if (choice == 5){
                // quits the program with farewell message
                Console.WriteLine("Come back later!\n");
                break;

            } else {
                // in case the user enters a number that is not among
                // the choices provided in the menu
                Console.WriteLine("\nWrong input! Try Again");
            }
        }
    }
}