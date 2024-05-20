public class MathAssignment : Assingment
{
    private string _textbookSection;
    private string _problem;

    public MathAssignment () : base ()
    {
        _problem = "Unknown";
        _textbookSection = "Unknown";
    }
    
    public MathAssignment(string studenName, string topic, string textbookSection, string problem) : base (studenName, topic)
    {
        _textbookSection = textbookSection;
        _problem = problem;
    }

    public string GetHomeworkList ()
    {
        return $"{_textbookSection}, {_problem}";
    }
}