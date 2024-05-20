using System.Security.Cryptography.X509Certificates;

public class WritingAssignment : Assingment
{
    private string _title;


    public WritingAssignment() : base ()
    {
        _title = "Unknown";
    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}