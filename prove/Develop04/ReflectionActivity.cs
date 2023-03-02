public class ReflectionActivity: Activity
{
    public ReflectionActivity()
    {
        activityType = "Reflection";
        activityDescription =  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        prompts.Add("Think of a time when you stood up for someone else.");
        prompts.Add("Think of a time when you did something really difficult.");
        prompts.Add("Think of a time when you helped someone in need.");
        prompts.Add("Think of a time when you did something truly selfless.");

    }

    public void doActivity()
    {
        StartingMessage();

        displayPrompt();

        EndingMessage();
    }
}