using System.Runtime.CompilerServices;
using System.Text;

public class Scripture {

    private string _scripture;
    private string _reference;

    Word wordsToHide = new Word();

    public Scripture(string reference, string scripture) {
        _scripture = scripture;
        _reference = reference;
        splitScripture();
    }

    public string getScripture(){
        return $"{_reference} \n{_scripture}";
    }

    private void splitScripture()
    {
        string[] words = _scripture.Split(" ");

        foreach (string word in words)
        {
            wordsToHide.setWord(word);
        }
    }

    private void HideWords()
    {
        string hiddenWord = wordsToHide.GetWord();
        string result = new string('_', hiddenWord.Length);


       _scripture = _scripture.Replace(hiddenWord, result);
    }

    public string GetScriptureWithHiddenWords()
    {
        HideWords();
        return _scripture;
    }
    
}