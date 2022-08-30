using OsuNet.Enums;

namespace OsuNet.Models.Options {
    public class GetScoresOptions {
        public ulong? BeatmapId { get; set; }
        public string User { get; set; }
        public BeatmapMode? Mode { get; set; } = 0;
        public Mods? Mods { get; set; }
        public string Type { get; set; }
        public int? Limit { get; set; } = 50;
    }
}
