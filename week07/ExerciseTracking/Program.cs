using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("\nHello World! This is the ExerciseTracking Project.\n");

        string date = DateTime.Today.ToString("dd MMM yyyy");


        List<Exercise> exercises = new List<Exercise>();
        Running running = new Running("03 Nov 2022", 30, 3);
        Cycling cycling = new Cycling("05 Dec 2023", 40, 15);
        Swimming swimming = new Swimming("08 Jan 2026", 30, 20);
        Running running2 = new Running(date, 45, 4.5f);
        Cycling cycling2 = new Cycling(date, 25, 18.5f);
        Swimming swimming2 = new Swimming(date, 45, 35);

        exercises.Add(running);
        exercises.Add(cycling);
        exercises.Add(swimming);
        exercises.Add(running2);
        exercises.Add(cycling2);
        exercises.Add(swimming2);


        foreach (Exercise exercise in exercises)
        {
            Console.WriteLine(exercise.GetSummary());
        }
        Console.WriteLine("\nExercise Tracking Program Complete!\n");
    }
}