using Newtonsoft.Json;

namespace OsuNet.Models.Info {
    public class EventInfo {
        [JsonProperty("display_html")]
        public string DisplayHTML { get; set; }

        [JsonProperty("beatmap_id")]
        public ulong? BeatmapId { get; set; }

        [JsonProperty("beatmapset_id")]
        public ulong? BeatmapsSetId { get; set; }

        [JsonProperty("date")]
        public DateTime DateTime { get; set; }

        [JsonProperty("epicfactor")]
        public byte EpicFactor { get; set; }
    }
}
