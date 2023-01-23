using System;

class Program
{
    static void Main(string[] args)
    {
        // Get first name from user, save result in firstName
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        // Get last name from user, save result in lastName
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Line Space between get names and display results
        Console.WriteLine("");

        // Display result
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}