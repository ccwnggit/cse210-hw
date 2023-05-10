using System;

class Program
{
    static void Main(string[] args)
    {
        string letter="";
        Console.WriteLine("Hello Prep2 World!");
        Console.Write("Enter grade percentage: ");
        string gradePercentage = Console.ReadLine();
        int numGradePercentage = int.Parse(gradePercentage);

        if (numGradePercentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed the course. ");

        }
        if (numGradePercentage >= 90)
        {   
            letter = "A";
            
        }
        else if (numGradePercentage >= 80)
        {
            letter = "B";
        }
        else if (numGradePercentage >= 70)
        {
            letter = "C";
        }
        else if (numGradePercentage >= 60)
        {
            letter = "D";
        }
        else if (numGradePercentage < 60)
        {
            letter = "F";
    
        }
        Console.WriteLine($"Your grade is: {letter}");
        
    }
}