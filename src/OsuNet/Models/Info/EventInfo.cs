using Newtonsoft.Json;

namespace OsuNet.Models.Info {
    public class EventInfo {
        /// <summary>
        /// Event HTML code.
        /// </summary>
        [JsonProperty("display_html")]
        public string DisplayHTML { get; set; }

        /// <summary>
        /// Unique beatmap SET ID.
        /// </summary>
        [JsonProperty("beatmap_id")]
        public ulong? BeatmapId { get; set; }

        /// <summary>
        /// Unique beatmap ID.
        /// </summary>
        [JsonProperty("beatmapset_id")]
        public ulong? BeatmapsSetId { get; set; }

        /// <summary>
        /// Date and time the event was received.
        /// </summary>
        [JsonProperty("date")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// How "epic" this event is (between 1 and 32).
        /// </summary>
        [JsonProperty("epicfactor")]
        public byte EpicFactor { get; set; }
    }
}
