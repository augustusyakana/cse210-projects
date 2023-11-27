using System.Runtime.CompilerServices;
using System.Text;

public class Scripture {

    private string _scripture;
    private string _reference;
    private List<string> _words = new List<string>();

    public Scripture(string reference, string scripture) {
        _scripture = scripture;
        _reference = reference;
        separateWords();
    }

    

    public string getScripture(){
        hideWord();
        return $"{_reference} \n{_scripture}";
    }

    private void separateWords(){
        string[] words = _scripture.Split(" ");
        foreach (string word in words) {
            _words.Add(word);
        }
    }


    public void hideWord() {
        var random = new Random();
        int index = random.Next(_words.Count - 1);
        string randomWord = _words[index];
        
        string hiddenWord = new string('_', randomWord.Length);
        if (_scripture.Contains(randomWord))
        {
            _scripture = _scripture.Replace(hiddenWord, randomWord);
        } else
        {
            hideWord();
        }

    }

    
    
}