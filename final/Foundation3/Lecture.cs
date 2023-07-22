public class Lecture: Event

{
    private string _speaker;
    private int _capacity;


    public override void FullDetails()
    {
        Console.WriteLine ("\nFull Message: ");
        ListStandardDetails();
        Console.WriteLine($"Speaker: {_speaker}. Capacity: {_capacity}");
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }



}