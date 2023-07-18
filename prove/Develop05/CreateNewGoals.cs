public class CreateNewGoals

{
    public Goal CreateGoals()
    {
        
        
        List <Goal> goals = new List<Goal>();

            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goals");
            Console.WriteLine("2. Eternal Goals");
            Console.WriteLine("3. Checklist Goals\n");
            Console.Write("Which type of goals would you like to create (1-3)(type 4 to quit)? ");
            string goalType = Console.ReadLine();
            

            if (goalType == "1")
            {   // Simple Goal
                
                Console.WriteLine("What is the name of your goal? ");
                string SimpleGoalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                string SimpleGoalDescription = Console.ReadLine();
                Console.WriteLine ("What is the amount of points associated with this goal? ");
                string input = Console.ReadLine();
                int SimpleGoalCompletionPoints = int.Parse(input);
                
                SimpleGoal newGoal = new SimpleGoal(SimpleGoalName,SimpleGoalDescription, SimpleGoalCompletionPoints," ");
                // goals.Add(newGoal);
                
                return newGoal;
                
            }
            else if (goalType == "2")
            {   // Eternal Goal

                Console.WriteLine("What is the name of your goal? ");
                string EternalGoalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                string EternalGoalDescription = Console.ReadLine();
                Console.WriteLine ("What is the amount of points associated with this goal? ");
                string input = Console.ReadLine();
                int EternalGoalCompletionPoints = int.Parse(input);
                EternalGoal newGoal = new EternalGoal(EternalGoalName,EternalGoalDescription," ", EternalGoalCompletionPoints);
                // goals.Add(newGoal);
                return newGoal;
            }
            else if (goalType == "3")
            {   // Checklist Goal
                Console.WriteLine("What is the name of your goal? ");
                string ChecklistGoalName = Console.ReadLine();
                Console.WriteLine("What is a short description of it? ");
                string ChecklistGoalDescription = Console.ReadLine();
                Console.WriteLine ("What is the amount of points associated with each time this goal is completed? ");
                string input1 = Console.ReadLine();
                int ChecklistInterimCompletionPoints = int.Parse(input1);
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
                string input2 = Console.ReadLine();
                int RepeatForBonus = int.Parse(input2);
                Console.WriteLine("What is the bonus for accomplishing it that many times? ");
                string input3 = Console.ReadLine();
                int Bonus = int.Parse(input3);
                
                ChecklistGoal newGoal = new ChecklistGoal(ChecklistGoalName,ChecklistGoalDescription," ", ChecklistInterimCompletionPoints, RepeatForBonus, Bonus);
                
                
                return newGoal;
            }

            else
            {
                Console.WriteLine("Please choose between 1-3 only. Quit...");
                Thread.Sleep(1000);
                
                return null;
                

            }
        

        
        
    }
}