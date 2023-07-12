using System;

public class Program
{
    public static void Main(string[] args)
    {
    
        Address firstAddress = new Address("Comandate Cabot 473", "Rio Grande", "Tierra del Fuego", "Argentina");
        Address secondAddress = new Address("Marienstrasse 33", "Salzwedel", "Sachen-Anhalt", "Germany");
        Address thirdAddress = new Address("R. Jardim Botânico 414 ", "Rio de Janeiro", "Estado de Rio de Janeiro", "Brazil");

        Lecture lecture = new Lecture("The end of economic crisis", "Speaker will present his new book about how the end the economic crisis", DateTime.Now, TimeSpan.FromHours(2), firstAddress, "Javier Milei", 25000, "Presentation");
        Reception reception = new Reception("Stefano's wedding", "The wedding will be transmited in several platforms and ", DateTime.Now, TimeSpan.FromHours(3), secondAddress, "Lolapalooza.Official@hotmail.com", "Wedding");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Lolapalooza", "Multiple bands and single artists giving concerts outdoor", DateTime.Now, TimeSpan.FromHours(4), thirdAddress, "Sunny", "Show");

        Console.WriteLine("First event standard details:\n");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("First event full details:\n");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("First even short description:\n");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();
        
        Console.WriteLine("Second event standard details:\n");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Second event full details:\n");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Second event short description:\n");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Third event standard details:\n");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine("Third event full details:\n");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Third event short description:\n");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }
}
