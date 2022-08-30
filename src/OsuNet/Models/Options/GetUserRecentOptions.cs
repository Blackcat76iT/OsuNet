using OsuNet.Enums;

namespace OsuNet.Models.Options {
    public class GetUserRecentOptions {
        public string User { get; set; }
        public BeatmapMode? Mode { get; set; } = 0;
        public long? Limit { get; set; } = 10;
        public string Type { get; set; }
    }
}
