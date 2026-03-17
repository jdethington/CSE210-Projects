public class PromptGenerator
/* Supplies the random journal prompt */
{
    // variables
    private List<string> _prompts;
    private List<string> GetPromptsFromFile()
    /* Gets prompts from file */
    {
        List<string> prompts = new List<string>();
        string filename = "journalPrompts.txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            prompts.Add(line);
        }

        return prompts;

    }

    // functions - Behaviors
    public string GetRandomPrompt()
    /* Creates a random prompt from the List _prompts */
    // Get a random index value and lookup the string in _prompts
    // return the prompt
    {
        _prompts = GetPromptsFromFile();
        int count = _prompts.Count;
        Random rand = new Random();
        int choice = rand.Next(0, count);
        return _prompts[choice];
    }
}
