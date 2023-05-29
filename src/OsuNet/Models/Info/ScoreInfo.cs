using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models.Info {
    /// <summary>
    /// Get general information about a user in a match.
    /// </summary>
    public class ScoreInfo {
        /// <summary>
        /// Player slot number.
        /// </summary>
        [JsonProperty("slot")]
        public byte Slot { get; set; }

        /// <summary>
        /// The team this player is on.
        /// </summary>
        [JsonProperty("team")]
        public Team Team { get; set; }

        /// <summary>
        /// Unique user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

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
        /// The rank the player has received. (Here not used)
        /// </summary>
        [JsonProperty("rank")]
        public string Rank { get; set; } // not used

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
        /// The number of perfect combos that the player has hit.
        /// </summary>
        [JsonProperty("countgeki")]
        public ulong CountGeki { get; set; }

        /// <summary>
        /// The number of good combos that the player has hit.
        /// </summary>
        [JsonProperty("countkatu")]
        public ulong CountKatu { get; set; }

        /// <summary>
        /// True if score is perfect, false otherwise.
        /// </summary>
        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        /// <summary>
        /// True if the player hasn't lost all their lives, otherwise false.
        /// </summary>
        [JsonProperty("pass")]
        public bool Pass { get; set; }

        /// <summary>
        /// Mods used by this player.
        /// </summary>
        [JsonProperty("enabled_mods")]
        public Mods? EnabledMods { get; set; }

        /// <summary>
        /// Gets the avatar URL for this user.
        /// </summary>
        /// <returns>A string representing the user's avatar URL.</returns>
        public string GetAvatar() => $"http://s.ppy.sh/a/{UserId}";

        /// <summary>
        /// Gets the URL of the user.
        /// </summary>
        /// <returns>A string representing the user's URL.</returns>
        public string GetUrl() => $"https://osu.ppy.sh/users/{UserId}";
    }
}
