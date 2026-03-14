using System;
// using System.IO;

public class Journal
/* Stores a list of journal entries */
{
    // variables
    public List<Entry> _entries = new List<Entry>();

    // functions - Behaviors
    public void AddEntry(Entry newEntry)
    /* Adds a new journal entry to the list of _entries */
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    /* Displays all entries from _entries */
    {
        foreach (Entry entry in _entries)
        {
            List<string> entryDate = new List<string>(); 
            // entryDate = Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    /*  */
    {

    }

    public void LoadFromFile(string file)
    /*  */
    {

    }
}