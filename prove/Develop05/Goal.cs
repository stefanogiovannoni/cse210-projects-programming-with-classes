abstract class Goal
{
    public string _description; 
    public int _points;
    public bool _completed;

    public Goal(string description, int points)
    {
        _description = description;
        _points = points;
        _completed = false;
    }

    public abstract void Complete();
}


