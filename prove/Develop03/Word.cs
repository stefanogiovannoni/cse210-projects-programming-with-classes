using System;

public class Word{
    //attributes

    private string _wordContent;
    private Boolean _status;
    
    public Word(string wordContent, Boolean status) {
        _wordContent = wordContent;
        _status = status;
    }   
    
    public string getWordContent(Word word) {
        if(word._status == true){
            return word._wordContent;
        }else{
            return "___";
        }
    }

    public void setStatusWord(Word word, Boolean status) {
        word._status = status;
    }

    public Boolean getStatusWord(Word word) {
        return word._status;
    }
}