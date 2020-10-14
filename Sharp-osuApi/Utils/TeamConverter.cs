using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi.Utils
{
    public class TeamConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Team team = (Team)value;
            switch (team)
            {
                case Team.None:
                    writer.WriteValue("0");
                    break;
                case Team.Blue:
                    writer.WriteValue("1");
                    break;
                case Team.Red:
                    writer.WriteValue("2");
                    break;
                default:
                    writer.WriteNull();
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            Team? team = null;

            switch (enumString)
            {
                case "0":
                    team = Team.None;
                    break;
                case "1":
                    team = Team.Blue;
                    break;
                case "2":
                    team = Team.Red;
                    break;
                default:
                    break;
            }
            return team;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
