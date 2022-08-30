using Newtonsoft.Json;
using OsuNet.Models.Info;

namespace OsuNet.Models {
    public class User {
        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("join_date")]
        public DateTime JoinDate { get; set; }

        [JsonProperty("count300")]
        public ulong Count300 { get; set; }

        [JsonProperty("count100")]
        public ulong Count100 { get; set; }

        [JsonProperty("count50")]
        public ulong Count50 { get; set; }

        [JsonProperty("playcount")]
        public ulong PlayCount { get; set; }

        [JsonProperty("ranked_score")]
        public ulong RankedScore { get; set; }

        [JsonProperty("total_score")]
        public ulong TotalScore { get; set; }

        [JsonProperty("pp_rank")]
        public ulong PPRank { get; set; }

        [JsonProperty("level")]
        public double Level { get; set; }

        [JsonProperty("pp_raw")]
        public double PPRaw { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("count_rank_ss")]
        public ulong CountRankSS { get; set; }

        [JsonProperty("count_rank_ssh")]
        public ulong CountRankSSH { get; set; }

        [JsonProperty("count_rank_s")]
        public ulong CountRankS { get; set; }

        [JsonProperty("count_rank_sh")]
        public ulong CountRankSH { get; set; }

        [JsonProperty("count_rank_a")]
        public ulong CountRankA { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("total_seconds_played")]
        public ulong TotalSecondsPlayed { get; set; }

        [JsonProperty("pp_country_rank")]
        public ulong PPCountryRank { get; set; }

        [JsonProperty("events")]
        public EventInfo[] Events;
    }
}
