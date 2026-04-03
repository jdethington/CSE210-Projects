using System;

public class ListingActivity : Activity

{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain ares.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        List<string> strings = GetFromUser();
        Console.WriteLine($"You listed {strings.Count} items!");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        // var rand = new Random();
        Random rand = new();
        // int promptNumber = _prompts.Count();
        int promptNumber = rand.Next(_prompts.Count);
        Console.WriteLine($" --- {_prompts[promptNumber]} --- ");
        Console.Write("You may begin in: ");
        ShowCountDown(9);
        Console.WriteLine();
    }
    public List<string> GetFromUser()
    {
        List<string> response = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string line = Console.ReadLine();
            response.Add(line);
            _count++;
        }
        return response;
    }
}