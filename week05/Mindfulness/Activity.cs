using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private int _pause = 3;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = Convert.ToInt32(Console.ReadLine());
        Console.Clear();
        Console.Write("Get ready to begin... ");
        ShowSpinner(_pause);
        Console.WriteLine();

    }
    public void DisplayEndingMessage()
    {
        _pause = 3;
        Console.WriteLine("\nWell done!!");
        ShowSpinner(_pause);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of {_name} Activity");
        ShowSpinner(_pause);
    }
    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}