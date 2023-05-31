using OsuNet.Enums;

namespace OsuNet.Models.Options {
    public class GetBeatmapOptions {
        public DateTime? Since { get; set; }
        public ulong? BeatmapSetId { get; set; }
        public ulong? BeatmapId { get; set; }

        /// <summary>
        /// Beatmap creator.
        /// </summary>
        public string User { get; set; }
        public string Type { get; set; }
        public BeatmapMode? Mode { get; set; }
        public bool? ConvertedBeatmaps { get; set; }
        public string Hash { get; set; }
        public int? Limit { get; set; }
        public Mods? Mods { get; set; }
    }
}