using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture();
        Scripture[] scripturesArray = scripture.CreateScriptures();

        int maxLength = scripturesArray.GetLength(0);
        
        Random rnd = new Random();
        int index = rnd.Next(0,maxLength);

        Scripture scriptureArray = scripturesArray[index];
        Reference reference = scriptureArray.getReference(scriptureArray);      
        
        string choice = "";
        do
        {
            scriptureArray.DisplayScripture(scriptureArray, reference);
            Console.WriteLine("\n\nPlease enter to continue or type 'quit' to finish");
            choice = Console.ReadLine();
            if(choice!="quit"){
                scriptureArray.HideWordsScripture(scriptureArray, reference, 2);
            } 

        }while(choice!="quit");
    }
} 