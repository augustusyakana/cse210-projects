public class PromptGenerator {
    public List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public string getRandomString() {
        Random randNum = new Random();
        int aRandomPos = randNum.Next(prompts.Count);
        return prompts[aRandomPos];
    }


}