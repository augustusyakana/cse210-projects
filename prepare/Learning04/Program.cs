using System;

class Program
{
    static void Main(string[] args)
    {
        string name = "Augustus Yakana";
        string topic = "Algorithms";
        Assignment assignment1 = new Assignment(name, topic);
        Console.WriteLine(assignment1.getSummary());

        string mathTopic = "Addition";
        string section = "4.6";
        string problems = "1-9";
        MathAssignment mathAssignment1 = new MathAssignment(name, mathTopic, section, problems);
        Console.WriteLine(mathAssignment1.getSummary());
        Console.WriteLine(mathAssignment1.getHomeworkList());

        string writingTopic = "Rhetoric";
        string title = "A Call to Act";
        WritingAssignment writingAssignment1 = new WritingAssignment(name, writingTopic, title);
        Console.WriteLine(writingAssignment1.getWritingInformation());



    }
}