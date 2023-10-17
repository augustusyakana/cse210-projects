using System.Collections.Concurrent;
using System.Threading.Tasks.Dataflow;

public class Reference {
    private string _book;
    private int _chapter;
    private int _singleVerse;
    private int _startVerse;
    private int _endVerse;

    private string _reference;

    public Reference(string book, int chapter, int startVerse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
        makeMultiReference();
    }

    public string getReference(){
        return _reference;
    }

    public Reference(string book, int chapter, int singleVerse) {
        _book = book;
        _chapter = chapter;
        _singleVerse = singleVerse;
        makeSingleReference();
    }

    private void makeMultiReference(){
        _reference = $"{_book} {_chapter}: {_startVerse} - {_endVerse}";
    }

    private void makeSingleReference(){
        _reference = $"{_book} {_chapter}: {_singleVerse}";
    }
}