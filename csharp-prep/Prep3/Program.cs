using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1,11);

        Console.Write($"What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magic = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int iGuess = int.Parse(guess);

        if (iGuess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (iGuess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        do
        {
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            iGuess = int.Parse(guess);

            if (iGuess < magic)
            {
                Console.WriteLine("Higher");
            }
            else if (iGuess > magic)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (iGuess != magic);
        
    }
}