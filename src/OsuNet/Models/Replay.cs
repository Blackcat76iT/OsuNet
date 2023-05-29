using Newtonsoft.Json;

namespace OsuNet.Models {
    /// <summary>
    /// Get the replay data of a user's score on a map.
    /// You are only allowed to do 10 requests per minute.
    /// </summary>
    public class Replay {
        /// <summary>
        /// Gets information about the replay.
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// Gets encoding information.
        /// </summary>
        [JsonProperty("encoding")]
        public string Encoding { get; set; }
    }
}
