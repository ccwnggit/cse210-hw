using System;

// hold the entry, which is a combination of a prompt and its response

public class Entry

{
    public string _datePrompt;

    public string _prompt;
    public string _date;
    public string _response;

    // public List<string> _biEntries;

    // public Entries()
    // {
    //     _biEntries = new List<string>();
    // }

    
    public void DisplayPrompt()     // This is to display the prompt only
    {  
        Console.WriteLine(_prompt);
    }

    // public List<string> Display()   // This is for displaying the journal: display the date, prompt and journal entry
    public void Display()
    {

        string l1 = _datePrompt;
        string l2 = _response;
        Console.WriteLine(l1);
        Console.WriteLine(l2);


    }
    
}