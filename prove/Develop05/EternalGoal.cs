public class EternalGoal : Goal

{
    private int _eachTimeScore;

    private int _points;

    public EternalGoal()
    {
        _eachTimeScore = 0;
        _points = 0;

    }

    public EternalGoal(string name, string description, string completionPlaceholder, int eachTimeScore) : base (name, description, completionPlaceholder)
    {
        _eachTimeScore = eachTimeScore;
    }

    public void SetEachTimeScore(int points)
    {
        _eachTimeScore = points;
    }

    public int GetEachTimeScore()
    {
        return _eachTimeScore;
    }

    public override void Display(string placeholder)
    {
        Console.WriteLine($"[{placeholder}] {_name} ({_description})");
    }

    public override void DisplayCompleted(ref int totalPoints)
    {
        Console.WriteLine ($"Congratulation! You have completed your goal. You scored {_eachTimeScore} points for this. ");
        _points = _points + _eachTimeScore;
        base.AddPoints(_eachTimeScore);
        totalPoints = totalPoints + _eachTimeScore;
    }

    public override string GetSaveString()
    {
        string goalLine = $"Eternal Goal:{GetGoalName()},{_description},{_eachTimeScore}";
        return goalLine;
    }
    

}