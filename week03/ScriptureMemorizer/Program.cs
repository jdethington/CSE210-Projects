using System;

/* Exceeding Requirements    
Only removes words that are not hidden already
load scriptures from a files
created choice of difficulty levels that changes the amount of words removed

Here are some ideas you might consider:
2. Have your program work with a library of scriptures rather than a single one. 
    Choose scriptures at random to present to the user.
 */
class Program
{
    static void Main(string[] args)
    {
        Boolean play = true;
        int difficulty;
        int difficultyLow = 1;
        int difficultyHigh = 2;

        Console.Clear();
        Console.WriteLine("Select difficulty 1-5:");
        Console.WriteLine("1)  1  word  removed");
        Console.WriteLine("2) 1-2 words removed");
        Console.WriteLine("3) 1-3 words removed");
        Console.WriteLine("4) 2-5 words removed");
        Console.WriteLine("5) 3-7 words removed");
        Console.Write("> ");
        difficulty = Convert.ToInt16(Console.ReadLine());
       
        if (difficulty == 2)
        {
            difficultyHigh = 3;
        }
        else if (difficulty == 3)
        {
            difficultyHigh = 4;
        }
        else if (difficulty == 4)
        {
            difficultyLow = 2;
            difficultyHigh = 6;
        }
        else if (difficulty == 5)
        {
            difficultyLow = 3;
            difficultyHigh = 8;
        }

        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.\n");
        string referenceParts = LoadFromFile("refer");
        string scriptureFile = LoadFromFile("scrip");
        string[] parts = referenceParts.Split(",");
        string book = parts[0];
        int chapt = Convert.ToInt16(parts[1]);
        int verseStart = Convert.ToInt16(parts[2]);
        int verseEnd = 0;
        int countParts = parts.Length;
        if (countParts == 4)
        {
            verseEnd = Convert.ToInt16(parts[3]);
        }

        Reference reference = new Reference(parts[0], chapt, verseStart, verseEnd);
        Scripture scripture = new Scripture(reference, scriptureFile);

        do
        {
            string scriptureReference = scripture.GetDisplayText();
            Console.Clear();
            Console.WriteLine(scriptureReference);
            Console.WriteLine("\nPress enter to continue or 'quit' to finish: ");
            string line = Console.ReadLine().ToLower();

            if (line == "quit")
            {
                play = false;
            }
            else
            {

                if (scripture.IsCompletelyHidden())
                {
                    play = false;
                    break;
                }

                Random rand = new Random();
                int numWordsToHide = rand.Next(difficultyLow, difficultyHigh);
                scripture.HideRandomWords(numWordsToHide);
            }

        } while (play);
        
    }
    static string LoadFromFile(string file)
    /* Loop through each line of the file 
    and create strings to put in the list */
    {
        string referenceFile = "";
        string scripture = "";
        string[] lines = System.IO.File.ReadAllLines("scriptures.txt");
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            referenceFile = parts[0];
            scripture = parts[1];
        }

        if (file == "refer")
        {
            return referenceFile;
        }
        else if (file == "scrip")
        {
            return scripture;
        }
        return "";
    }

}