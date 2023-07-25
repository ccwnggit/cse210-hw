public class ListingActivity : Activity

/* Guide the user to think broadly, by helping them list as many things as they can in a certain area of strength or positivty. They might discover more breadth than they previously realized. */

{
    private int _inputSeconds;

    private List <string> _randomPrompt;
    private string _name = "Listing";


    public ListingActivity()
    {
        _randomPrompt=null;
        _inputSeconds = 0;
    }
    public void RunActivity()
    {


        // Display welcome message
        DisplayPrompt();
        string inputSeconds = Console.ReadLine();
        _inputSeconds = int.Parse(inputSeconds);


        //Get random prompt
        Random rnd = new Random(DateTime.Now.Millisecond);
        int num = rnd.Next(0,5);
        GetRandomPrompt(num);
        SpinnerPausing(5);
        Console.Write("You may begin in: ");
        CountdownTimer(5);
        Console.WriteLine();



        // keep time
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_inputSeconds);

        // Get Answers from user
        int inputItemsCount = 0;
        DateTime currentTime;
        do  
        {
            Console.Write(">");
            Console.ReadLine();
            inputItemsCount ++;
            currentTime = DateTime.Now;
        } while (currentTime<futureTime);

        Console.WriteLine($"You listed {inputItemsCount} items!\n");
        Console.WriteLine("Well done!!\n");
        Console.WriteLine($"You have completed another {_inputSeconds} seconds of the Listing Activity");
        Console.WriteLine(GetEndingMessage());
        SpinnerPausing(12);
    }

    public void SetPrompts(List <string> prompts)
    {
        _randomPrompt = prompts;
    }

    private void GetRandomPrompt (int jam)
    {
        // _randomPrompt[0] = "Who are people that you appreciate?";
        // _randomPrompt [1] = "What are personal strengths of yours?";
        // _randomPrompt [2] = "Who are people that you have helped this week?";
        // _randomPrompt [3] = "When have felt the Holy Ghost this month?";
        // _randomPrompt [4] = "Who are some of your personal heroes?";

        Console.WriteLine("Get ready...\n");
        SpinnerPausing(5);
        Console.WriteLine("List as many responses you can do to the following prompt:");        Console.WriteLine($"--- {_randomPrompt[jam]} ---");
        
        
        

    }






private void DisplayPrompt()
    {
        setActivityName(_name);
        Console.WriteLine(GetStartingMessage());
        Console.WriteLine("This Activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("How long, in seconds, would you like for your session? ");

    }
}