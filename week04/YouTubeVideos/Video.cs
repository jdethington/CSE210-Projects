using System;
using System.Diagnostics;

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
    public void StoreComment(string name, string comment)
    {
        Comment c1 = new Comment(name, comment);
        _comments.Add(c1);
    }
    public string Display()
    {
        string display;
        display = $"Title:    {_title}\nAuthor:   {_author}\nLength:   {_length} seconds\nComments: {NumberOfComments()}";
        string comments = "";
        foreach (Comment comment in _comments)
        {
            comments = $"{comments}{comment.DisplayComment()}";

        }
        comments = $"{comments}\t  --------------------------------------------------";
        display = $"======================================================================\n{display}\n{comments}";
        return display;

    }
    private int NumberOfComments()
    {
        return _comments.Count();
    }
}