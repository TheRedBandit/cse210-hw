using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        string name = PromptUserName();
        int iNumber = PromptUserNumber();
        iNumber = SquareNumber(iNumber);
        DisplayResult(name, iNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int iNumber = int.Parse(Console.ReadLine());
        return iNumber;
    }

    static int SquareNumber(int number)
    {
        number = number * number;
        return number;
    }

    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}