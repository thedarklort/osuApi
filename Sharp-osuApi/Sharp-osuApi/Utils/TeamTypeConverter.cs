using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi.Utils
{
    class TeamTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            TeamType teamtype = (TeamType)value;
            switch (teamtype)
            {
                case TeamType.HeadToHead:
                    writer.WriteValue("0");
                    break;
                case TeamType.TagCoop:
                    writer.WriteValue("1");
                    break;
                case TeamType.TeamVS:
                    writer.WriteValue("2");
                    break;
                case TeamType.TagTeamVS:
                    writer.WriteValue("3");
                    break;
                default:
                    writer.WriteNull();
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            TeamType? teamtype = null;

            switch (enumString)
            {
                case "0":
                    teamtype = TeamType.HeadToHead;
                    break;
                case "1":
                    teamtype = TeamType.TagCoop;
                    break;
                case "2":
                    teamtype = TeamType.TeamVS;
                    break;
                case "3":
                    teamtype = TeamType.TagTeamVS;
                    break;
                default:
                    break;
            }
            return teamtype;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
