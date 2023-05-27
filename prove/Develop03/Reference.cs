using System;

public class Reference{

    //variables
    private string _book;
    private int _chapter;
    private int _finalVerse;
    private int _initialVerse;

    //Setters
    public Reference() {
        _book = "Unknown";
        _chapter = 0;
        _initialVerse = 0;
        _finalVerse = 0;
    }

    //Getters
    public Reference(string book, int chapter, int initialVerse, int finalVerse) {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
        _finalVerse = finalVerse;
    }

    public Reference(string book, int chapter, int initialVerse) {
        _book = book;
        _chapter = chapter;
        _initialVerse = initialVerse;
    }

    public string getReference(Reference reference) {
        return reference._book+' '+reference._chapter+' '+reference._initialVerse;
    }
}