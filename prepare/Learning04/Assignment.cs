using System.Runtime.CompilerServices;

public class Assingment 
{
    private string _studentName;
    private string _topic;

    public Assingment ()
    {
        _studentName = "Unknown";
        _topic = "Unknown";
    }

    public Assingment (string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary ()
    {
        return $"{_studentName} - {_topic}";
    }

    public string GetStudentName ()
    {
        return _studentName;
    }
    
}