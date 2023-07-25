public class ReflectingActivity : Activity

    
/* Guide the user to think deeply, by having them consider a certain experience when they were successful or demonstrated strength.
    Then, pormpt them with questions to reflect more deeply about details of the experience. */
{


    private int _inputSeconds;

    private List<string> _randomPrompts;
    
    private List <string> _randomQuestions;

    private string _name = "Reflecting";
    private string _activityDescription = "This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of yor life.";
    


    public ReflectingActivity()
    {   _randomPrompts = null;
        _randomQuestions = null;
        setActivityName(_name);
        setActivityDescription(_activityDescription);
    }

    
    public void RunActivity()
    {

        // Display welcome message
        DisplayPrompt();
        string inputSeconds = Console.ReadLine();
        _inputSeconds = int.Parse(inputSeconds);

        // Get random prompt
        Random rnd = new Random(DateTime.Now.Millisecond);
        int num = rnd.Next(0,4);
        GetRandomPrompt(num);
        


        // keep time
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_inputSeconds);

        DateTime currentTime;

        do
        {
        num = rnd.Next(9);
        GetRandomQuestion(num);
        SpinnerPausing(8);
    
        currentTime = DateTime.Now;
        } while (currentTime < futureTime);
        
        // Display motivation
        Console.WriteLine("Well done!!");
        Console.WriteLine($"You have completed another {_inputSeconds} seconds of the Reflecting Activity");
        Console.WriteLine(GetEndingMessage());
        SpinnerPausing(12);

    }   


    public void SetMessages(List<string> prompts, List<string> questions)

    {
        _randomPrompts = prompts;
        _randomQuestions = questions;

    }
    private void GetRandomPrompt(int jam)
    {
        Console.WriteLine("Get ready...\n");
        Console.WriteLine("Consider the following prompt: \n");
        
        Console.WriteLine($"--- {_randomPrompts[jam]} ---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience. ");
        Console.Write("You may begin in: ");
        CountdownTimer(5);
             

    }
    private void GetRandomQuestion(int jam)
    {
        Console.WriteLine();
        Console.WriteLine($"--- {_randomQuestions[jam]} ---\n");
        

    }

    private void DisplayPrompt()
    {   
        setActivityName(_name);
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine("This Activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of yor life.");
        Console.Write("How long, in seconds, would you like for your session? ");

    }

   


}