using Newtonsoft.Json;
using Sharp_osuApi.Utils;
using System;
using System.Collections.Generic;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi
{
    public class Game
    {
        [JsonProperty("game_id")]
        public long gameId { get; set; }

        [JsonProperty("start_time")]
        public DateTime start_time { get; set; }

        [JsonProperty("end_time")]
        public DateTime? end_time { get; set; }

        [JsonProperty("beatmap_id")]
        public int beatmap_id { get; set; }

        [JsonProperty("play_mode")]
        [JsonConverter(typeof(GameModeConverter))]
        public GameMode playMode { get; set; }

        [JsonProperty("match_type")]
        public int matchType { get; set; }

        [JsonProperty("scoring_type")]
        [JsonConverter(typeof(ScoringTypeConverter))]
        public ScoringType scoringType { get; set; }

        [JsonProperty("team_type")]
        [JsonConverter(typeof(TeamTypeConverter))]
        public TeamType teamType { get; set; }

        [JsonProperty("mods")]
        public int Mods { get; set; }

        [JsonProperty("scores")]
        public List<GameScore> Scores { get; set; }
    }
}
