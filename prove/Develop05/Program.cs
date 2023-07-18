using System;

class Program
{   

    /* additional creativity:
    1. Telling the user of no goal set when there is not yet any goal set
    2. When recording the event, the program checks whether the user has input a out-of-bound goal number
    3. When loading the goals from a file, other goal types not within the presumed list will not be loaded.
    4. When bonus is obtained, the congratulation message include this information
    5. Bonus is given each time the goals are accomplished that number of times
    
    */
    public static List <Goal> _goals;
    public static int totalPoints=0;                  // store the total points of all goals

    static void Main(string[] args)
    {
            
        string OptionInput="";
        _goals = null;

        
        // int goalNum = 0;
        do
        {                                                               // perform menu option accordingly
            

            Console.WriteLine($"You have {totalPoints} points.\n");

            OptionInput = MenuDisplay();
            
            if (OptionInput == "1")
            {                                                       // create new goals from the user

                CreateNewGoals G = new CreateNewGoals();
                Goal g = G.CreateGoals();
    
                // initiaise the list of goals
                if (_goals == null)
                {
                    List <Goal> dummy = new List<Goal> ();
                    _goals = dummy;
                }

                // add new goal(s) to the list
                if (g != null)
                {
                    _goals.Add(g);
                }
                
            }
            else if (OptionInput == "2")
            {                                                    // list the goals if the list is not empty
                                                                
                if (_goals != null)
                {
                    foreach (Goal g in _goals)
                    {
                        string x = g.GetPlaceholder();
                        g.Display(x);
                    }
                }
                else
                {
                    Console.WriteLine("You have not yet set any goal. ");
                }
            }

            else if (OptionInput =="3")
            {                                                   //save the goals
                Console.WriteLine("What is the name of the file you want to save to? ");
                string filename = Console.ReadLine();
               
                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine(totalPoints);
                    
                    // You can use the $ and include variables just like with Console.WriteLine
                    foreach (Goal g in _goals)
                    {
                        string goalLine = g.GetSaveString();
                        outputFile.WriteLine(goalLine);
                    }
                }
            }
            

            else if (OptionInput =="4")
            {                                                    // load the goals from a file
                Console.WriteLine("What is the name of the file to be loaded from? ");
                string InputFile = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(InputFile);

                // _goals = null;
                // if (_goals == null)
                {                                              // create an instance
                    List <Goal> dummy = new List<Goal> ();
                    _goals = dummy;
                }
                totalPoints= int.Parse(lines[0]);       // first line being the total points
                
               

                for (int i=1; i<lines.Count(); i++)
                {
                    string[] parts = lines[i].Split(":");   // split to obtain the goal type
                    
                    Goal goal = CreateGoal(parts[0], parts[1]);
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }

            else if (OptionInput == "5")
            {                                                    // record the completion of the goal
            
                int goalNum = 0;
                if (_goals != null)
                {
                    // check the list of goals
                    int j = _goals.Count();
                    for (int i = 0; i< j; i++)      // list out all the goals
                    {   
                        Console.WriteLine($"{i+1}. {_goals[i].GetGoalName()}");
                    }
                    Console.WriteLine("Which goal did you accomplish? ");
                    string input = Console.ReadLine();
                    goalNum = int.Parse(input);
                    int listNum = goalNum -1; 
                    if (goalNum <= _goals.Count)    // if the goal number entered is not bigger than the number of goals
                    {
                        // calculate the points and display the message for the completion
                        _goals[listNum].DisplayCompleted(ref totalPoints);
            
                        Console.WriteLine($"You now have {totalPoints} points.\n");  // Print the total score.
                    }
                    else
                    {
                        Console.WriteLine("The number input is incorrect. ");
                    }
                }
                else
                {
                    Console.WriteLine("You have 0 goals set. ");
                }
                
            }
        } while (OptionInput != "6");
    }

    static string MenuDisplay()
    {                                                                   // display the menu and accept the user's input, return the user's input
       
        Console.WriteLine("1. Create New Goals");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit\n");
        Console.Write("Select a choice from the menu: ");
        string inputOption = Console.ReadLine();
        return inputOption;
        
    }

    static Goal CreateGoal(string goalType, string goalParameters)
    {
        string [] parts = goalParameters.Split(","); // split the second part into separate elements
        if (goalType == "Simple Goal")
        {
            SimpleGoal s= new SimpleGoal(parts[0],parts[1],int.Parse(parts[2]),"X");
            if (parts[3]=="True")
            {
                s.SetCompletionInd(true);
                s.SetCompletionPlaceholder(true);

            }
            else
            {
                s.SetCompletionInd(false);
                s.SetCompletionPlaceholder(false);
            }
            return s;
        }
        else if (goalType == "Eternal Goal")
        {
            EternalGoal s = new EternalGoal(parts[0], parts[1]," ", int.Parse(parts[2]));
            return s;
        }
        else if (goalType == "Checklist Goal")
        {
            ChecklistGoal s = new ChecklistGoal (parts[0], parts[1], parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]));
            
            
            s.SetTimesCompleted(int.Parse(parts[6])); // load the number of times the goals have ever been completed
            return s;
        }
        else
        {
            return null;
        }

    }



    
}