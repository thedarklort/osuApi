using Newtonsoft.Json;
using System;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi.Utils
{
    public class GameModeConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            GameMode gameMode = (GameMode)value;
            switch (gameMode)
            {
                case GameMode.osu:
                    writer.WriteValue("0");
                    break;
                case GameMode.Taiko:
                    writer.WriteValue("1");
                    break;
                case GameMode.CtB:
                    writer.WriteValue("2");
                    break;
                case GameMode.Mania:
                    writer.WriteValue("3");
                    break;
                default:
                    writer.WriteValue("0");
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            GameMode? gameMode = null;

            switch (enumString)
            {
                case "0":
                    gameMode = GameMode.osu;
                    break;
                case "1":
                    gameMode = GameMode.Taiko;
                    break;
                case "2":
                    gameMode = GameMode.CtB;
                    break;
                case "3":
                    gameMode = GameMode.Mania;
                    break;
                default:
                    gameMode = GameMode.osu;
                    break;
            }
            return gameMode;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }

    }
}
