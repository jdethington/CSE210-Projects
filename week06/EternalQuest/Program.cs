using System;

// Exceeding requirements
// The Eternal Quest Starts with loading a file if one or more are available
// The file is saved each time a Goal is created or Event Recorded
// Loads  a file or creates a file and uses that file.  Removed "Save Goals" and "Load Goals". everything is autosaved.
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the EternalQuest Project.");
        int choice;
        // int numberChoice;
        Boolean filesAvailable;
        GoalManager goalManager = new GoalManager();


        string directory = Directory.GetCurrentDirectory();
        string[] txtFiles = Directory.GetFiles(directory, "*.txt");
        // Checks for files available
        filesAvailable = HasFile(txtFiles.Length);

        while (filesAvailable) // If files are available to use
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Eternal Quest!\n");
            Console.WriteLine("How do you want to start?\n");
            Console.WriteLine("1. Load Goals from file.");
            Console.WriteLine("2. Create new file.");
            Console.WriteLine("3. Quit.");
            Console.Write("> ");
            string loadOrNewFileChoice = Console.ReadLine();
            if (!int.TryParse(loadOrNewFileChoice, out choice) || int.Parse(loadOrNewFileChoice) < 0 || int.Parse(loadOrNewFileChoice) > 3)
            {
                Console.Write("That is not a valid number. Please try again");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(".");
                    Thread.Sleep(1000);
                }
                Console.WriteLine();
                // continue;
            }
            else
            {
                switch (choice)
                {
                    case 1: // Get file name
                        goalManager.FileToUse(GetFileName(txtFiles));
                        goalManager.Start();
                        filesAvailable = false;
                        break;
                    case 2:
                        goalManager.Start();
                        filesAvailable = false;
                        break;
                    case 3:
                        filesAvailable = false;
                        break;
                        // default:
                        //     filesAvailable = false;
                        //     break;
                }
            }
        }
    }
    static bool HasFile(int files)
    {
        if (files > 0)
        {
            return true;
        }
        return false;
    }
    static string GetFileName(string[] txtFiles)
    {
        Console.WriteLine("Available files:");
        // Console.WriteLine($"Found {txtFiles.Length} .txt file(s) in: {directory}");
        int numberChoice = 0;
        foreach (string file in txtFiles)
        {
            // Show only the filename (without full path)
            string fileName = Path.GetFileName(file);
            numberChoice++;
            Console.WriteLine($"  {numberChoice}. {fileName}");
        }
        Console.Write("Choose the file number you want to use: ");
        int fileNumberChoice = int.Parse(Console.ReadLine());
        string fileChoice = txtFiles[fileNumberChoice - 1];
        return fileChoice;

    }
}