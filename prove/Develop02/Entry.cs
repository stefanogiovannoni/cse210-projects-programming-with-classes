using System;
using System.Collections.Generic;

class Entry
{
    private string prompt;
    private string answer;
    private DateTime date;

    public Entry(string prompt, string answer)
    {
        this.prompt = prompt;
        this.answer = answer;
        this.date = DateTime.Now;
    }

    public Entry(string prompt, string answer, DateTime date)
    {
        this.prompt = prompt;
        this.answer = answer;
        this.date = date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {prompt}");
        Console.WriteLine(answer);
    }

    public override string ToString()
    {
        return $"{prompt}//{answer}//{date}";
    }
}