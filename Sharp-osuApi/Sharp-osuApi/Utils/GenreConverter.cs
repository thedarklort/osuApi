using Newtonsoft.Json;
using System;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi.Utils
{
    public class GenreConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Genre genre = (Genre)value;
            switch (genre)
            {
                case Genre.Any:
                    writer.WriteValue("0");
                    break;
                case Genre.Unspecified:
                    writer.WriteValue("1");
                    break;
                case Genre.VideoGame:
                    writer.WriteValue("2");
                    break;
                case Genre.Anime:
                    writer.WriteValue("3");
                    break;
                case Genre.Rock:
                    writer.WriteValue("4");
                    break;
                case Genre.Pop:
                    writer.WriteValue("5");
                    break;
                case Genre.Other:
                    writer.WriteValue("6");
                    break;
                case Genre.Novelty:
                    writer.WriteValue("7");
                    break;
                case Genre.HipHop:
                    writer.WriteValue("9");
                    break;
                case Genre.Electronic:
                    writer.WriteValue("10");
                    break;
                default:
                    writer.WriteNull();
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            Genre? genre = null;

            switch (enumString)
            {
                case "0":
                    genre = Genre.Any;
                    break;
                case "1":
                    genre = Genre.Unspecified;
                    break;
                case "2":
                    genre = Genre.VideoGame;
                    break;
                case "3":
                    genre = Genre.Anime;
                    break;
                case "4":
                    genre = Genre.Rock;
                    break;
                case "5":
                    genre = Genre.Pop;
                    break;
                case "6":
                    genre = Genre.Other;
                    break;
                case "7":
                    genre = Genre.Novelty;
                    break;
                case "9":
                    genre = Genre.HipHop;
                    break;
                case "10":
                    genre = Genre.Electronic;
                    break;
                default:
                    break;
            }
            return genre;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
