public class ListingActivity : Activity
{
    // Constructor
    public ListingActivity()
    {
        activityType = "Listing";
        activityDescription =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        prompts.Add("Who are people that you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
    }

    public void doActivity() {
        StartingMessage();

        displayPrompt();

        EndingMessage();
    }
}