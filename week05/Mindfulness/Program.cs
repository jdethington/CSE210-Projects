using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Mindfulness Project.");

        bool activity = true;
        do
        {
            string choice = displayMenu();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    activity = false;
                    Console.WriteLine("Thank you for playing!");
                    break;
                default:
                    Console.Write("Please input a correct number.  ");
                    for (int i = 3; i >= 0; i--)
                    {
                        Console.Write(i);
                        Thread.Sleep(1000);
                        Console.Write("\b \b");

                        // Console.Write(".");
                        // Thread.Sleep(500);
                        // Console.Write(i);
                    }
                    Thread.Sleep(250);
                    break;
            }
        } while (activity);

        static string displayMenu()
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine().Trim();
            return choice;
        }
    }
}