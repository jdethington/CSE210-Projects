using System;

public class Scripture
/*Scripture: Keeps track of both the reference and the text of the scripture. 
    Can hide words and get the rendered display of the text.*/
{
    // Variables
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    // Instantiate
    public Scripture()
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
    // Check this!!!
    {
        _reference = reference;
        List<string> words = text.Split(" ").ToList();
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }
    // Methods
    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            int count = _words.Count();
            Random random = new Random();
            int choice = random.Next(0, count);
            if (_words[choice].IsHidden())
            {
                i--;
            }
            _words[choice].Hide();
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        // string scripture = "scripture";
        string text = reference;// + scripture;
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