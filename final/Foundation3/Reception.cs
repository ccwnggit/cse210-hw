public class Reception :Event

{
    private string _emailForRSVP;

    public void SetEmail(string email)
    {
        _emailForRSVP = email;
    }




    public override void FullDetails()

    {
        Console.WriteLine("\nFull Message: ");
        ListStandardDetails();
        Console.WriteLine($"{_emailForRSVP}");

    }

}