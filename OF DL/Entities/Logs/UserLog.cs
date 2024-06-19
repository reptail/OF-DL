namespace OF_DL.Entities.Logs;

public class UserLog()
{
    public UserLog(string username) : this()
    {
        Username = username;
    }

    public string Username { get; set; }

    public int PostCount { get; set; }
    public int ArchivedCount { get; set; }
    public int StreamsCount { get; set; }
    public int StoriesCount { get; set; }
    public int HighlightsCount { get; set; }
    public int MessagesCount { get; set; }

    public int PaidPostCount { get; set; }
    public int PaidMessagesCount { get; set; }
}
