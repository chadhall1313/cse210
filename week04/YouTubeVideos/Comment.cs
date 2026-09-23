public class Comment
{
    private string _name = "";
    private string _text = "";


    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    private string GetName()
    {
        return _name;
    }
    private string GetText()
    {
        return _text;
    }

    public string DisplayComment()
    {
        return $"{GetName()} | {GetText()}";
    }

}   