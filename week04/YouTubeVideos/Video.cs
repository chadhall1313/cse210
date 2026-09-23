using System.Runtime.InteropServices.Marshalling;

public class Video
{
    private List<Comment> _comments = new List<Comment>();
    private string _title = "";
    private string _author = "";
    private int _lengthInSeconds = 0;


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }


    public void AddComment(string name, string text)
    {
        Comment comment = new Comment(name, text);
        _comments.Add(comment);
    }

    public int ReturnNumberOfComments()
    {
        return _comments.Count;
    }

    public string GetVideo()
    {
        string video = $"\n{_title}, {_author}\nLength: {_lengthInSeconds} seconds\nNumber of comments:{ReturnNumberOfComments()}";
        foreach (Comment comment in _comments)
        {
            video += $"\n{comment.DisplayComment()}";
        }
        
        return video;
    }

}