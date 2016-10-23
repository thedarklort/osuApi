using Newtonsoft.Json;
using Sharp_osuApi.Utils;
using System;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi
{
    public class Beatmap
    {
        [JsonProperty("approved")]
        [JsonConverter(typeof(ApprovedConverter))]
        public Approved Approved { get; set; }

        [JsonProperty("approved_date")]
        public DateTime? approvedDate { get; set; }

        [JsonProperty("last_update")]
        public DateTime lastUpdate { get; set; }

        [JsonProperty("artist")]
        public string Artist { get; set; }

        [JsonProperty("beatmap_id")]
        public int beatmapId { get; set; }

        [JsonProperty("beatmapset_id")]
        public int beatmapSetId { get; set; }

        [JsonProperty("bpm")]
        public double BPM { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("difficultyrating")]
        public double difficultyRating { get; set; }

        [JsonProperty("diff_size")]
        public double diffSize { get; set; }

        [JsonProperty("diff_overall")]
        public double diffOverall { get; set; }

        [JsonProperty("diff_approach")]
        public double diffApproach { get; set; }

        [JsonProperty("diff_drain")]
        public double diffDrain { get; set; }

        [JsonProperty("hit_length")]
        public int hitLength { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("genre_id")]
        [JsonConverter(typeof(GenreConverter))]
        public Genre Genre { get; set; }

        [JsonProperty("language_id")]
        [JsonConverter(typeof(LanguageConverter))]
        public Language Language { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("total_length")]
        public int totalLength { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("file_md5")]
        public string MD5 { get; set; }

        [JsonProperty("mode")]
        [JsonConverter(typeof(GameModeConverter))]
        public GameMode Mode { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }

        [JsonProperty("favourite_count")]
        public int favouriteCount { get; set; }

        [JsonProperty("playcount")]
        public int playCount { get; set; }

        [JsonProperty("passcount")]
        public int passCount { get; set; }

        [JsonProperty("max_combo")]
        public int? maxCombo { get; set; }
    }
}
