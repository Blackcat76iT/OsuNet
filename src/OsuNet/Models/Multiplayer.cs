using Newtonsoft.Json;
using OsuNet.Models.Info;

namespace OsuNet.Models {
    public class Multiplayer {
        [JsonProperty("match")]
        public MatchInfo Match { get; set; }

        [JsonProperty("games")]
        public GameInfo[] Games { get; set; }
    }
}
