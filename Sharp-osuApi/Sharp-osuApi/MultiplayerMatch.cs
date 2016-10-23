using Newtonsoft.Json;
using System.Collections.Generic;

namespace Sharp_osuApi
{
    public class MultiplayerMatch
    {
        [JsonProperty("match")]
        public Match Match { get; set; }

        [JsonProperty("games")]
        public List<Game> Games { get; set; }
    }
}
