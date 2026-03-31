using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        string title = "title";
        string author = "author";
        int length = 250;

        title = "Learn Python in 10 Minutes";
        author = "CodeMaster";
        length = 600;
        Video v1 = new Video(title, author, length);
        v1.StoreComment("Alice", "This was super helpful!");
        v1.StoreComment("Bob", "I love Python now!");
        v1.StoreComment("Charlie", "Great tutorial.");
        v1.StoreComment("Dana", "Thanks for the clear explanations!");

        Video v2 = new Video("The History of Ancient Rome", "HistoryBuff", 1800);
        v2.StoreComment("Eve", "Fascinating stuff!");
        v2.StoreComment("Frank", "I learned so much from this.");
        v2.StoreComment("Grace", "More videos on this topic please!");

        Video v3 = new Video("Easy 15-Minute Meals for Beginners", "ChefJoy", 900);
        v3.StoreComment("Henry", "Tried the pasta recipe - delicious!");
        v3.StoreComment("Ivy", "Simple ingredients and quick to make.");
        v3.StoreComment("Jack", "Yum! My family loved it.");

        Console.Clear();
        Console.WriteLine("===============================================================");
        Console.WriteLine(v1.Display());
        Console.WriteLine(v2.Display());
        Console.WriteLine(v3.Display());
    }
}