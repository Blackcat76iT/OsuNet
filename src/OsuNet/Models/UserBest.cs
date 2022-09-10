using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models {
    public class UserBest {
        [JsonProperty("beatmap_id")]
        public ulong BeatmapId { get; set; }

        [JsonProperty("score_id")]
        public ulong ScoreId { get; set; }

        [JsonProperty("score")]
        public ulong Score { get; set; }

        /// <summary>
        /// The number of maximum combos that the player has hit.
        /// </summary>
        [JsonProperty("maxcombo")]
        public ulong MaxCombo { get; set; }

        [JsonProperty("count50")]
        public ulong Count50 { get; set; }

        [JsonProperty("count100")]
        public ulong Count100 { get; set; }

        [JsonProperty("count300")]
        public ulong Count300 { get; set; }

        [JsonProperty("countmiss")]
        public ulong CountMiss { get; set; }

        [JsonProperty("countkatu")]
        public ulong CountKatu { get; set; }

        [JsonProperty("countgeki")]
        public ulong CountGeki { get; set; }

        /// <summary>
        /// True if score is perfect, false otherwise.
        /// </summary>
        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("enabled_mods")]
        public Mods EnabledMods { get; set; }

        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        /// <summary>
        /// Date and time the record was set.
        /// </summary>
        [JsonProperty("date")]
        public DateTime DateTime { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("pp")]
        public double PP { get; set; }

        /// <summary>
        /// True if you can watch the replay, otherwise false.
        /// </summary>
        [JsonProperty("replay_available")]
        public bool ReplayAvailable { get; set; }
    }
}
