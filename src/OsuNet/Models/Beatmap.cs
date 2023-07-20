using Newtonsoft.Json;
using OsuNet.Enums;

namespace OsuNet.Models {
    /// <summary>
    /// Retrieve general beatmap information.
    /// </summary>
    public class Beatmap {
        /// <summary>
        /// Unique beatmap SET ID. (Used to identify an album)
        /// </summary>
        [JsonProperty("beatmapset_id")]
        public ulong BeatmapSetId { get; set; }

        /// <summary>
        /// Unique beatmap ID. (Used to identify the beatmap)
        /// </summary>
        [JsonProperty("beatmap_id")]
        public ulong BeatmapId { get; set; }

        /// <summary>
        /// Map status.
        /// </summary>
        [JsonProperty("approved")]
        public ApproveStatus Approved { get; set; }

        /// <summary>
        /// The duration of the map in seconds.
        /// </summary>
        [JsonProperty("total_length")]
        public ulong TotalLength { get; set; }

        /// <summary>
        /// Seconds from first note to last note<br/>Not including breaks.
        /// </summary>
        [JsonProperty("hit_length")]
        public ulong HitLength { get; set; }

        /// <summary>
        /// Difficulty name.
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        /// <summary>
        /// MD5 hash of the beatmap.
        /// </summary>
        [JsonProperty("file_md5")]
        public string FileMD5 { get; set; }

        /// <summary>
        /// Circle size value. (CS)
        /// </summary>
        [JsonProperty("diff_size")]
        public float DiffSize { get; set; }

        /// <summary>
        /// Overall difficulty. (OD)
        /// </summary>
        [JsonProperty("diff_overall")]
        public float DiffOverall { get; set; }

        /// <summary>
        /// Approach Rate. (AR)
        /// </summary>
        [JsonProperty("diff_approach")]
        public float DiffApproach { get; set; }

        /// <summary>
        /// Health drain. (HP)
        /// </summary>
        [JsonProperty("diff_drain")]
        public float DiffDrain { get; set; }

        /// <summary>
        /// Game mode.
        /// </summary>
        [JsonProperty("mode")]
        public BeatmapMode Mode { get; set; }

        /// <summary>
        /// Count of notes on the map.
        /// </summary>
        [JsonProperty("count_normal")]
        public ulong CountNormal { get; set; }

        /// <summary>
        /// Count of sliders on the map.
        /// </summary>
        [JsonProperty("count_slider")]
        public ulong CountSlider { get; set; }

        /// <summary>
        /// Count of spinners on the map.
        /// </summary>
        [JsonProperty("count_spinner")]
        public ulong CountSpinner { get; set; }

        /// <summary>
        /// Date submitted.
        /// </summary>
        [JsonProperty("submit_date")]
        public DateTime? SubmitDate { get; set; }

        /// <summary>
        /// Date ranked.
        /// </summary>
        [JsonProperty("approved_date")]
        public DateTime? ApprovedDate { get; set; }

        /// <summary>
        /// Last update date, in UTC.<br/>May be after approved_date if map was unranked and reranked.
        /// </summary>
        [JsonProperty("last_update")]
        public DateTime? LastUpdate { get; set; }

        /// <summary>
        /// Song artist.
        /// </summary>
        [JsonProperty("artist")]
        public string Artist { get; set; }

        /// <summary>
        /// Same as artist.
        /// </summary>
        [JsonProperty("artist_unicode")]
        public string ArtistUnicode { get; set; }

        /// <summary>
        /// Song name.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// Same as title.
        /// </summary>
        [JsonProperty("title_unicode")]
        public string TitleUnicode { get; set; }

        /// <summary>
        /// Creator nickname.
        /// </summary>
        [JsonProperty("creator")]
        public string Creator { get; set; }

        /// <summary>
        /// Creator ID.
        /// </summary>
        [JsonProperty("creator_id")]
        public ulong CreatorId { get; set; }

        /// <summary>
        /// The BPM of this bitmap.
        /// </summary>
        [JsonProperty("bpm")]
        public float? BPM { get; set; }

