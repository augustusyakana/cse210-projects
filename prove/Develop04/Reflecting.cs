using System.Dynamic;

public class Reflecting : Activity
{
    private string _prompt;
    private string _question;
    public Reflecting(string title, int time, string description, string endingMsg) : base(title, time, description, endingMsg)
    {
        
    }

    Questions questions = new Questions();

    public void displayPrompt()
    {
        
        Console.WriteLine(_prompt);
        Console.WriteLine("");
    }

    public void displayQuestion()
    {
        setQuestion();
        Console.Write(_question);
        animation(6);
        Console.WriteLine("");
    }

    public void setPrompt(string prompt)
    {
        _prompt = prompt;
        
    }

    public async void session()
    {
        
        displayPrompt();
        Thread.Sleep(4000);
        Console.Write("Get ready...");
        animation(10);
        Console.WriteLine("");

        var countdownTask = StartCountdownAsync(TimeSpan.FromSeconds(_time));

        bool sessionDone = false;

        while (!sessionDone)
        {
            displayQuestion();

            if (countdownTask.IsCompleted)
            {
                sessionDone = true;
            }

        }
        await countdownTask;

    }

    private async Task StartCountdownAsync(TimeSpan duration)
    {
        await Task.Delay(duration);
    }

    private void setQuestion()
    {
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

