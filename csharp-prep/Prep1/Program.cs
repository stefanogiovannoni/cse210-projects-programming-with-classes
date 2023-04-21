using System;

class Program
{
    static void Main(string[] args)
    {
        //Making sure this shows up in GitHub
        Console.Write("What is your first name? ");
        string name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine($"Your name is {lastname}, {name} {lastname}.");
    }
}