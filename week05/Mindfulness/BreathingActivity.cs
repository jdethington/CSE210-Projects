using System;

public class BreathingActivity : Activity
{
    // private int _breathTime = 4;
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    {
    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Clear();
            Console.Write("\nBreath  in  (·)");
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(1000);
                Console.Write("\b·)");
            }
            Thread.Sleep(500);
            Console.Clear();
            Console.Write("\n    Hold    (·····)");
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("\nBreath out  (·····)");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("\b\b  \b\b)");
                Thread.Sleep(1000);
            }
            Console.Clear();
            Console.Write("\n    Hold    (·)");
            Thread.Sleep(1000);
            Console.WriteLine();
        }
        DisplayEndingMessage();
    }
}