using System.Reflection.Metadata.Ecma335;

public class Activity
{
    private string _title;
    private string _description;
    private int _time;

    public Activity(string title, int time, string description)
    {
        _title = title;
        _time = time;
        _description = description;
    }

    private void displayStartingMessage() 
    {
        Console.WriteLine("**Starting message**");
    }

    private void displayEndingMessage()
    {
        Console.WriteLine("**Ending Message**");
    }

    private void pauseAndCountdown()
    {
        Console.WriteLine("**Insert pause and countdown**");
    }

    private void animation()
    {
        Console.WriteLine("**Insert Animation**");
    }
}