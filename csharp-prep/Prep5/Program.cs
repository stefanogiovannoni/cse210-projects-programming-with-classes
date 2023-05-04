using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(userNumber);
        DisplayResult(userName, squaredNumber);
        
        static void DisplayMessage()
        {
        Console.WriteLine("Welcome to the program!");
        }


        //Enter name
        

        static string PromptUserName()
        {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
        
        }
        


        //Enter favorite number
        
        static int PromptUserNumber()
        {
        int userNumber = -1;
        Console.Write("Please enter your favorite number: ");
        userNumber = int.Parse(Console.ReadLine());
        return userNumber;
        }
        

        static int SquareNumber(int first)
        {
            int squared = first * first ;
            return squared;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}.");
        }

    }

}