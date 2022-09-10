using OsuNet.Enums;

namespace OsuNet.Models.Options {
    /// <summary>
    /// BeatmapId is a required option.
    /// NOT BeatmapSetId
    /// </summary>
    public class GetScoresOptions {
        public ulong? BeatmapId { get; set; }
        public string User { get; set; }
        public BeatmapMode? Mode { get; set; } = 0;
        public Mods? Mods { get; set; }
        public string Type { get; set; }
        public int? Limit { get; set; } = 50;
    }
}
