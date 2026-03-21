using System;

public class Reference
/*Reference: Keeps track of the book, chapter, and verse information.*/
{
    // Variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    // Instantiate
    public Reference()
    {
        _book = "Jacob";
        _chapter = 6;
        _verse = 12;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    // Methods
    public string GetDisplayText()
    {
        string text = "";
        if (_endVerse == 0)
        {
            text = _book + " " + _chapter + ":" + _verse + " > ";
            return text;
        }
        text = _book + " " + _chapter + ":" + _verse + "-" + _endVerse + " > ";

        return text;
    }
}