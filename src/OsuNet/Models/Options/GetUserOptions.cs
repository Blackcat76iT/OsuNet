using OsuNet.Enums;

namespace OsuNet.Models.Options {
    public class GetUserOptions {
        /// <summary>
        /// User is a required option.
        /// </summary>
        public string User { get; set; }
        public BeatmapMode? Mode { get; set; } = 0;
        public string Type { get; set; }
        public byte? EventDays { get; set; } = 1;
    }
}
