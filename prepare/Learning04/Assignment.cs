public class Assignment 
{
    protected string _studentName;
    protected string _topic;

    // constructor for Assignment class
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public string getSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}