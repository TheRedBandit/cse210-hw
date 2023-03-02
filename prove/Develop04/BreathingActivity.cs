public class BreathingActivity: Activity
{
    public BreathingActivity()
    {
        activityType = "Breathing";
        activityDescription =  "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void doActivity()
    {
        StartingMessage();

        DateTime startTime = DateTime.Now;
        
        while(DateTime.Now < startTime.AddSeconds(_seconds)) 
        {
            Console.WriteLine("Breathe in...");
            Thread.Sleep(3000);
            Console.WriteLine("Breathe out...");
            Thread.Sleep(3000);
        }

        EndingMessage();
    }
}