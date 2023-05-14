public class PromptGenerator
{
    public List<string> _randomQuestions = new List<string>();
    public PromptGenerator() {
    _randomQuestions.Add("Who was the most interesting person I interacted with today?");
    _randomQuestions.Add("What was the best part of my day?" );
    _randomQuestions.Add("How did I see the hand of the Lord in my life today?" );
    _randomQuestions.Add("What was the strongest emotion I felt today?" );
    _randomQuestions.Add("Who was the most interesting person I interacted with today?" );
    _randomQuestions.Add("Who was the most interesting person I interacted with today?" );
    _randomQuestions.Add("Who was the most interesting person I interacted with today?" );
    }
    
    public string GetQuestions(){
        Random randomquestions = new Random(); 
        int number = randomquestions.Next(_randomQuestions.Count);
        return _randomQuestions[number];

        }

    
    public void DisplayEntries(){    }
    public void SaveToFile(string filename){    }
    public void LoadFromFile(string filename){    }
}
    
