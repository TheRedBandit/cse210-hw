using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Please select one of the following options");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do? ");
        string choice = Console.ReadLine();

        if (choice == "1")
        {
            string[] prompts = {"What was something you were glad you accomplished?", "What is the most interesting interaction you had today?", "prompt3", "prompt4", "prompt5"};
            Random randomNumber = new Random();
            int choosePrompt = randomNumber.Next(0,6);
            
            Console.Write($"{prompts[choosePrompt]} ");

            string response = Console.ReadLine();
        }
    }
}