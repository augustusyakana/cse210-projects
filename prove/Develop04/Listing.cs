using System.Net.Quic;

public class Listing : Activity
{
    private string _question;

    private List<string> _answers = new List<string>();

    public Listing(string title, int time, string description, string endingMsg): base(title, time, description, endingMsg)
    {
        
    }

    ListingQuestions listingQuestions = new ListingQuestions();

    private void setQuestion()
    {
        _question = listingQuestions.getRandomQuestion();
    }

    private void displayQuestion()
    {
        setQuestion();
        Console.WriteLine($"--- {_question} ---");
    }

    public void session()
    {
        Console.Write("Get ready...");
        animation(5);
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        Thread.Sleep(4000);
        displayQuestion();
        Thread.Sleep(4000);
        Console.Write("You may begin in...");
        countDown(6);
        Console.WriteLine("");

        var countdownThread = new Thread(() => 
        {
            StartCountdownAsync(TimeSpan.FromSeconds(_time));
        });
        countdownThread.Start();
        bool sessionDone = false;

        while (!sessionDone)
        {
            Console.Write(">");
            string rspns = Console.ReadLine();
            _answers.Add(rspns);

            if (!countdownThread.IsAlive)
            {
                sessionDone = true;
            }

        }

        Console.WriteLine($"You listed {_answers.Count} things.");
        Console.WriteLine("\nWell Done!");
        animation(5);

    }

    private void StartCountdownAsync(TimeSpan duration)
    {
        Thread.Sleep((int)duration.TotalMilliseconds);
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