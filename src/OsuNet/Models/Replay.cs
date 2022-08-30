using Newtonsoft.Json;

namespace OsuNet.Models {
    public class Replay {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("encoding")]
        public string Encoding { get; set; }
    }
}
