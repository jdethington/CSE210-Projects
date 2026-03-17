using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int number = -1;

        do
        {
            Console.Write("Enter a number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }

        } while (number != 0);

        // Compute the sum, or total, of the numbers in the list.
        int total = numbers.Sum();
        Console.WriteLine($"The sum is: {total}");

        // Compute the average of the numbers in the list.
        // double count = numbers.Count;
        // double avg = total / count;
        double avg = numbers.Average();
        Console.WriteLine($"The average is: {avg}");

        // Find the maximum, or largest, number in the list.
        int max = numbers.Max();
        Console.WriteLine($"The largest number is: {max}");

        // Have the user enter both positive and negative numbers, then find the smallest positive number(the positive number that is closest to zero).
        int min = 999999999;
        foreach (int num in numbers)
        {
            if (num > 0 && min > num)
            {
                min = num;
            }
        }
        Console.WriteLine($"The smallest positive number is: {min}");
        // Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.
        numbers.Sort();
        Console.WriteLine("The sorted list is: ");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}