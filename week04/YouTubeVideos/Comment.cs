using System;

public class Comment
{
    private string _commenterName;
    private string _comment;

    public Comment(string name, string comment)
    {
        _commenterName = name;
        _comment = comment;
    }

    public string DisplayComment()
    {
        string display;
        return display = $"\t  Name:    {_commenterName}\n\t  Comment: {_comment}\n";
    }
}