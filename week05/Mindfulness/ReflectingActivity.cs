using System;
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private int _waitTime = 5;
    private List<string> _remainingQuestions = new List<string>();
    private Random rand = new Random();

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestion();
        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        return _prompts[rand.Next(_prompts.Count)];
    }
    public string GetRandomQuestion()
    {
        if (_remainingQuestions.Count == 0)
        {
            _remainingQuestions = new List<string>(_questions);
        }
        int i = rand.Next(_remainingQuestions.Count);
        string question  = _remainingQuestions[i];
        _remainingQuestions.RemoveAt(i);
        return question;
    }
    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"\n --- {GetRandomPrompt()} --- \n\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    public void DisplayQuestion()
    {
        Console.WriteLine("\nNow ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(_waitTime);
        
        _remainingQuestions = new List<string>(_questions);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n> {GetRandomQuestion()} ");
            ShowSpinner(_waitTime * 2);
        }
        Console.WriteLine();
    }
}