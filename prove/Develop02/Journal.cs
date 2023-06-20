using System.Collections.Generic;
using System.IO;

public class Journal

{
    public string _owner;
    public List<Entry> _journalEntries;

    public List<String> _promptsList;   // for prompt generation
    

    public void NewEntry()
    // Show a random prompt, save the response and the date as an Entry

    {
        // prompt generation
        PromptGenerator p = new PromptGenerator();              // 

        p._promptsList = new List<string>();
        
        string p1 = "If I had one thing I could do over today, what would it be?";
        p._promptsList.Add(p1);
        p._promptsList.Add("What was the best part of my day?");
        p._promptsList.Add("Who was the most interesting person I interacted with today?");
        p._promptsList.Add("How did I feel the hand of the Lord in my life today?");
        p._promptsList.Add("What was the strongest emotion I felt today?");

        // Display the prompt
        int num = p.Generate(5);
        Console.WriteLine(p._promptsList[num]);

        //Find the current date
        DateTime theCurrentTime = DateTime.Now;                 //Find the current date
        string dateText = theCurrentTime.ToShortDateString();   // Convert it to a short date string type

        // initialise _journalEntries if not already initialized
        if (_journalEntries == null)
        {
            List<Entry> entries = new List<Entry>();
            _journalEntries = entries;
        }

        

        //Combined the date and the prompt to form _datePrompt in a journal entry
        Entry entry = new Entry();
        entry._datePrompt = dateText + " " + p._promptsList[num];

        //Record the date and prompt in entry 
        entry._date = dateText;
        entry._prompt = p._promptsList[num];

        //Ask the user to input response
        entry._response = Console.ReadLine();

        //Add the prompt and responses to the Journal
        // Journal myJournal = new Journal();
        _owner = "Cosmo";
        _journalEntries.Add(entry);

        Display();

        
    }

    public void Display()
    // Display the Journal, iterate through all entries in the journal and display them to the screen
    {
        // string fileName = "myFile.txt";
        // string [] lines = System.IO.File.ReadAllLines(fileName);
        if (_journalEntries == null)
        {
            List<Entry> entries = new List<Entry>();
            _journalEntries = entries;
        }
        foreach (Entry entry in _journalEntries)
        {
            Console.WriteLine(entry._datePrompt);
            Console.WriteLine(entry._response);
        }

    }

    public void Save()
    // Save the current journal (the complete list of entries) to that file location
    {
        string filename = "myjournal.txt";
        Console.Write("Save your entries to myjournal.txt? (Y/N) ");
        string truefalsefileName = Console.ReadLine();        

        if (truefalsefileName == "N")
        {
            Console.Write("Input another file: ");
            filename = Console.ReadLine();
        }
        
        if (_journalEntries == null)
        {
            List<Entry> entries = new List<Entry>();
            _journalEntries = entries;
        }

        
        using (StreamWriter outputFile = new StreamWriter(filename, true)) // Append to the file

        {
            foreach (Entry entry in _journalEntries)
            {
            outputFile.WriteLine($"{entry._date},{entry._prompt},{entry._response}");
            }
        }
            
        
        

    }

    public void Load()
    // Load the journal from a file - Prompt the user for a filename and then load the current journal to that file location //

    {
        _owner = "Cosmo";
        
        // clear existing _journalEntries entries before loading from a file
        _journalEntries = new List<Entry>();
        
        Console.Write ("To load myjournal.txt ? (Y/N) ");
        string truefalsefileName = Console.ReadLine();
        string filename = "myjournal.txt";
        if (truefalsefileName == "N")
        {
            Console.Write("Please enter the name of the file: ");
            filename = Console.ReadLine();
        }

        string[] lines = System.IO.File.ReadAllLines(filename);

        if (_journalEntries == null)
        {
            List<Entry> entries = new List<Entry>();
            _journalEntries = entries;
        }

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string  lineT = line.Trim(); // remove leading and trailing spaces
            string[] parts = lineT.Split(",");
            if (parts.Length ==3) // Make sure the line has all three expected fields
            {
            entry._date = parts [0];
            entry._prompt = parts [1];
            entry._response = parts [2];
            entry._datePrompt = parts [0] + " " + parts [1];

            _journalEntries.Add(entry);
            }

        }
        
    }



    public void MenuOptions()


    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");

    

    }
}