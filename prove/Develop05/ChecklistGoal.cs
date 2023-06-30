class ChecklistGoal : Goal
{
    public int _completionCount { get; private set; }
    public int _targetCount { get; }
    public int _bonusPoints { get; }

    public ChecklistGoal(string description, int points, int targetCount, int bonusPoints) : base(description, points)
    {
        _completionCount = 0;
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
    }

    public override void Complete()
{
    if (_completionCount < _targetCount)
    {
        _completionCount = _completionCount + 1;
    }

    if (_completionCount == _targetCount)
    {
        _completed = true;
    }
}
}