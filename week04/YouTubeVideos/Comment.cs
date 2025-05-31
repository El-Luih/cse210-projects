
using System.Reflection.Metadata;

public class Comment
{
    private string _userName;
    private string _commentText;

    public Comment(string user, string text)
    {
        _userName = user;
        _commentText = text;
    }

    public string DisplayComment()
    {
        return $"{_userName}:\n\n{_commentText}\n\n";
    }
}