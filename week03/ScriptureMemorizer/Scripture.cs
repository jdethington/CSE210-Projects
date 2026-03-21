using System;

public class Scripture
/*Scripture: Keeps track of both the reference and the text of the scripture. 
    Can hide words and get the rendered display of the text.*/
{
    // Variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private int _wordsVisible = 0;
    // Instantiate
    public Scripture()
    // no longer used
    {
        _reference = new Reference();
        string text = "O be wise; what can I say more?";
        List<string> words = text.Split(" ").ToList();
        
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        List<string> words = text.Split(" ").ToList();
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
        _wordsVisible = _words.Count();
    }
    // Methods
    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide > _wordsVisible)
        {
            numberToHide = _wordsVisible;
        }
        
        for (int i = 0; i < numberToHide; i++)
        {
            int count = _words.Count();
            Random random = new Random();
            int choice = random.Next(0, count);
            if (_words[choice].IsHidden())
            {
                i--;
            }
            else
            {
                _words[choice].Hide();
            }
        }
        _wordsVisible -= numberToHide;
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = reference;

        foreach (Word word in _words)
        {
            string newWord = word.GetDisplayText();
            text += newWord + " ";
        }
        
        return text;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

}