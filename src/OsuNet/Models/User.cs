using Newtonsoft.Json;
using OsuNet.Models.Info;

namespace OsuNet.Models {
    /// <summary>
    /// Retrieve general user information.
    /// </summary>
    public class User {
        /// <summary>
        /// Unique user ID.
        /// </summary>
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        /// <summary>
        /// Nickname of this player.
        /// </summary>
        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Date and time the account was created.
        /// </summary>
        [JsonProperty("join_date")]
        public DateTime JoinDate { get; set; }

        /// <summary>
        /// The number of 300 points that the player has accumulated over the entire time.
        /// </summary>
        [JsonProperty("count300")]
        public ulong Count300 { get; set; }

        /// <summary>
        /// The number of 100 points that the player has accumulated over the entire time.
        /// </summary>
        [JsonProperty("count100")]
        public ulong Count100 { get; set; }

        /// <summary>
        /// The number of 50 points that the player has accumulated over the entire time.
        /// </summary>
        [JsonProperty("count50")]
        public ulong Count50 { get; set; }

        /// <summary>
        /// Only counts ranked, approved, and loved beatmap.
        /// </summary>
        [JsonProperty("playcount")]
        public ulong PlayCount { get; set; }

        /// <summary>
        /// Counts the best individual score on each ranked, approved, and loved beatmaps.
        /// </summary>
        [JsonProperty("ranked_score")]
        public ulong RankedScore { get; set; }

        /// <summary>
        /// Counts every score on ranked, approved, and loved beatmaps.
        /// </summary>
        [JsonProperty("total_score")]
        public ulong TotalScore { get; set; }

        /// <summary>
        /// Place in the world top.
        /// </summary>
        [JsonProperty("pp_rank")]
        public ulong PPRank { get; set; }

        /// <summary>
        /// This player's level.
        /// </summary>
        [JsonProperty("level")]
        public float Level { get; set; }

        /// <summary>
        /// The number of PP that the player has accumulated over the entire time.
        /// </summary>
        [JsonProperty("pp_raw")]
        public float PPRaw { get; set; }

        /// <summary>
        /// The accuracy of this player.
        /// </summary>
        [JsonProperty("accuracy")]
        public float Accuracy { get; set; }

        /// <summary>
        /// Count for SS ranks on maps.
        /// </summary>
        [JsonProperty("count_rank_ss")]
        public ulong CountRankSS { get; set; }

        /// <summary>
        /// Count for SSH ranks on maps.
        /// </summary>
        [JsonProperty("count_rank_ssh")]
        public ulong CountRankSSH { get; set; }

        /// <summary>
        /// Count for S ranks on maps.
        /// </summary>
        [JsonProperty("count_rank_s")]
        public ulong CountRankS { get; set; }

        /// <summary>
        /// Count for SH ranks on maps.
        /// </summary>
        [JsonProperty("count_rank_sh")]
        public ulong CountRankSH { get; set; }

        /// <summary>
        /// Count A ranks on maps.
        /// </summary>
        [JsonProperty("count_rank_a")]
        public ulong CountRankA { get; set; }

        /// <summary>
        /// Place in the top of the country.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The number of seconds played.
        /// </summary>
        [JsonProperty("total_seconds_played")]
        public ulong TotalSecondsPlayed { get; set; }

        /// <summary>
        /// The user's rank in the country.
        /// </summary>
        [JsonProperty("pp_country_rank")]
        public ulong PPCountryRank { get; set; }

        /// <summary>
        /// Contains events for this user.
        /// </summary>
        [JsonProperty("events")]
        public EventInfo[] Events;

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
