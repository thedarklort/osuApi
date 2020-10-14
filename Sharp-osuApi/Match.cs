using Newtonsoft.Json;
using System;

namespace Sharp_osuApi
{
    public class Match
    {
        [JsonProperty("match_id")]
        public long matchId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("start_time")]
        public DateTime start_time { get; set; }

        [JsonProperty("end_time")]
        public DateTime? endTime { get; set; }
    }
}
