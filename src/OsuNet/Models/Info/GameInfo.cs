using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models.Info {
    public class GameInfo {
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

        [JsonProperty("beatmap_id")]
        public ulong BeatmapId { get; set; }

        [JsonProperty("play_mode")]
        public BeatmapMode PlayMode { get; set; } = 0;

        [JsonProperty("match_type")]
        public string MatchType { get; set; } // couldn't find

        [JsonProperty("scoring_type")]
        public Scoring ScoringType { get; set; }

        [JsonProperty("team_type")]
        public TeamType TeamType { get; set; }

        [JsonProperty("mods")]
        public Mods Mods { get; set; }

        [JsonProperty("scores")]
        public ScoreInfo[] Scores { get; set; }
    }
}
