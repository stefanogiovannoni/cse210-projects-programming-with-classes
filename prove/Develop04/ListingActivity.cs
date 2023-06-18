using System;
using System.Threading;

public class ListingActivity : Activity
{
    private string[] prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base()
    {
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        ShowStartingMessage("Listing", description);
    }

    public override void RunActivity()
    {
        timer = new Timer(TimerCallback, null, 0, 1000); // Timer ticks every second
        Random random = new Random();

        while (elapsedSeconds < duration)
        {
            string prompt = prompts[random.Next(prompts.Length)];
            Console.WriteLine(prompt);
            Thread.Sleep(2000); // Pause for 2 seconds
            Console.WriteLine("Get ready...");
            Thread.Sleep(3000); // Pause for 3 seconds

            int itemNumber = 1;
            while (elapsedSeconds < duration)
            {
                Console.WriteLine($"Item {itemNumber}:");
                string input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                itemNumber++;
            }

            Console.WriteLine($"You listed {itemNumber - 1} items.");
            ShowSpinner(3); // Pause for 3 seconds while showing spinner
        }
    }
}
