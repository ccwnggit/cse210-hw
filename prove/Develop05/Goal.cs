public abstract class Goal

{
    protected string _name;
    protected string _description;

    protected string _completionPlaceholder;

    protected int _points;        // saved points of individual goal


    public Goal()
    {
        _name = null;
        _description = null;
        _completionPlaceholder = "";
        _points = 0;

    }
    public Goal(string name, string description, string placeholder)
    {
        _name = name;
        _description = description;
        _completionPlaceholder = placeholder;
        _points = 0;
    }


    public string GetGoalName()
    {
        return _name;

    }

    public string GetGoalDescription()
    {
        return _description;

    }

    public string GetPlaceholder()
    {
        return _completionPlaceholder; 

    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
    public void AddPoints(int points)
    {
        _points = _points + points;
        
    }

    public void SetPlaceholder(bool indicator)
    {
        if (indicator)
        {
            _completionPlaceholder = "X";
        }
        else
        {
            _completionPlaceholder = " ";
        }
    }
    

    public abstract void Display(string placeholder);

    public abstract void DisplayCompleted(ref int totalPoints);

    public abstract string GetSaveString();
    


 
}