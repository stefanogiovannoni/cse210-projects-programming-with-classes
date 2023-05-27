using System;

public class Scripture{
    //attritute with list

    private List<Word> _words = new List<Word>();
    private Reference _reference;
 

    public Scripture(){ }

    public Scripture(string scripture, Reference reference) {
        
        _reference = reference;

        char delimiter = ' ';        
        string[] wordsArray = scripture.Split(delimiter);

        foreach (string wordText in wordsArray)
        {
            Word word= new Word(wordText, true);
            _words.Add(word);            
        }        
    }

    public void DisplayScripture(Scripture scriptureArray, Reference reference){
        
        Console.WriteLine(reference.getReference(reference));

        foreach (Word i in scriptureArray.getScripture(scriptureArray)) {            
            Console.Write(i.getWordContent(i)+' ');
        }
    }
    //Display Method

    public Scripture[] CreateScriptures()
    {            
        Reference reference = new Reference("Eter", 12, 6);
        Scripture scripture = new Scripture("And now, I, Moroni, would speak somewhat conerning these things...", reference);

        Reference reference1 = new Reference("John", 6, 56);
        Scripture scripture1 = new Scripture("He that eateth my flesh, and drinketh my blood, dwelleth in me, and I in him.", reference1);

        Reference reference2 = new Reference("Moroni", 10, 4, 5);
        Scripture scripture2 = new Scripture("And when ye shall receive these things, I would exhort you that ye would aask God, the Eternal Father, in the name of Christ, if these things are not btrue; and if ye shall ask with a csincere heart, with dreal intent, having efaith in Christ, he will fmanifest the gtruth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may aknow the btruth of all things.", reference2);
        
        Scripture[] scripturesArray = new Scripture[3];
        scripturesArray[0] = scripture;
        scripturesArray[1] = scripture1;
        scripturesArray[2] = scripture2;

        return scripturesArray;
    }
    public List<Word> getScripture(Scripture scripture){
        return scripture._words;
    }

    public Reference getReference(Scripture scripture){
        return scripture._reference;
    }

    public void HideWordsScripture(Scripture scriptureArray, Reference reference, int wordsToHide){

        List<Word> words = scriptureArray.getScripture(scriptureArray);

        int wordsNumber = words.Count();

        for (int i = 0; i < wordsToHide; i++) {
            
            Random rnd = new Random();
            int index = rnd.Next(0,wordsNumber);

            if(words[index].getStatusWord(words[index])==true){
                words[index].setStatusWord(words[index],false);
            }

        }        
    }
}