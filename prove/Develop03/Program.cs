using System;

class Program
{
    static void Main(string[] args)
    {
        string quit = "";
        Console.Clear();
        ReadScripture scrip = new ReadScripture();

        do{
            Console.WriteLine(scrip.GetScriptureText());
            Console.WriteLine("");
            Console.WriteLine("Press enter to continue or type 'quit' to end program:");
            GetInput input = new GetInput();
        } while (quit != "quit");
    }
}