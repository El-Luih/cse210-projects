using System;

class Program
{
    static void Main(string[] args)
    {
        Random magicGenerator = new Random();
        int magicNumber = magicGenerator.Next(1, 101);

        Console.WriteLine("Guess the magic number between 1 and 100!");

        bool isGuessed = false;

        do
        {
            Console.WriteLine("What is your guess? ");
            int userGuess = int.Parse(Console.ReadLine());

            if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("That's the magic number!");
                isGuessed = true;
            }

        } while (!isGuessed);

    }
}