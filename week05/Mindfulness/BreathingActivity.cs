using System;

public class BreathingActivity : Activity
{
    public
    BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.";

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        Console.Write("Get ready to begin... ");
        ShowSpinner(5);
        Console.WriteLine();
        // Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            // Console.Clear();
            Console.Write("\nBreath in... ");
            ShowCountDown(4);
            Console.WriteLine();
            // Console.Clear();
            Console.Write("Now breath out... ");
            ShowCountDown(4);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}