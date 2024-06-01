using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

public class Video
{
    private string _title;
    private string _author;
    private string _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"\nName of the video: {_title}\nAuthor: {_author}\nDuration: {_length}\n");
        Console.WriteLine($"  {GetCommentsCount()} Comments:\n");
        DisplayCommentsList();
        
    }

    public void AddComments(string name, string text, int numberOfComments)
    {
        for(int i = 1; i <= numberOfComments; i++)
        {
            Comment comment = new Comment(name, text);
            _comments.Add(comment);   
        }
        
    }

    public int GetCommentsCount()
    {
        int count = 0;

        foreach(Comment comment in _comments)
        {
            count ++;
        }

        return count;
    }

    public void DisplayCommentsList()
    {
        foreach(Comment comment in _comments)
        {
            Console.WriteLine($"{comment.DisplayComment()}");
        }
    }




}