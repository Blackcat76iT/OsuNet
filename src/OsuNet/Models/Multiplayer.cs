﻿using Newtonsoft.Json;
using OsuNet.Models.Info;

namespace OsuNet.Models {
    /// <summary>
    /// Retrieve information about a multiplayer match.
    /// </summary>
    public class Multiplayer {
        /// <summary>
        /// Gets basic information about the match.
        /// </summary>
        [JsonProperty("match")]
        public MatchInfo Match { get; set; }

        /// <summary>
        /// Gets basic information about games.
        /// </summary>
        [JsonProperty("games")]
        public GameInfo[] Games { get; set; }
    }
}
