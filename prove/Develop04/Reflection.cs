using System;
using System.Threading;

public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity() : base()
    {
        string description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        ShowStartingMessage("Reflection", description);
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
            ShowSpinner(3); // Pause for 3 seconds while showing spinner

            foreach (string question in reflectionQuestions)
            {
                Console.WriteLine(question);
                Thread.Sleep(2000); // Pause for 2 seconds
                ShowSpinner(3); // Pause for 3 seconds while showing spinner
            }
        }
    }
}
