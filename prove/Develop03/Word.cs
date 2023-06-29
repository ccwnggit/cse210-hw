public class Word

{
    private string _word;

    public Word ()
    {
        _word = "";
    }

    public string Get()
    {
        return _word;    

    }

    public void Set(string value)
    {
        _word = value;
    
    }

    public string GetUnderline()
    {
        // replace the word with underline

        int i = _word.Count();
        string underline = ""; 
        for (int j=0;j < i; j++)
        {
            underline = underline + "_";
        }

        _word = underline;

        return _word;

    }
}