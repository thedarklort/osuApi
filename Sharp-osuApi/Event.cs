using Newtonsoft.Json;
using System;

namespace Sharp_osuApi
{
    public class Event
    {
        [JsonProperty("display_html")]
        public string displayHtml { get; set; }

        [JsonProperty("beatmap_id")]
        public int beatmapId { get; set; }

        [JsonProperty("beatmapset_id")]
        public int beatmapsetId { get; set; }

        [JsonProperty("date")]
        public DateTime date { get; set; }

        [JsonProperty("epicfactor")]
        public int epicFactor { get; set; }
    }
}
