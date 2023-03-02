using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        string menuChoice = "";

        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start breathing activity");
            Console.WriteLine("   2. Start reflecting activity");
            Console.WriteLine("   3. Start listing activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Select a choice from the menu: ");

            menuChoice = Console.ReadLine();

            BreathingActivity breAct = new BreathingActivity();
            ListingActivity lisAct = new ListingActivity();
            ReflectionActivity refAct = new ReflectionActivity();

            switch(menuChoice)
            {
                case "1":
                    breAct.doActivity();
                    break;
                
                case "2":
                    refAct.doActivity();
                    break;
                
                case "3":
                    lisAct.doActivity();
                    break;
            }
        } while (menuChoice != "4"); 
        
    }
}