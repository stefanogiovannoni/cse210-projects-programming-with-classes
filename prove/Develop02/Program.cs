using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following options:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.WriteLine("What would you like to do?");

        string answer = Console.ReadLine();
        Journal journal = new Journal();

        while (answer != "5")
        {
            if (answer == "1")
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string question = promptGenerator.GetQuestions();
                Console.WriteLine(question);
                string userAnswer = Console.ReadLine();
                Entry entry = new Entry(question, userAnswer);
                journal.AddEntry(entry);
            }
            else if (answer == "2")
            {
                journal.DisplayEntries();
            }
            else if (answer == "3")
            {
                Console.WriteLine("Enter the file name to load from:");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
                Console.WriteLine("Entries loaded successfully!");
            }
            else if (answer == "4")
            {
                Console.WriteLine("Enter the file name to save to:");
                string fileName = Console.ReadLine();
                journal.SaveToFile(fileName);
                Console.WriteLine("Entries saved successfully!");
            }
            else
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            Console.WriteLine("What would you like to do?");
            answer = Console.ReadLine();
        }
    }
}
