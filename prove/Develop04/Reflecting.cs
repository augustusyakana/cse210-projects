using System.Dynamic;

public class Reflecting : Activity
{
    private string _prompt;
    private string _question;
    public Reflecting(string title, int time, string description, string endingMsg) : base(title, time, description, endingMsg)
    {
        
    }

    public void displayPrompt()
    {
        Console.WriteLine(_prompt);


    }

    public void displayQuestion()
    {
        
        Console.WriteLine(_question);
    }

    private void setPrompt()
    {
        Prompts prompts = new Prompts();
        _prompt = prompts.getRandomPrompt();
    }

    private void setQuestion()
    {
        Questions questions = new Questions();
        _question = questions.getRandomQuestion();
    }

    private void countDown(int time)
    {
        for (int i = time; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }


}

