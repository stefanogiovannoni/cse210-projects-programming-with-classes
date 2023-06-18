using System;
using System.Threading;
public class BreathingActivity : Activity
{
    private string[] breatheMessages = { "Breathe in...", "Breathe out..." };

    public BreathingActivity() : base()
    {
        string description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        ShowStartingMessage("Breathing", description);
    }

    public override void RunActivity()
    {
        timer = new Timer(TimerCallback, null, 0, 1000); // Timer ticks every second

        while (elapsedSeconds < duration)
        {
            Console.WriteLine(breatheMessages[elapsedSeconds % 2]);
            Thread.Sleep(2000); // Pause for 2 seconds
            ShowSpinner(3); // Pause for 3 seconds while showing spinner
        }
    }
}

