public class OutdoorGathering: Event


{
    private string _weatherForecastStatement;


    public void SetWeatherForecastStatement (string forecast)

    {
        _weatherForecastStatement = forecast;
    }

    public override void FullDetails()
    {
        Console.WriteLine("\nFull Message: ");
        ListStandardDetails();
        Console.WriteLine($"Weather forecast: {_weatherForecastStatement}");
    }

}