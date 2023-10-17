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

    
}