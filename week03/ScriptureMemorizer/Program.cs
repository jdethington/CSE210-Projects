using System;

/* Exceeding Requirements       Here are some ideas you might consider:

1. Think of other challenges that people find when trying to memorize a scripture. 
    Find a way to have your program help with these challenges.
2. Have your program work with a library of scriptures rather than a single one. 
    Choose scriptures at random to present to the user.
3. Have the program to load scriptures from a files.
4. Anything else you can think of!
 */
/*
1. Store a scripture, including both the reference 
    (for example "John 3:16") and the text of the scripture.
2. Accommodate scriptures with multiple verses, such as "Proverbs 3:5-6".
3. Clear the console screen and display the complete scripture, 
    including the reference and the text.
4. Prompt the user to press the enter key or type quit.
5. If the user types quit, the program should end.
6. If the user presses the enter key (without typing quit), 
    the program should hide a few random words in the scripture, 
    clear the console screen, and display the scripture again. 
    (Hiding a word means that the word should be replace by underscores (_) 
    and the number of underscores should match the number of letters in that word.)
7. The program should continue prompting the user and hiding more words 
    until all words in the scripture are hidden.
8. When all words in the scripture are hidden, the program should end. 
    (The final display of the scripture should show the scripture with all words hidden.)
9. When selecting the random words to hide, for the core requirements, 
    you can select any word at random, even if the word was already hidden. 
    (As a stretch challenge, 
    try to randomly select from only those words that are not already hidden.)
*/

class Program
{
    static void Main(string[] args)
    {
        Boolean play = true;
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.\n");
        Scripture scripture = new Scripture();
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureFile = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        string scriptureReference = scripture.GetDisplayText();
        Scripture scripture1 = new Scripture(reference, scriptureFile);
        do
        {
            // Console.WriteLine(scriptureReference);

            scriptureReference = scripture1.GetDisplayText();

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
                if (scripture1.IsCompletelyHidden())
                {
                    play = false;
                    break;
                }
                scripture1.HideRandomWords(3);
            }
        } while (play);
    }
}