using System.ComponentModel;

public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string getWritingInformation(){
        return $"{_studentName} - {_topic} \n{_title} by {_studentName}";
    }
}