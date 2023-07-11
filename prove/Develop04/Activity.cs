public class Activity

{
    private string _startingMessage = "";
    private string _endingMessage = "You have done a good job!";


    public string GetStartingMessage()
    {
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