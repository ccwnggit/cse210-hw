public class ChecklistGoal: Goal
{
    private int _interimPoints;
   
    private int _numTimesForBonus;
    private int _bonus;

    private int _timesCompleted; 



    public ChecklistGoal()
    {
        _interimPoints = 0;
        _numTimesForBonus = 0;
        _bonus = 0;
        _timesCompleted = 0;

    }
    
    public ChecklistGoal (string ChecklistGoalName,string ChecklistGoalDescription,string completionPlaceholder, int ChecklistInterimCompletionPoints, int RepeatForBonus, int Bonus): base (ChecklistGoalName,ChecklistGoalDescription, completionPlaceholder)
    {
        _interimPoints = ChecklistInterimCompletionPoints;
        _numTimesForBonus = RepeatForBonus;
        _bonus = Bonus;
        _timesCompleted = 0;
    }

    public void SetTimesCompleted(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }
    public void RecordEvent(int times)
    {
        _timesCompleted =+ times;
    }





    public override void Display(string placeholder)
    {
        Console.WriteLine($"[{placeholder}] {_name} ({_description}) - currently completed: {_timesCompleted}/{_numTimesForBonus}");
    }

    public override void DisplayCompleted(ref int totalPoints)
    {   
        // check if eligible for bonus
        int pointGainedThisTime = _interimPoints;

        _timesCompleted ++;
        if (_timesCompleted % _numTimesForBonus ==0)            // will score bonus having accomplished it that many times
        {   // add bonus to accumulated points in this goal
            pointGainedThisTime = pointGainedThisTime + _bonus;

            base.SetPlaceholder(true);
            Console.WriteLine ($"Congratulation! You scored bonus and thus {pointGainedThisTime} points. ");
        }
        else
        {
            Console.WriteLine ($"Congratulation! You scored {pointGainedThisTime} points. ");
        }
        base.AddPoints(pointGainedThisTime);  // bonus plus point gained each time to the base
        totalPoints = totalPoints + pointGainedThisTime;

    
    }

    
    public int GetInterimPoints()
    {
        return _interimPoints;
    }
    public override string GetSaveString()
    {
        string goalLine = "Checklist Goal:"+GetGoalName() + "," + GetGoalDescription() + "," + GetPlaceholder()+","+_interimPoints +","+_numTimesForBonus+","+ _bonus +","+_timesCompleted;
        return goalLine;
    }
    
}