using System.Reflection.Metadata.Ecma335;

public class Activity
{
    private string _title;
    private string _description;
    private int _time;

    private string _endingMsg;

    public Activity(string title, int time, string description, string endingMsg)
    {
        _title = title;
        _time = time;
        _description = description;
        _endingMsg = endingMsg;

    }

    public void displayStartingMessage() 
    {
        Console.WriteLine(createStartingMessage());
        
    }

    public void displayEndingMessage()
    {
        Console.WriteLine(_endingMsg);
    }

    public void pauseAndCountdown()
    {
        Console.WriteLine("**Insert pause and countdown**");
    }

    public void animation()
    {
        
        List<string> animationSymbols = new List<string>();
        animationSymbols.Add(".");
        animationSymbols.Add(":");
        animationSymbols.Add(".");
        animationSymbols.Add(" ");


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(6);

        int i = 0;

        while (DateTime.Now < endTime) 
        {
            string s = animationSymbols[i];
            Console.Write(s);
            Thread.Sleep(1000);
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
       return $"Welcome to the {_title}\n {_description}";
    }
}