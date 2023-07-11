using System;

class Program
{
        /* Added creativity: use system time as a seed for random number. This ensure a more random outcome of questions generated.*/


    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");
        /* Display the menu */
        Menu m1 = new Menu ();
        string inputOption = null;
        Activity a1 = new Activity ();

        do
        {
            inputOption = m1.MenuOption();  // get user input
            if (inputOption == "1")
            {
                BreathingActivity b1 = new BreathingActivity ();
                b1.RunActivity();
            }
            else if (inputOption == "2")
            {
                
                ReflectingActivity r1= new ReflectingActivity ();
                List <string> prompts= new List<string>()
                {
                    "Think of a time when you stood up for someone else.",
                    "Think of a time when you did something really difficult.",
                    "Think of a time when you helped someone in need.",
                    "Think of a time when you did something truely selfless",
                };

                List <string> questions = new List<string> ()
                {
                    "Why was this experience meaningful to you? ",
                    "Have you ever done anything like this before? ",
                    "How did you get started? ",
                    "How did you feel when it was complete? ",
                    "What made this time different than other times when you were not as successful? ",
                    "What is your favorite thing about this experience? ",
                    "What could you learn from this experience that applies to other situations? ",
                    "What did you learn about yourself through this experience? ",
                    "How can you keep this experience in mind in the future? ",

                };
                r1.SetMessages(prompts, questions);

                r1.RunActivity();
            }
            else if (inputOption == "3")
            {
                ListingActivity l1 = new ListingActivity ();

                List <string> prompts = new List <string> ()
                {
                    "Who are people that you appreciate?",
                    "What are personal strengths of yours?",
                    "Who are people that you have helped this week?",
                    "When have felt the Holy Ghost this month?",
                    "Who are some of your personal heroes?"

                };
                l1.SetPrompts(prompts);
                
                l1.RunActivity();
            }

        } while ( inputOption != "4");
        

    }
}
