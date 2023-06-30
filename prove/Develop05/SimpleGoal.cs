class SimpleGoal : Goal
{
    public int RewardPoints { get; }

    public SimpleGoal(string description, int points, int rewardPoints) : base(description, points)
    {
        RewardPoints = rewardPoints;
    }

    public override void Complete()
    {
        _completed = true;
    }
}
