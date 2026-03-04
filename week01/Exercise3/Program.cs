using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        // Console.Write("What is your magic number? ");
        // string number = Console.ReadLine();
        // int magicNumber = int.Parse(number);
        // shorter 
        // int magicNumber = int.Parse(Console.ReadLine());


        string words;
        int guessNumber;
        string play = "yes";

        while (play == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guesses = 0;
            do
            {
                Console.Write("What is your guess? ");
                string guess = Console.ReadLine();
                guessNumber = int.Parse(guess);
                guesses++;

                if (guessNumber == magicNumber)
                {
                    words = "You guessed it! ";
                }
                else if (guessNumber > magicNumber)
                {
                    words = "Lower ";
                }
                else
                {
                    words = "Higher ";
                }

                Console.WriteLine(words);

            } while (magicNumber != guessNumber);

            Console.WriteLine($"It took you {guesses} tries.");
            Console.Write("Do you want to play again? ");
            play = Console.ReadLine();
            play = play.ToLower();
            if (play == "y")
            {
                play = "yes";
            }
        }
        Console.WriteLine("Thanks for playing!");
    }
}