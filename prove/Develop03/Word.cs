public class Word{
    private string _word;
    private bool _hidden;

    public Word(string rndmWord){
        _word = rndmWord;
        setStatus();
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


}