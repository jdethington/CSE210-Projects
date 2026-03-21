using System;
using System.Text;

public class Word
/*Word: Keeps track of a single word and whether it is shown or hidden.*/
{
    // Variables
    private string _text;
    private bool _isHidden;

    // Instantiate
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Methods
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        // int numberOfLetters = _text.Length;
        if (_isHidden == true)
        {
            string hiddenText = "";
            foreach (int i in _text)
            {
                hiddenText = string.Concat(hiddenText + "_");
            }
            return hiddenText;
        }
        return _text;
    }
}