using Newtonsoft.Json;
using OsuNet.Models.Info;

namespace OsuNet.Models {
    public class User {
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        /// <summary>
        /// Date and time the account was created.
        /// </summary>
        [JsonProperty("join_date")]
        public DateTime JoinDate { get; set; }

        [JsonProperty("count300")]
        public ulong Count300 { get; set; }

        [JsonProperty("count100")]
        public ulong Count100 { get; set; }

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

        [JsonProperty("level")]
        public double Level { get; set; }

        [JsonProperty("pp_raw")]
        public double PPRaw { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

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
        public string GetAvatar()
            => $"http://s.ppy.sh/a/{UserId}";
    }
}
