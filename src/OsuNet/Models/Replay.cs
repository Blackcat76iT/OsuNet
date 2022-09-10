using Newtonsoft.Json;

namespace OsuNet.Models {
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
