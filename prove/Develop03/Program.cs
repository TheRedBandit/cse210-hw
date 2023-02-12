using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        ReadScripture scrip = new ReadScripture();
        Console.WriteLine(scrip.GetScriptureText());
        Console.WriteLine("");
        Console.WriteLine("Press enter to continue or type 'quit' to end program:");
        GetInput input = new GetInput();
    }
}