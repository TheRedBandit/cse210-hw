public class Activity
{
    protected int _seconds;

    protected string activityType;

    protected string activityDescription;

    protected List<string> prompts;

    public Activity()
    {
        prompts = new List<string>();
    }

    public void StartingMessage() 
    {
        Console.WriteLine($"Welcome to the {activityType} activity");

        Console.WriteLine(activityDescription);

        Console.Write("How long, in seconds, would you like your session to last? ");
        _seconds = Convert.ToInt32(Console.ReadLine());
    }

    public void EndingMessage() 
    {
        Console.WriteLine($"Thank you for using {_seconds} seconds of your time on the {activityType} activty");
    }

    public void doAnimation() 
    {
        
    }

    protected void displayPrompt()
    {
        int promptRange = prompts.Count();
        Random rnd = new Random();
        DateTime startTime = DateTime.Now;
        int promptIndex = rnd.Next(promptRange);
        

        while(DateTime.Now < startTime.AddSeconds(_seconds)) 
        {
            Console.WriteLine(prompts[promptIndex]);
            Thread.Sleep(_seconds*1000);
        }
    }
}

