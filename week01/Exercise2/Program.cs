using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradePercentString = Console.ReadLine();
        float gradePercent = float.Parse(gradePercentString);

        string letter;
        string words;

        if (gradePercent >= 70)
        {
            words = "Congradulations! You passed the class.";

            if (gradePercent >= 90)
            {
                letter = "A";
            }
            else if (gradePercent >= 80)
            {
                letter = "B";
            }
            else
            {
                letter = "C";
            }
        }
        else
        {
            words = "Try again next time.";
            if (gradePercent >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        }

        Console.WriteLine($"You got a grade of {letter}. {words}");
    }
}