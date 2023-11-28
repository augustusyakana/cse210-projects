using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;

    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public string DisplayVideoDetails()
    {
        return $"\nTitle: {_title}\nAuthor: {_author}\nLength: {_length} seconds";
    }

    public void AddComment(string commenter, string commentText)
    {
        Comment comment = new Comment(commenter, commentText);
        _comments.Add(comment);
    }

    public void DisplayComments()
    {
        Console.WriteLine($"Comments: ({_comments.Count})");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.StreingifyComments());
        }
    }


}