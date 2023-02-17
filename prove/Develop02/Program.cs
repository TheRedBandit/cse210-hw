using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<string> unsavedEntries = new List<string>();
        string choice = "";

        do
        {
            Console.WriteLine("Please select one of the following options");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do? ");
            choice = Console.ReadLine();

        if (choice == "1")
        {
            string[] prompts = {"What was something you were glad you accomplished?", "What is the most interesting interaction you had today?", "prompt3", "prompt4", "prompt5"};
            Random randomNumber = new Random();
            int choosePrompt = randomNumber.Next(0,6);
            
            Console.WriteLine($"{prompts[choosePrompt]}");

            Console.Write("> ");
            string response = Console.ReadLine();
            Entry entry = new Entry(response, prompts[choosePrompt]);
            unsavedEntries.Add($"{entry.DisplayEntry()}");
            Console.WriteLine(entry.DisplayEntry());
        }
        // Display
        else if (choice == "2")
        {
            foreach (string entry in unsavedEntries)
            {
                Console.WriteLine(entry);
            }
        }
        // Load
        else if (choice == "3")
        {

        }
        // Save
        else if (choice == "4")
        {

        }
        // Quit
        } while (choice != "5");
    }
}