public class Activity

{
    private string _startingMessage = "";
    private string _endingMessage = "You have done a good job!\n";
    private string _activityName;
    private string _activityDescription;
    private int _duration;


    public void setActivityName(string name)
    {
        _activityName = name;

    }

    public void setActivityDescription(string description)
    {
        _activityDescription = description;
    }

    public void setDuration(int seconds)
    {
        _duration = seconds;
    }
    
    public string GetStartingMessage()
    {
        _startingMessage = $"Welcome to the {_activityName} Activity.\n";
        return _startingMessage;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }

    public void SpinnerPausing(int seconds)
    {   
        for (int i =0; i< seconds/2; i++)
        {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        }
    }

    public void CountdownTimer(int seconds)

    {
        for (int i =0; i< seconds; i++)
        {
        Console.Write(seconds-i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        
        }
    }
}