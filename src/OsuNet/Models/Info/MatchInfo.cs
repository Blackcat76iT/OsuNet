using Newtonsoft.Json;

namespace OsuNet.Models.Info {
    public class MatchInfo {
        [JsonProperty("match_id")]
        public ulong MatchId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        [JsonProperty("end_time")]
        public DateTime? EndTime { get; set; }
    }
}
