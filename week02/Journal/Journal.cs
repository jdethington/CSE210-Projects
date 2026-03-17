public class Journal
/* Stores a list of journal entries */
{
    // variables
    public List<Entry> _entries = new List<Entry>();
    PromptGenerator prompt = new PromptGenerator();

    // functions - Behaviors
    public void AddEntry(Entry newEntry)
    /* Adds a new journal entry to the list of _entries */
    // Put newEntry into _entries
    {
        newEntry._promptText = prompt.GetRandomPrompt();
        Console.WriteLine(newEntry._promptText);
        Console.Write("> ");
        newEntry._entryText = Console.ReadLine();
        DateTime current = DateTime.Now;
        newEntry._date = current.ToShortDateString();
        // anEntry = newEntry;
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    /* Displays all of the entries in the _entries list */
    {
        foreach (Entry entryNumber in _entries)
        {
             entryNumber.Display();
        }

    }

    public void SaveToFile(string file)
    /* Loop through each item in _entries and save it in a file */
    {using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entryNumber in _entries)
            {
                string date = entryNumber._date;
                string prompt = entryNumber._promptText;
                string entry = entryNumber._entryText;
                outputFile.WriteLine($"{date},{prompt},{entry}");
            }
        }
    }

    public void LoadFromFile(string file)
    /* Loop through each line of the file 
    and create Entry objects to put in the list */
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Entry anEntry = new Entry();
            string[] parts = line.Split(",");

            anEntry._date = parts[0];
            anEntry._entryText = parts[2];
            anEntry._promptText = parts[1];

            _entries.Add(anEntry);

        }
    }
}