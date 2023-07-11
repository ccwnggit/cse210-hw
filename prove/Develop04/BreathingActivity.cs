public class BreathingActivity : Activity

{
    
    private int _inputSeconds;

    public void RunActivity()
    {
        DisplayMessage();
        BreathingRoutine();
    }
    public void DisplayMessage()
    {
        
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This Activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.Write("How long, in seconds, would you like for your session? ");
        string inputSeconds = Console.ReadLine();
        _inputSeconds = int.Parse(inputSeconds);
        
    }

    public void BreathingRoutine()
    {

        Console.WriteLine("Get ready... \n\n");
        SpinnerPausing(5);

        // keep time
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_inputSeconds);
        
        // for (int k=0; k< _inputSeconds; k++)
        do
        {
        
        Console.WriteLine("Breathe in...");
        CountdownTimer(5);
        Console.WriteLine("Now breathe out...");
        CountdownTimer(6);
    
        }   while (DateTime.Now <= futureTime);

        Console.WriteLine("Well done!!");
        SpinnerPausing(4);




    }

}