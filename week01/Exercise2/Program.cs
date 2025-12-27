using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.\n");

        Console.Write("What is your grade percentage? ");
        string gradePercentString = Console.ReadLine();
        float gradePercent = float.Parse(gradePercentString);

        string letter;
        string words;
        string sign = "";
        float plusMinus;

        plusMinus = gradePercent % 10;

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
            words = "You did not pass.  Try again next time.";
            if (gradePercent >= 60)
            {
                letter = "D";
            }
            else
            {
                letter = "F";
            }
        }
        if (gradePercent < 95 && gradePercent >= 60)
        {
            if (plusMinus >= 7)
            {
                sign = "+";
            }
            else if (plusMinus < 3)
            {
                sign = "-";
            }
        }
        Console.WriteLine($"\nYou got a grade of {letter}{sign}. {words}\n");
    }
}