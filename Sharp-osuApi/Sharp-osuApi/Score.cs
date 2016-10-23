using Newtonsoft.Json;
using Sharp_osuApi.Utils;
using System;

namespace Sharp_osuApi
{
    public class Score
    {
        [JsonProperty("score")]
        public long totalScore { get; set; }

        [JsonProperty("username")]
        public string userName { get; set; }

        [JsonProperty("count300")]
        public int count300 { get; set; }

        [JsonProperty("count100")]
        public int count100 { get; set; }

        [JsonProperty("count50")]
        public int count50 { get; set; }

        [JsonProperty("countmiss")]
        public int countMiss { get; set; }

        [JsonProperty("maxcombo")]
        public int maxCombo { get; set; }

        [JsonProperty("countkatu")]
        public int countKatu { get; set; }

        [JsonProperty("countgeki")]
        public int countGeki { get; set; }

        [JsonProperty("perfect")]
        [JsonConverter(typeof(BoolConverter))]
        public bool Perfect { get; set; }

        [JsonProperty("enabled_mods")]
        public int enabledMods { get; set; }

        [JsonProperty("user_id")]
        public int userId { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("pp")]
        public double? pp { get; set; }
    }
}
