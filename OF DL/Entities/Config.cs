using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OF_DL.Enumerations;

namespace OF_DL.Entities
{

    public class Config : IDownloadConfig, IFileNameFormatConfig
    {
        [ToggleableConfig]
        public bool DownloadAvatarHeaderPhoto { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadPaidPosts { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadPosts { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadArchived { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadStreams { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadStories { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadHighlights { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadMessages { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadPaidMessages { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadImages { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadVideos { get; set; } = true;
        [ToggleableConfig]
        public bool DownloadAudios { get; set; } = true;
        [ToggleableConfig]
        public bool IncludeExpiredSubscriptions { get; set; } = false;
        [ToggleableConfig]
        public bool IncludeRestrictedSubscriptions { get; set; } = false;
        [ToggleableConfig]
        public bool SkipAds { get; set; } = false;

        public string? DownloadPath { get; set; } = string.Empty;
        public string? PaidPostFileNameFormat { get; set; } = string.Empty;
        public string? PostFileNameFormat { get; set; } = string.Empty;
        public string? PaidMessageFileNameFormat { get; set; } = string.Empty;
        public string? MessageFileNameFormat { get; set; } = string.Empty;
        [ToggleableConfig]
        public bool RenameExistingFilesWhenCustomFormatIsSelected { get; set; } = false;
        public int? Timeout { get; set; } = -1;
        [ToggleableConfig]
        public bool FolderPerPaidPost { get; set; } = false;
        [ToggleableConfig]
        public bool FolderPerPost { get; set; } = false;
        [ToggleableConfig]
        public bool FolderPerPaidMessage { get; set; } = false;
        [ToggleableConfig]
        public bool FolderPerMessage { get; set; } = false;
        [ToggleableConfig]
        public bool LimitDownloadRate { get; set; } = false;
        public int DownloadLimitInMbPerSec { get; set; } = 4;

        // Indicates if you want to download only on specific dates.
        [ToggleableConfig]
        public bool DownloadOnlySpecificDates { get; set; } = false;

        // This enum will define if we want data from before or after the CustomDate.
        [JsonConverter(typeof(StringEnumConverter))]
        public DownloadDateSelection DownloadDateSelection { get; set; } = DownloadDateSelection.before;
        // This is the specific date used in combination with the above enum.

        [JsonConverter(typeof(ShortDateConverter))]
        public DateTime? CustomDate { get; set; } = null;

        [ToggleableConfig]
        public bool ShowScrapeSize { get; set; } = false;

        [ToggleableConfig]
        public bool DownloadPostsIncrementally { get; set; } = false;

        public bool NonInteractiveMode { get; set; } = false;
        public string NonInteractiveModeListName { get; set; } = string.Empty;
        [ToggleableConfig]
        public bool NonInteractiveModePurchasedTab { get; set; } = false;
        public string? FFmpegPath { get; set; } = string.Empty;

        [ToggleableConfig]
        public bool BypassContentForCreatorsWhoNoLongerExist { get; set; } = false;

        public Dictionary<string, CreatorConfig> CreatorConfigs { get; set; } = new Dictionary<string, CreatorConfig>();

        [ToggleableConfig]
        public bool DownloadDuplicatedMedia { get; set; } = false;

        public string IgnoredUsersListName { get; set; } = string.Empty;

        [JsonConverter(typeof(StringEnumConverter))]
        public LoggingLevel LoggingLevel { get; set; } = LoggingLevel.Error;

        [ToggleableConfig]
        public bool IgnoreOwnMessages { get; set; } = false;

        public string[] NonInteractiveSpecificUsers { get; set; } = [];
        public string[] NonInteractiveSpecificLists { get; set; } = [];

        public bool OutputBlockedUsers { get; set; }
    }

    public class CreatorConfig : IFileNameFormatConfig
    {
        public string? PaidPostFileNameFormat { get; set; }
        public string? PostFileNameFormat { get; set; }
        public string? PaidMessageFileNameFormat { get; set; }
        public string? MessageFileNameFormat { get; set; }
    }

}
