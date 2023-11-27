public class Word{
    private string _word;
    private bool _hidden;

    List<string> words = new List<string>();
    List<string> hiddenWords = new List<string>();


    public Word(){
       
    }

    private void CheckStatus()
    {
        if (hiddenWords.Contains(_word))
        {
            _hidden = false;
        }
        else 
        {
            _hidden = false;
        }
    }

    public void setWord(string word)
    {
        _word = word;
        words.Add(word);
    }

    public string GetWord()
    {
        GetRandomWord();
        CheckStatus();
        
        if (_hidden == true) 
        {
            return _word;
        }
        else 
        {
            GetRandomWord();
            CheckStatus();
            return _word;
        }

    }

    private void GetRandomWord()
    {
        var randm = new Random();
        int index = randm.Next(words.Count - 1);

        string rndmWord = words[index];
        _word = rndmWord;
        
    }
    


}