using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models {
    public class Beatmap {
        [JsonProperty("beatmapset_id")]
        public ulong BeatmapSetId { get; set; }

        [JsonProperty("beatmap_id")]
        public ulong BeatmapId { get; set; }

        [JsonProperty("approved")]
        public ApproveStatus Approved { get; set; }

        [JsonProperty("total_length")]
        public ulong TotalLength { get; set; }

        [JsonProperty("hit_length")]
        public ulong HitLength { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("file_md5")]
        public string FileMD5 { get; set; }

        [JsonProperty("diff_size")]
        public double DiffSize { get; set; }

        [JsonProperty("diff_overall")]
        public double DiffOverall { get; set; }

        [JsonProperty("diff_approach")]
        public double DiffApproach { get; set; }

        [JsonProperty("diff_drain")]
        public double DiffDrain { get; set; }

        [JsonProperty("mode")]
        public BeatmapMode Mode { get; set; }

        [JsonProperty("count_normal")]
        public ulong CountNormal { get; set; }

        [JsonProperty("count_slider")]
        public ulong CountSlider { get; set; }

        [JsonProperty("count_spinner")]
        public ulong CountSpinner { get; set; }

        [JsonProperty("submit_date")]
        public DateTime? SubmitDate { get; set; }

        [JsonProperty("approved_date")]
        public DateTime? ApprovedDate { get; set; }

        [JsonProperty("last_update")]
        public DateTime? LastUpdate { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("artist_unicode")]
        public string ArtistUnicode { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_unicode")]
        public string TitleUnicode { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("creator_id")]
        public ulong CreatorId { get; set; }

        [JsonProperty("bpm")]
        public double? BPM { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("genre_id")]
        public Genre GenreId { get; set; }

        [JsonProperty("language_id")]
        public Language LanguageId { get; set; }

        [JsonProperty("favourite_count")]
        public ulong FavouriteCount { get; set; }

        [JsonProperty("rating")]
        public double Rating { get; set; }

        [JsonProperty("storyboard")]
        public bool Storyboard { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("download_unavailable")]
        public bool DownloadUnavailable { get; set; }

        [JsonProperty("audio_unavailable")]
        public bool AudioUnavailble { get; set; }

        [JsonProperty("playcount")]
        public ulong PlayCount { get; set; }

        [JsonProperty("passcount")]
        public ulong PassCount { get; set; }

        [JsonProperty("packs")]
        public string Packs { get; set; }

        [JsonProperty("max_combo")]
        public ulong? MaxCombo { get; set; }

        [JsonProperty("diff_aim")]
        public double? DiffAim { get; set; }

        [JsonProperty("diff_speed")]
        public double? DiffSpeed { get; set; }

        [JsonProperty("difficultyrating")]
        public double DiffecultyRating { get; set; }

        public string GetCover()
            => $"https://assets.ppy.sh/beatmaps/{BeatmapSetId}/covers/cover.jpg";

        public string GetThumbnail()
            => $"https://b.ppy.sh/thumb/{BeatmapSetId}l.jpg";
    }
}
