using System;

class Program
{
    static void Main(string[] args)
    {
        
        Event event1 = new Event();
        event1.SetEvent("Lecture", "Macroecomic update - Q1 2023","US inflation falls sharply. How shall we interpret this?","4 April, 2023","2:30-4:00pm", "Pennisula Hotel, 2/F, Kingston Road, Germany");
        
        Lecture derEvent1 = new Lecture();
        derEvent1.SetSpeaker("Peter Arnold");
        derEvent1.SetCapacity(200);

        Event event2 = new Event();
        event2.SetEvent("Reception","Wedding:Carol and Jimmy Carter", "It is getting competitive","2 August, 2023", "2:00-4:00pm", "4 Cornwell Street, Kowloon Tong, Kowloon, Hong Kong");

        Reception derEvent2 = new Reception();
        derEvent2.SetEmail("Excited to see you. Please respond by 24 July for confirmation. RVSP");

        Event event3 = new Event();
        event3.SetEvent("Outdoor Gathering", "Peak Assembly", "Review the cultural heritage", "3 October, 2023", "10:00-12:00pm", "4 Peak Road, The Peak, Central, Hong Kong");

        OutdoorGathering derEvent3 = new OutdoorGathering ();
        derEvent3.SetWeatherForecastStatement("A spike in heat could produce some of the highest temperatures of the summer so far in the Northeast toward the end of next week, AccuWeather forecasters say.");

        /* call the event, call the method to generate the market messages and output to the screen */

        
        List <Event> elist = new List <Event> ();
        elist.Add(event1);
        elist.Add(event2);
        elist.Add(event3);
        
        foreach (Event vent in elist)
        {
            vent.ShortDescription();
            vent.ListStandardDetails();
            vent.FullDetails();
    
        }
        
    }
}