using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

public class Activity
{
    private string _title;
    private string _description;
    protected int _time;

    private string _endingMsg;

    public Activity(string title, int time, string description, string endingMsg)
    {
        _title = title;
        _time = time;
        _description = description;
        _endingMsg = endingMsg;

    }

    public Activity()
    {
        
    }

    public void displayStartingMessage() 
    {
        Console.WriteLine(createStartingMessage());
        
    }

    public void displayEndingMessage()
    {
        Console.WriteLine(_endingMsg);
    }

    public void animation(int time)
    {
        
        List<string> animationSymbols = new List<string>();
        animationSymbols.Add("-");
        animationSymbols.Add("\\");
        animationSymbols.Add("|");
        animationSymbols.Add("/");
        animationSymbols.Add("-");
        animationSymbols.Add("\\");
        animationSymbols.Add("|");
        animationSymbols.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        int i = 0;

        while (DateTime.Now < endTime) 
        {
            string s = animationSymbols[i];
            Console.Write(s);
            Thread.Sleep(200);
            Console.Write("\b \b");

            i++;

            if (i >= animationSymbols.Count)
            {
                i = 0;
            }
        }
    }

    private string createStartingMessage()
    {
       return $"\nWelcome to the {_title}\n {_description}\n";
    }
}