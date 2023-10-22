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
        return $"{_reference} \n{_scripture}";
    }

    private void separateWords(){
        string[] words = _scripture.Split(" ");
        foreach (string word in words) {
            _words.Add(word);
        }
    }


    public void hideWords() {
        string[] scripture = _scripture.Split(" ");
        

        var random = new Random();
        int index = random.Next(_words.Count - 1);
        string randomWord = _words[index];

        string word = randomWord;
        string result = new string('_', word.Length);

        foreach (string text in scripture){

            if (text == word){
                if (word != result){
                    _scripture = _scripture.Replace(word, result);
                } else {
                    hideWords();
                    
                }

            }
        }
    }

    // for testing
    // public void seeWords(){
    //     _words.ForEach((word) =>{
    //         Console.WriteLine(word);
    //     });
    // }
}