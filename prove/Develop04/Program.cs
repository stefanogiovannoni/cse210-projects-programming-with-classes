using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("===== Welcome to the Activity Program =====");

        while (true)
        {
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Activity activity;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                case 4:
                    Console.WriteLine("Thank you! Have a great day!");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    continue;
            }

            activity.RunActivity();

            Console.WriteLine("Press any key to continue or 'Q' to quit.");
            var key = Console.ReadKey();
            if (key.KeyChar == 'q' || key.KeyChar == 'Q')
            {
                Console.WriteLine("Thank you! Have a great day!");
                Console.ReadKey();
                return;
            }

            Console.WriteLine();
        }
    }
}