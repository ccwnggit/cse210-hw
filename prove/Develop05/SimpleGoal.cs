public class SimpleGoal :Goal

{

int _completionPoints;                  // score for the completion
bool _completionInd;


public SimpleGoal()
{
    _completionPoints = 0;
    _completionInd = false;
}
public SimpleGoal (string name, string description, int completionPoints, string placeholder): base (name, description, placeholder)
{
    _completionPoints = completionPoints;
    _completionInd = false;
}

public void SetCompletionInd(bool value)
{
    _completionInd = value;
}

public void SetCompletionPlaceholder(bool value)
{
    if (value)
    {
        _completionPlaceholder="X";
    }
    else
    {
        _completionPlaceholder = " ";
    }
}
public override void Display(string placeholder)
    {
            if (_completionInd)
            {
                _completionPlaceholder = "X";
                placeholder = _completionPlaceholder;

            }
            Console.WriteLine($"[{placeholder}] {_name} ({_description})");
    }

public override void DisplayCompleted(ref int totalPoints)
    {
        
        Console.WriteLine ($"Congratulation! You have completed your goal. You scored {_completionPoints} points for this. ");
        base.SetPlaceholder(true);
        base.AddPoints(_completionPoints);
        totalPoints = totalPoints + _completionPoints;
        _completionInd = true;
    }


public override string GetSaveString()
    {
        string goalLine = $"Simple Goal:{_name},{_description},{_completionPoints},{_completionInd}";
        return goalLine;
    }

}

