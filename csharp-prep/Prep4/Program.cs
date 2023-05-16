using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<int> numbers;
        numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int num;
        do
        {
        Console.Write("Enter number: ");
        string number1 = Console.ReadLine();
        num = int.Parse(number1);
        
        if (num !=0)
        {numbers.Add(num);
        }
        } while (num != 0);

        int computeTotal = 0;
        float computeAverage = 0;
        int largestNum = 0; 

        // Calculate the sum 
        for (int i=0; i< numbers.Count; i++)
        {
            computeTotal = computeTotal + numbers[i];
            if (numbers[i]>largestNum)
            {
                largestNum = numbers[i];
            }

        }
        computeAverage = (float) computeTotal / numbers.Count;

        Console.WriteLine($"The sum is {computeTotal}");
        Console.WriteLine($"The average is {computeAverage}");
        Console.WriteLine($"The largest number is {largestNum}");


    }
}