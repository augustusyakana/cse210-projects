public class Breathing : Activity
{
    private string _breatheIn = "Breathe in...";
    private string _breatheOut = "Breathe out...";
    public Breathing(string title, int time, string description, string endingMsg): base(title, time, description, endingMsg)
    {

    }

    private void displayBreateIn()
    {
        Console.Write(_breatheIn);
        countDown(4);
        Console.WriteLine("");
    }

    private void displayBreathOut()
    {
        Console.Write(_breatheOut);
        countDown(6);
        Console.WriteLine("\n");
    }
    public async void session()
    {
        var countdownTask = StartCountdownAsync(TimeSpan.FromSeconds(_time));

        displayBreateIn();
        displayBreathOut();


        bool sessionDone = false;
        while (!sessionDone) 
        {
            displayBreateIn();
            displayBreathOut();

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