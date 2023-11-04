public class Prompts
{
    List<string> _prompts = new List<string>()
    {
        "Think of a time when you did something truly selfless.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something difficult.",
        "Think of a time when you stood up for someone.",
    };

    public string getRandomPrompt()
    {
        Random randNum = new Random();
        int rndmPos = randNum.Next(_prompts.Count);
        return _prompts[rndmPos];

    }
}