using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Sharp_osuApi
{
    public class User
    {
        [JsonProperty("user_id")]
        public int userId { get; set; }

        [JsonProperty("username")]
        public string userName { get; set; }

        [JsonProperty("join_date")]
        public DateTime joinDate { get; set; }

        [JsonProperty("count300")]
        public int count300 { get; set; }

        [JsonProperty("count100")]
        public int count100 { get; set; }

        [JsonProperty("count50")]
        public int count50 { get; set; }

        [JsonProperty("playcount")]
        public int playCount { get; set; }

        [JsonProperty("ranked_score")]
        public long rankedScore { get; set; }

        [JsonProperty("total_score")]
        public long totalScore { get; set; }

        [JsonProperty("pp_rank")]
        public int ppRank { get; set; }

        [JsonProperty("level")]
        public double Level { get; set; }

        [JsonProperty("pp_raw")]
        public double ppRaw { get; set; }

        [JsonProperty("accuracy")]
        public double Accuracy { get; set; }

        [JsonProperty("count_rank_ss")]
        public int countRankSS { get; set; }

        [JsonProperty("count_rank_ssh")]
        public int countRankSSH { get; set; }

        [JsonProperty("count_rank_s")]
        public int countRankS { get; set; }

        [JsonProperty("count_rank_sh")]
        public int countRankSH { get; set; }

        [JsonProperty("count_rank_a")]
        public int countRankA { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("total_seconds_played")]
        public int totalSecondsPlayed { get; set; }

        [JsonProperty("pp_country_rank")]
        public int ppCountryRank { get; set; }

        [JsonProperty("events")]
        public List<Event> Events { get; set; }
    }
}
