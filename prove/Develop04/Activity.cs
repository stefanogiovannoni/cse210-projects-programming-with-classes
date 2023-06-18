using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;
    protected Timer timer;
    protected int elapsedSeconds;

    public Activity()
    {
        Console.WriteLine("Enter the duration in seconds:");
        duration = Convert.ToInt32(Console.ReadLine());
        elapsedSeconds = 0;
    }

    protected void ShowStartingMessage(string activityName, string description)
    {
        Console.WriteLine($"Activity: {activityName}");
        Console.WriteLine(description);
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    protected void ShowFinishingMessage(string activityName)
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"You have completed the {activityName} activity for {elapsedSeconds} seconds.");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(1000); // Pause for 1 second
            Console.Write("\b");
        }
    }

    protected void TimerCallback(object state)
    {
        elapsedSeconds++;
        if (elapsedSeconds >= duration)
        {
            timer.Dispose(); // Stop the timer
            ShowFinishingMessage(GetType().Name);
        }
    }

    public abstract void RunActivity();
}
