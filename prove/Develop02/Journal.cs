public class Journal {
    public List<string> entries = new List<string>();

    public void displayEntries() {
        Console.WriteLine("Entries: ");
        foreach (string entry in entries) {
            Console.WriteLine($"{entry}\n");
        }
    }

    public void saveEntries() {
        using(StreamWriter outputFile = new StreamWriter("journal.txt")){
                foreach(string entry in entries){
                    outputFile.WriteLine(entry);
                };
        }
    }

    public void loadEntries() {
        Console.Write("What is the name of the file? ");
        string fileName = Console.ReadLine();
        var lines = System.IO.File.ReadLines(fileName);

        foreach (string line in lines){
            string fileEntry = line;
            entries.Add(fileEntry);
        }
    }
}