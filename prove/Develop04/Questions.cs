public class Questions
{
    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was completed? ",
        "What made this time different than other times when you we're not so successful ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? ",

    };

    public string getRandomQuestion()
    {
        Random randNum = new Random();
        int rndmPos = randNum.Next(_questions.Count);
        return _questions[rndmPos];
    }

}

