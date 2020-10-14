using Newtonsoft.Json;
using System;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi.Utils
{
    class ApprovedConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Approved approved = (Approved)value;
            switch (approved)
            {
                case Approved.Graveyard:
                    writer.WriteValue("-2");
                    break;
                case Approved.WIP:
                    writer.WriteValue("-1");
                    break;
                case Approved.Pending:
                    writer.WriteValue("0");
                    break;
                case Approved.Ranked:
                    writer.WriteValue("1");
                    break;
                case Approved.Approved:
                    writer.WriteValue("2");
                    break;
                case Approved.Qualified:
                    writer.WriteValue("3");
                    break;
                case Approved.Loved:
                    writer.WriteValue("4");
                    break;
                default:
                    writer.WriteNull();
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            Approved? approved = null;

            switch (enumString)
            {
                case "-2":
                    approved = Approved.Graveyard;
                    break;
                case "-1":
                    approved = Approved.WIP;
                    break;
                case "0":
                    approved = Approved.Pending;
                    break;
                case "1":
                    approved = Approved.Ranked;
                    break;
                case "2":
                    approved = Approved.Approved;
                    break;
                case "3":
                    approved = Approved.Qualified;
                    break;
                case "4":
                    approved = Approved.Loved;
                    break;
                default:
                    break;
            }
            return approved;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
