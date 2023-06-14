using System;
using System.Collections.Generic;

public class PromptGenerator

{
    public List<string> _promptsList;
    
    public int Generate(int i)                   // generate from a list of i prompts

    {
        // PromptGenerator p = new PromptGenerator();
        // p._promptsList.Add("If I had one thing I could do over today, what would it be?");
        // p._promptsList.Add("What was the best part of my day?");
        // p._promptsList.Add("Who was the most interesting person I interacted with today?");
        // p._promptsList.Add("How did I feel the hand of the Lord in my life today?");
        // p._promptsList.Add("What was the strongest emotion I felt today?");

        Random rnd = new Random();
        int num = rnd.Next(i);
        // string prompt = _promptsList[num];
        
        return num;
    }
}