using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Fractions f1 = new Fractions();
        Fractions f2 = new Fractions(5);
        Fractions f3 = new Fractions(3, 4);

        // Console.WriteLine($"{f1.GetTop()}");
        // Console.WriteLine($"{f1.GetBottom()}");

        Console.WriteLine($"{f1.GetFractionString()}");
        Console.WriteLine($"{f1.GetDecimalValue()}");

        Console.WriteLine($"{f2.GetFractionString()}");
        Console.WriteLine($"{f2.GetDecimalValue()}");

        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue()}");

        f3.SetTop(1);
        f3.SetBottom(3);
        Console.WriteLine($"{f3.GetFractionString()}");
        Console.WriteLine($"{f3.GetDecimalValue()}");

    }
}