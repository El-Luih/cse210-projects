using System.Reflection;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, List<string[]> comments)
    {
        _title = title;
        _author = author;
        _length = length;

        foreach (string[] comment in comments)
        {
            _comments.Add(new Comment(comment[0], comment[1]));
        }
    }

    private string DisplayVideoInfo()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} (seconds)\n\n";
    }

    private int NumberOfComments()
    {
        return _comments.Count();
    }

    private string DisplayComments()
    {
        string displayedComments = "";
        foreach (Comment comment in _comments)
        {
            displayedComments += comment.DisplayComment();
        }

        return displayedComments;
    }

    public string DisplayVideo()
    {
        return $"{DisplayVideoInfo()}\nNumber of comments: {NumberOfComments()}\n\nComments:\n\n{DisplayComments()}";
    }
}