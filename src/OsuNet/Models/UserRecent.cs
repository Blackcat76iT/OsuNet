using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models {
    /// <summary>
    /// Gets the user's ten most recent plays over the last 24 hours.
    /// </summary>
    public class UserRecent {
        /// <summary>
        /// Unique beatmap ID.
        /// </summary>
        [JsonProperty("beatmap_id")]
        public ulong BeatmapId { get; set; }

        /// <summary>
        /// Unique score ID.
        /// </summary>
        [JsonProperty("score_id")]
        public ulong? ScoreId { get; set; }

        /// <summary>
        /// The number of points scored by this player.
        /// </summary>
        [JsonProperty("score")]
        public ulong Score { get; set; }

        /// <summary>
        /// The number of maximum combos that the player has hit.
        /// </summary>
        [JsonProperty("maxcombo")]
        public ulong MaxCombo { get; set; }

        /// <summary>
        /// The number of 50 points that the player has hit.
        /// </summary>
        [JsonProperty("count50")]
        public ulong Count50 { get; set; }

        /// <summary>
        /// The number of 100 points that the player has hit.
        /// </summary>
        [JsonProperty("count100")]
        public ulong Count100 { get; set; }

        /// <summary>
        /// The number of 300 points that the player has hit.
        /// </summary>
        [JsonProperty("count300")]
        public ulong Count300 { get; set; }

        /// <summary>
        /// The number of misses the that player has hit.
        /// </summary>
        [JsonProperty("countmiss")]
        public ulong CountMiss { get; set; }

        /// <summary>
        /// The number of good combos that the player has hit.
        /// </summary>
        [JsonProperty("countkatu")]
        public ulong Countkatu { get; set; }

        /// <summary>
        /// The number of perfect combos that the player has hit.
        /// </summary>
        [JsonProperty("countgeki")]
        public ulong CountGeki { get; set; }

        /// <summary>
        /// True if score is perfect, false otherwise.
        /// </summary>
        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        /// <summary>
        /// Mods used by this player.
        /// </summary>
        [JsonProperty("enabled_mods")]
        public Mods EnabledMods { get; set; }

        /// <summary>
        /// Unique user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        /// <summary>
        /// Date and time the record was set.
        /// </summary>
        [JsonProperty("date")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// The rank this player has received.
        /// </summary>
        [JsonProperty("rank")]
        public string Rank { get; set; }
    }
}
