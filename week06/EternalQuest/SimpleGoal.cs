public class SimpleGoal : Goal
{
    private bool _isComplete = false;
public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{nameof(SimpleGoal)}:{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}