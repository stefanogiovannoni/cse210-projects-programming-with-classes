class EternalGoal : Goal
{
    public int RewardPoints { get; }

    public EternalGoal(string description, int points, int rewardPoints) : base(description, points)
    {
        RewardPoints = rewardPoints;
    }

    public override void Complete()
    {
        
    }
}