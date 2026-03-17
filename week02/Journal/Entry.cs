public class Entry
/* This is a single journal entry */
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    /* Displays the date, the prompt given, and the entry  */
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}
