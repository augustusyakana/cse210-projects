public class User {
    public string _firstName;
    public string _occupation;

    public void displayName(){
        Console.Write("Logged By: ");
        Console.WriteLine($"{_firstName} ({_occupation})");
    }
}