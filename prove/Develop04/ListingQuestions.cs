public class ListingQuestions
{
    private List<string> _questions = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public string getRandomQuestion()
    {
        Random randNum = new Random();
        int rndmPos = randNum.Next(_questions.Count);
        return _questions[rndmPos];
    }
}