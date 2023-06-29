public class Scripture

{
    private string [] _inputString;

    private int _wordsCount;
    public int _hiddenCount;

    private List <int> _wordPositions;               // stores the remaining positions of words in the scripture that are available to hide


    public Scripture ()
    {
        _inputString = null;
        _wordsCount = 0;
        _hiddenCount = 0;
        _wordPositions = null;
        
    }

    public List<string> GetScripture()
    {
        List <string> words = _inputString.ToList();
        return words;
    }

    public void Set(string value)           // Store the scripture in a string array, including punctuation
    {
        string [] decom = value.Split(" ");
        _inputString= decom;
    }

    public void SetWordBlank(int i)
    {
        Word w1 = new Word();
        w1.Set(_inputString[i]);
        _inputString[i] = w1.GetUnderline();
    }

    public void DisplayOrg()

    {
        Console.WriteLine($"\"{string.Join(" ",_inputString)}\"");  // print out the whole verse
    }

    public List<int> GetWordPosList (string parameter)

    // shorten the string of available word position by the number of commas and full-stops
    {
        List <int> _wordPositions = new List<int> ();

        if (parameter == "-p")                          // flag for removing punctuations: comma and fullstop
        {
            _wordsCount = _inputString.Count();               // count the gross number of words in the scripture, including punctuation marks.


            for (int i=0; i <_wordsCount; i++)          // set up a list equalling each word in the scripture
            {
                _wordPositions.Add(i);
                if (_inputString[i] == "," || _inputString[i] == ".")
                {
                    _wordPositions.Remove(i);
                }
        
            }
        } 
        Console.WriteLine(_wordPositions);
        return _wordPositions;                         // list of word positions in the scripture where words are located, excluding commas and full-stops.
    }

    public List<int> GetWordPos()
    {
        return _wordPositions;
    }


    public void Display()

    {
        Console.WriteLine($"\"{string.Join(" ",_inputString)}\"");  // print out the whole verse
    }


    public void Display(List<int> hideList)
    // display the scripture verse after obtain the words to be hidden each time
    {
    

        foreach (int i in hideList)                              // for each of the word positions stored in the list
        {
            // turn the word at that position to the number of blanks equalling to the number of letters in the word, and count the number of words finally converted
        
            Word w1 = new Word();                   // set up an instance of Word class
        
                    w1.Set(_inputString [i]);             // set the word instance to the word in question
                    _inputString[i] = w1.GetUnderline();  // convert the word to all blanks, using the method in Word class
                    _hiddenCount+=1;                // counting it once for each word converted to all blanks, excluding punctuation.

        }

        foreach (int i in hideList)
        {
            _wordPositions.Remove(i);                    // Remove the number from the list of remaining words to hide 
        }
        
        Console.WriteLine($"\"{string.Join(" ",_inputString)}\"");  // print out the whole verse

    }

    
    public int GetLength()

    {
        return _inputString.Count();

    }
    


}