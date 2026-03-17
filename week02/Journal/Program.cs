class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();

        Console.Clear();
        Console.WriteLine("Hello World! This is the Journal Project.\n");
        Console.WriteLine("Welcome to your Journal experience!\n");

        static string DisplayMenu()
        {
            Console.WriteLine("Please choose from one of the following options.");
            Console.WriteLine("1: New Journal entry");
            Console.WriteLine("2: Display Journal entries");
            Console.WriteLine("3: Load Journal entry");
            Console.WriteLine("4: Save Journal entry");
            Console.WriteLine("5: Close Journal(quit)");
            Console.Write("Choose 1-5: ");
            return Console.ReadLine().Trim();
        }

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
                Console.WriteLine("\nWhat is the name of your Journal file?");
                Console.Write("> ");
                string file = Console.ReadLine().Trim();
                theJournal.LoadFromFile(file);
            }
            else if (choice == "4")
            // Save Journal entry
            {
                Console.WriteLine("\nWhat do you want to save your Journal as?");
                Console.Write("> ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }
            else if (choice == "5")
            // Quit program
            {
                Console.Clear();
                Console.WriteLine("Thank you for adding to your Journal.\n");
            }
            else
            // bad choice not 1-5
            {
                Console.WriteLine($"\n{choice} is not an option. \nPlease choose a correct number.\n");
            }
        } while (choice != "5");
    }
}