        /// <summary>
        /// * Did not find application
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// Beatmap tags separated by spaces.
        /// </summary>
        [JsonProperty("tags")]
        public string Tags { get; set; }

        /// <summary>
        /// Song genre.
        /// </summary>
        [JsonProperty("genre_id")]
        public Genre GenreId { get; set; }

        /// <summary>
        /// Map language.
        /// </summary>
        [JsonProperty("language_id")]
        public Language LanguageId { get; set; }

        /// <summary>
        /// Number of times the beatmap was favourited. (Americans: notice the ou!).
        /// </summary>
        [JsonProperty("favourite_count")]
        public ulong FavouriteCount { get; set; }

        /// <summary>
        /// The number of stars of this beatmap.
        /// </summary>
        [JsonProperty("rating")]
        public float Rating { get; set; }

        /// <summary>
        /// If this beatmap has a storyboard.
        /// </summary>
        [JsonProperty("storyboard")]
        public bool Storyboard { get; set; }

        /// <summary>
        /// If this beatmap has a video.
        /// </summary>
        [JsonProperty("video")]
        public bool Video { get; set; }

        /// <summary>
        /// If the download for this beatmap is unavailable. (old map, etc.)
        /// </summary>
        [JsonProperty("download_unavailable")]
        public bool DownloadUnavailable { get; set; }

        /// <summary>
        /// If the audio for this beatmap is unavailable. (DMCA takedown, etc.)
        /// </summary>
        [JsonProperty("audio_unavailable")]
        public bool AudioUnavailble { get; set; }

        /// <summary>
        /// Number of times the beatmap was played.
        /// </summary>
        [JsonProperty("playcount")]
        public ulong PlayCount { get; set; }

        /// <summary>
        /// Number of times the beatmap was passed, completed. (the user didn't fail or retry)
        /// </summary>
        [JsonProperty("passcount")]
        public ulong PassCount { get; set; }

        /// <summary>
        /// Maybe it's a pack of hitsounds.
        /// </summary>
        [JsonProperty("packs")]
        public string Packs { get; set; }

        /// <summary>
        /// The maximum combo a user can reach playing this beatmap.
        /// </summary>
        [JsonProperty("max_combo")]
        public ulong? MaxCombo { get; set; }

        /// <summary>
        /// The size of the notes of this beatmap.
        /// </summary>
        [JsonProperty("diff_aim")]
        public float? DiffAim { get; set; }

        /// <summary>
        /// The speed of the notes of this beatmap.
        /// </summary>
        [JsonProperty("diff_speed")]
        public float? DiffSpeed { get; set; }

        /// <summary>
        /// The number of stars the map would have in-game and on the website.
        /// </summary>
        [JsonProperty("difficultyrating")]
        public float DiffecultyRating { get; set; }

        /// <summary>
        /// Gets the cover URL for this Beatmap.
        /// </summary>
        /// <returns>A string representing the beatmaps cover URL</returns>
        public string GetCover() => $"https://assets.ppy.sh/beatmaps/{BeatmapSetId}/covers/cover.jpg";

        /// <summary>
        /// Gets the thumbnail URL for this Beatmap.
        /// </summary>
        /// <returns>A string representing the beatmaps thumbnail URL</returns>
        public string GetThumbnail() => $"https://b.ppy.sh/thumb/{BeatmapSetId}l.jpg";

        /// <summary>
        /// Gets the URL of this beatmap creator.
        /// </summary>
        /// <returns>A string representing the URL of the map creator.</returns>
        public string GetCreatorUrl() => $"https://osu.ppy.sh/users/{CreatorId}";

        /// <summary>
        /// Gets the URL of this beatmap creator's avatar.
        /// </summary>
        /// <returns>A string representing the URL of the map creator's avatar.</returns>
        public string GetCreatorAvatar() => $"http://s.ppy.sh/a/{CreatorId}";

        /// <summary>
        /// Gets the URL of the beatmap.
        /// </summary>
        /// <returns>A string representing the URL of the beatmap.</returns>
        public string GetUrl() => $"https://osu.ppy.sh/beatmapsets/{BeatmapSetId}#{Mode.ToString().ToLower()}/{BeatmapId}";
    }
}
