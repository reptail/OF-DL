namespace OF_DL.Entities.Logs;

public class ScrapeLog()
{
    public ScrapeLog(string name, DateTime startTime, double totalMinutes) : this()
    {
        Name = name;
        StartTime = startTime;
        TotalMinutes = totalMinutes;
    }

    public string Name { get; set; }
    public DateTime StartTime { get; set; }
    public double TotalMinutes { get; set; }
}
