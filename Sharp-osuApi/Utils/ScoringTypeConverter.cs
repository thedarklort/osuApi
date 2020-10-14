using Newtonsoft.Json;
using System;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi.Utils
{
    class ScoringTypeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            ScoringType scoringtype = (ScoringType)value;
            switch (scoringtype)
            {
                case ScoringType.Score:
                    writer.WriteValue("0");
                    break;
                case ScoringType.Accuracy:
                    writer.WriteValue("1");
                    break;
                case ScoringType.Combo:
                    writer.WriteValue("2");
                    break;
                case ScoringType.Scorev2:
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
            ScoringType? scoringtype = null;

            switch (enumString)
            {
                case "0":
                    scoringtype = ScoringType.Score;
                    break;
                case "1":
                    scoringtype = ScoringType.Accuracy;
                    break;
                case "2":
                    scoringtype = ScoringType.Combo;
                    break;
                case "3":
                    scoringtype = ScoringType.Scorev2;
                    break;
                default:
                    break;
            }
            return scoringtype;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
