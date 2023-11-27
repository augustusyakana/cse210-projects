public class Word{
    private string _word;
    private bool _hidden;


    public Word(){
       
    }

    private void setStatus() {
        if (!_word.Contains("_")){
            _hidden = false;
        } else {
            _hidden = true;
        }
    }

    public bool getStatus(){
        return _hidden;
        
    }

    public string getWord(){
        return _word;
    }

    private void SetWord(string word)
    {
        _word = word;

    }

    public string getHiddenWord(string word)
    {
        SetWord(word);
        string hiddenWord = new string('_', _word.Length);
        return _word = hiddenWord.Replace(hiddenWord, _word);
        
    }


}