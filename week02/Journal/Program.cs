using System;

class Program
{
    static void Main(string[] args)
    {
        using (StreamWriter outputFile = new StreamWriter("file.txt"))
        {
            outputFile.WriteLine("Hello World");
        }
        Journal theJournal = new Journal();
        PromptGenerator prompt = new PromptGenerator();
        Entry anEntry = new Entry();

        Console.WriteLine("Hello World! This is the Journal Project.\n\n");
        // Console.Clear();
        Console.WriteLine("Welcome to your Journal experience!\n");
        static void DisplayMenu()
        {
            // Console.Clear();
            Console.WriteLine("Please choose from one of the following options.");
            Console.WriteLine("1: New Journal entry");
            Console.WriteLine("2: Display Journal entries");
            Console.WriteLine("3: Load Journal entry");
            Console.WriteLine("4: Save Journal entry");
            Console.WriteLine("5: Close Journal(quit)");
            Console.Write("Choose 1-5: ");
        }

        Boolean journaling = true;
        while (journaling)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            if (choice == "1")
            // New Journal entry
            {
                // Console.Clear();
                anEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                anEntry._entryText = Console.ReadLine();
                DateTime current = DateTime.Now;
                anEntry._date = current.ToShortDateString();
                theJournal.AddEntry(anEntry);

                Console.WriteLine(theJournal);

            }
            else if (choice == "2")
            // Display Journal entries
            {
                Console.Clear();
                anEntry.Display();
                theJournal.DisplayAll();


            }
            else if (choice == "3")
            // Load Journal entry
            {
                Console.Clear();

            }
            else if (choice == "4")
            // Save Journal entry
            {
                // Console.Clear();
                Console.WriteLine("What do you want to save your Journal as?");
                string file = Console.ReadLine();

            }
            else if (choice == "5")
            // Quit program
            {
                journaling = false;
                Console.Clear();
                Console.WriteLine("Thank you for adding to your Journal.\n");
            }
            else
            // bad choice not 1-5
            {
                Console.Clear();
                Console.WriteLine($"{choice} is not an option. \nPlease choose a correct number.\n");
            }
        }
    }
}