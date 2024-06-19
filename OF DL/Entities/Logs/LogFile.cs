namespace OF_DL.Entities.Logs;

public class LogFile()
{
    public LogFile(UserLog[] userLogs, ScrapeLog[] scrapeLogs) : this()
    {
        UserLogs = userLogs ?? [];
        ScrapeLogs = scrapeLogs ?? [];
    }

    public UserLog[] UserLogs { get; set; } = [];
    public ScrapeLog[] ScrapeLogs { get; set; } = [];
}
