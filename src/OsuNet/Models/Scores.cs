using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models {
    public class Scores {
        /// <summary>
        /// Unique score ID.
        /// </summary>
        [JsonProperty("score_id")]
        public ulong ScoreId { get; set; }

        /// <summary>
        /// The number of points scored by this player.
        /// </summary>
        [JsonProperty("score")]
        public ulong Score { get; set; }

        /// <summary>
        /// Nickname of this player.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// The number of 300 points that the player has hit.
        /// </summary>
        [JsonProperty("count300")]
        public ulong Count300 { get; set; }

        /// <summary>
        /// The number of 100 points that the player has hit.
        /// </summary>
        [JsonProperty("count100")]
        public ulong Count100 { get; set; }

        /// <summary>
        /// The number of 50 points that the player has hit.
        /// </summary>
        [JsonProperty("count50")]
        public ulong Count50 { get; set; }

        /// <summary>
        /// The number of misses the that player has hit.
        /// </summary>
        [JsonProperty("countmiss")]
        public ulong CountMiss { get; set; }

        /// <summary>
        /// The number of maximum combos.
        /// </summary>
        [JsonProperty("maxcombo")]
        public ulong MaxCombo { get; set; }

        /// <summary>
        /// The number of good combos that the player has hit.
        /// </summary>
        [JsonProperty("countkatu")]
        public ulong CountKatu { get; set; }

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
        public Mods? EnabledMods { get; set; }

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
        /// The rank the player has received.
        /// </summary>
        [JsonProperty("rank")]
        public string Rank { get; set; }

        /// <summary>
        /// The number of PP that the player has hit.
        /// </summary>
        [JsonProperty("pp")]
        public double PP { get; set; }

        /// <summary>
        /// True if you can watch the replay, otherwise false.
        /// </summary>
        [JsonProperty("replay_available")]
        public bool ReplayAvailable { get; set; }
    }
}
