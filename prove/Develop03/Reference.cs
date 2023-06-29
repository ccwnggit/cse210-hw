public class Reference

{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public void SetBook(string book)
    {
        _book =  book;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetVerseStart(int verseStart)
    {
        _verseStart = verseStart;
    }

    public void SetVerseEnd(int verseEnd)
    {
        _verseEnd = verseEnd;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter ;
    }

    public int GetVerseStart()
    {
        return _verseStart;
    }

    public int GetVerseEnd()
    {
        return _verseEnd;
    }

    public void Display()
    {
        Console.Clear();
        if (_verseStart != _verseEnd)
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseStart}-{_verseEnd} ");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseStart} ");
        }
        
    }
}