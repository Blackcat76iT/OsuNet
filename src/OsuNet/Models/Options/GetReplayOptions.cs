using OsuNet.Enums;

namespace OsuNet.Models.Options {
    public class GetReplayOptions {
        public ulong BeatmapId { get; set; }
        public string User { get; set; }
        public BeatmapMode? Mode { get; set; }
        public string ScoreId { get; set; }
        public string Type { get; set; }
        public Mods? Mods { get; set; }
    }
}
