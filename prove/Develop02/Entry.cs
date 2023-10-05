public class Entry {
    public string _date;
    public string _prompt;
    public string _entry;
    
    public string pkgEntry() {
        return $"{_date}: {_prompt} :{_entry}";
    }
}