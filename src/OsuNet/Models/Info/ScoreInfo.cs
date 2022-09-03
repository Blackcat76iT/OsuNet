﻿using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models.Info {
    public class ScoreInfo {
        [JsonProperty("slot")]
        public byte Slot { get; set; }

        [JsonProperty("team")]
        public Team Team { get; set; }

        [JsonProperty("user_id")]
        public ulong UserId { get; set; }

        [JsonProperty("score")]
        public ulong Score { get; set; }

        [JsonProperty("maxcombo")]
        public ulong MaxCombo { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; } // not used

        [JsonProperty("count50")]
        public ulong Count50 { get; set; }

        [JsonProperty("count100")]
        public ulong Count100 { get; set; }

        [JsonProperty("count300")]
        public ulong Count300 { get; set; }

        [JsonProperty("countmiss")]
        public ulong CountMiss { get; set; }

        [JsonProperty("countgeki")]
        public ulong CountGeki { get; set; }

        [JsonProperty("countkatu")]
        public ulong CountKatu { get; set; }

        [JsonProperty("perfect")]
        public bool Perfect { get; set; }

        [JsonProperty("pass")]
        public bool Pass { get; set; }

        [JsonProperty("enabled_mods")]
        public Mods? EnabledMods { get; set; }
    }
}