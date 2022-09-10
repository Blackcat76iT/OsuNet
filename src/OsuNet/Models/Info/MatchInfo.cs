using Newtonsoft.Json;

namespace OsuNet.Models.Info {
    public class MatchInfo {
        [JsonProperty("match_id")]
        public ulong MatchId { get; set; }

        /// <summary>
        /// Lobby Name
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Date and time the lobby was created.
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Date and time the lobby was deleted.
        /// </summary>
        [JsonProperty("end_time")]
        public DateTime? EndTime { get; set; }
    }
}
