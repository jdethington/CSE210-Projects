using System;
using System.Collections.Generic;

public class PromptGenerator
/* Supplies the random journal prompt */
{
    // variables
    public List<string> _prompts;
    public static List<string> ReadFromFile()
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
    {
        _prompts = ReadFromFile();
        int count = _prompts.Count;
        Random rand = new Random();
        int choice = rand.Next(0, count);
        return _prompts[choice];
    }
}
