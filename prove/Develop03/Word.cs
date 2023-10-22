public class Word{
    private string _word;
    private bool _hidden;

    private void setStatus() {
        if (_word.Contains("_")){
            _hidden = true;  
        } else {
            _hidden = false;
        }
    }

    public void setWord(string word){
        _word = word;
        setStatus();
    }

    public string getWord(){
        return _word;
    }


}