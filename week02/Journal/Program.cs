/*I did a few things to exceed the requirements.

Made a new method in the object Journal called GetSavedJournlas that gets and displays a list of file names that have been used as a Journal.  
Then returns that file name to load the journal for use.*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        string usingFile;

        Console.Clear();
        // Console.WriteLine("Hello World! This is the Journal Project.\n");
        Console.WriteLine("Welcome to your Journal experience!\n");
        Thread.Sleep(1000);
        string loadOrNew;
        do
        {
            Console.Write("Do you want to (L)oad Journal from a file or (N)ew Journal? ");
            loadOrNew = Console.ReadLine().ToLower();

            switch (loadOrNew)
            {
                case "n":
                    loadOrNew = "l";
                    SaveFile(theJournal);
                    break;
                case "l":
                    usingFile = theJournal.GetSavedJournals();
                    theJournal.LoadFromFile(usingFile);
                    break;
                default:
                    break;
            }
        } while (loadOrNew != "l");


        Console.Clear();
        string choice;
        do
        {
            choice = DisplayMenu();

            if (choice == "1")
            // New Journal entry
            // Create an entry object to pass to the journal for storage
            {
                Entry anEntry = new Entry();
                theJournal.AddEntry(anEntry);
            }
            else if (choice == "2")
            // Display Journal entries
            {
                theJournal.DisplayAll();
            }
            else if (choice == "3")
            // Load Journal entry
            {
                LoadFile(theJournal);
            }
            else if (choice == "4")
            // Save Journal entry
            {
                SaveFile(theJournal);
            }
            else if (choice == "5")
            // Quit program
            {
                // Asks to save on exit
                Console.WriteLine("Do you want to save you Journal? (Y): ");
                string needToSave = Console.ReadLine().ToUpper();
                if (needToSave == "Y")
                {
                    SaveFile(theJournal);
                }
                Console.Clear();
                Console.WriteLine("Thank you for adding to your Journal.\n");
            }
            else
            // bad choice not 1-5
            {
                Console.WriteLine($"\n{choice} is not an option. \nPlease choose a correct number.\n");
                Thread.Sleep(1000);
            }
        } while (choice != "5");
    }
    static string DisplayMenu()
    {
        Console.WriteLine("Please choose from one of the following options.");
        Console.WriteLine("1: Write new Journal entry");
        Console.WriteLine("2: Display Journal entries");
        Console.WriteLine("3: Load Journal");
        Console.WriteLine("4: Save Journal");
        Console.WriteLine("5: Close Journal(quit)");
        Console.Write("Choose 1-5: ");
        return Console.ReadLine().Trim();
    }
    static void SaveFile(Journal theJournal)
    {
        Console.WriteLine("\nWhat is the name of your Journal?");
        Console.Write("> ");
        string file = Console.ReadLine();
        Console.WriteLine($"Saving {file}.......");
        using (StreamWriter outputFile = new StreamWriter("fileOfJournalProgramWeekTwo.txt", append: true))
        {
            outputFile.WriteLine($"{file}");
        }
        // await Task.Delay(5000);            
        Thread.Sleep(5000);
        theJournal.SaveToFile(file);
        Console.WriteLine($"{file} saved Successfully!\n");
    }
    static void LoadFile(Journal theJournal)
    {
        // Console.WriteLine("\nWhat is the name of your Journal file?");
        // Console.Write("> ");
        // string file = Console.ReadLine().Trim();
        string file = theJournal.GetSavedJournals();
        Console.WriteLine($"Loading {file}.......");
        Thread.Sleep(1000);
        theJournal.LoadFromFile(file);
        Console.WriteLine($"{file} loaded Successfully!\n");
        Thread.Sleep(1000);
    }
}