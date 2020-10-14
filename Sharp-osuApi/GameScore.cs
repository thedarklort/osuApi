using Newtonsoft.Json;
using Sharp_osuApi.Utils;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi
{
    public class GameScore
    {
        [JsonProperty("slot")]
        public int Slot { get; set; }

        [JsonProperty("team")]
        [JsonConverter(typeof(TeamConverter))]
        public Team Team { get; set; }

        [JsonProperty("user_id")]
        public long userID { get; set; }

        [JsonProperty("score")]
        public int Score { get; set; }

        [JsonProperty("maxcombo")]
        public int maxCombo { get; set; }

        [JsonProperty("rank")]
        public int Rank { get; set; }

        [JsonProperty("count50")]
        public int Count50 { get; set; }

        [JsonProperty("count100")]
        public int Count100 { get; set; }

        [JsonProperty("count300")]
        public int Count300 { get; set; }

        [JsonProperty("countmiss")]
        public int countMiss { get; set; }

        [JsonProperty("countgeki")]
        public int countGeki { get; set; }

        [JsonProperty("countkatu")]
        public int countKatu { get; set; }

        [JsonProperty("perfect")]
        [JsonConverter(typeof(BoolConverter))]
        public bool Perfect { get; set; }

        [JsonProperty("pass")]
        [JsonConverter(typeof(BoolConverter))]
        public bool Pass { get; set; }

        [JsonProperty("enabled_mods")]
        public int enabledMods { get; set; }
    }
}
