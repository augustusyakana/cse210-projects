public class Entry {
    public string _date;
    public string _prompt;
    public string _entry;

    public string _nameInfo;
    
    public string pkgEntry() {
        return $"{_nameInfo} | {_date}: {_prompt} :{_entry}";
    }
}