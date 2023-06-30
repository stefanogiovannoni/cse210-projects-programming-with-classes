using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Goal> goals = new List<Goal>();
        int score = 0;

        while (true)
        {
            Console.WriteLine("Welcome to the Eternal Quest Program");
            Console.WriteLine("Please select one of the following options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("What would you like to do?");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateNewGoal(goals);
                    break;
                case "2":
                    ListGoals(goals);
                    break;
                case "3":
                    SaveGoals(goals);
                    break;
                case "4":
                    LoadGoals(ref goals);
                    break;
                case "5":
                    RecordEvent(goals, ref score);
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CreateNewGoal(List<Goal> goals)
    {
        Console.WriteLine("Enter the goal description:");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the goal type (1 for Simple Goal, 2 for Eternal Goal, 3 for Checklist Goal):");
        int type = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the points to be earned for completing the goal:");
        int points = int.Parse(Console.ReadLine());

        Goal goal;

        switch (type)
        {
            case 1:
                Console.WriteLine("Enter the reward points for completing the goal:");
                int rewardPoints = int.Parse(Console.ReadLine());
                goal = new SimpleGoal(description, points, rewardPoints);
                break;
            case 2:
                Console.WriteLine("Enter the reward points for each recording:");
                int eternalRewardPoints = int.Parse(Console.ReadLine());
                goal = new EternalGoal(description, points, eternalRewardPoints);
                break;
            case 3:
                Console.WriteLine("Enter the target count for completion:");
                int targetCount = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the bonus points for achieving the target count:");
                int bonusPoints = int.Parse(Console.ReadLine());
                goal = new ChecklistGoal(description, points, targetCount, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type. Creating a Simple Goal by default.");
                Console.WriteLine("Enter the reward points for completing the goal:");
                int defaultRewardPoints = int.Parse(Console.ReadLine());
                goal = new SimpleGoal(description, points, defaultRewardPoints);
                break;
        }

        goals.Add(goal);

        Console.WriteLine("Goal created successfully!");
    }

    static void ListGoals(List<Goal> goals)
    {
        Console.WriteLine("Goals:");

        for (int i = 0; i < goals.Count; i++)
        {
            Goal goal = goals[i];
            string status = goal._completed ? "Completed" : "Incomplete";

            if (goal is ChecklistGoal checklistGoal)
            {
                Console.WriteLine($"{i}. {goal._description} ({status} {checklistGoal._completionCount}/{checklistGoal._targetCount})");
            }
            else
            {
                Console.WriteLine($"{i}. {goal._description} ({status})");
            }
        }
    }

    static void SaveGoals(List<Goal> goals)
    {
        Console.WriteLine("Saving goals...");
       
    }

    static void LoadGoals(ref List<Goal> goals)
    {
        Console.WriteLine("Loading goals...");
        
    }

    static void RecordEvent(List<Goal> goals, ref int score)
    {
        Console.WriteLine("Enter the goal index to record an event:");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < goals.Count)
        {
            Goal goal = goals[index];

            if (goal._completed)
            {
                goal.Complete();
                score = score + goal._points;


                Console.WriteLine($"Event recorded for goal '{goal._description}'. You earned {goal._points} points!");
            }
            else
            {
                Console.WriteLine($"Goal '{goal._description}' is already completed.");
            }
        }
        else
        {
            Console.WriteLine("Invalid goal index. Please try again.");
        }
    }
}