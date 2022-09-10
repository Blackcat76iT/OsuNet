﻿using OsuNet.Enums;

namespace OsuNet.Models.Options {
    /// <summary>
    /// User is a required option.
    /// </summary>
    public class GetUserBestOptions {
        public string User { get; set; }
        public BeatmapMode? Mode { get; set; } = 0;
        public int? Limit { get; set; } = 10;
        public string Type { get; set; }
    }
}
