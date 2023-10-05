public class Journal {
    public List<string> _entries = new List<string>();

    public void displayEntries() {
        Console.WriteLine("Entries: ");
        foreach (string entry in _entries) {
            Console.WriteLine($"{entry}\n");
        }
    }
    // saves the entries to a file and allows the user to set the file name.
    public void saveEntries() {
        Console.Write("Enter name of file to save to: ");
        string fileName = Console.ReadLine();
        using(StreamWriter outputFile = new StreamWriter(fileName)){
                foreach(string entry in _entries){
                    outputFile.WriteLine(entry);
                };
        }
    }

    // load file, allow user to set file name to be loaded
    public void loadEntries() {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        var lines = System.IO.File.ReadLines(fileName);

        // iterate through the lines and add the lines to 
        // the journal entry list
        foreach (string line in lines){
            string fileEntry = line;
            _entries.Add(fileEntry);
        }
    }
}