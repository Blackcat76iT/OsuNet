using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models.Info {
    /// <summary>
    /// Get general information about the game.
    /// </summary>
    public class GameInfo {
        /// <summary>
        /// Unique game ID.
        /// </summary>
        [JsonProperty("game_id")]
        public ulong GameId { get; set; }

        /// <summary>
        /// Date and time the game started.
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Date and time the game ended.
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Unique beatmap ID.
        /// </summary>
        [JsonProperty("beatmap_id")]
        public ulong BeatmapId { get; set; }

        /// <summary>
        /// Game Mode. (Default Osu)
        /// </summary>
        [JsonProperty("play_mode")]
        public BeatmapMode PlayMode { get; set; } = 0;

        /// <summary>
        /// Couldn't find.
        /// </summary>
        [JsonProperty("match_type")]
        public string MatchType { get; set; }

        /// <summary>
        /// The type of evaluation in this game.
        /// </summary>
        [JsonProperty("scoring_type")]
        public Scoring ScoringType { get; set; }

        /// <summary>
        /// Team type.
        /// </summary>
        [JsonProperty("team_type")]
        public TeamType TeamType { get; set; }

        /// <summary>
        /// Mods used on this game.
        /// </summary>
        [JsonProperty("mods")]
        public Mods Mods { get; set; }

        /// <summary>
        /// Information about the players.
        /// </summary>
        [JsonProperty("scores")]
        public ScoreInfo[] Scores { get; set; }
    }
}
