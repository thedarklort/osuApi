using Newtonsoft.Json;
using System;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi.Utils
{
    class LanguageConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            Language language = (Language)value;
            switch (language)
            {
                case Language.Any:
                    writer.WriteValue("0");
                    break;
                case Language.Other:
                    writer.WriteValue("1");
                    break;
                case Language.English:
                    writer.WriteValue("2");
                    break;
                case Language.Japanese:
                    writer.WriteValue("3");
                    break;
                case Language.Chinese:
                    writer.WriteValue("4");
                    break;
                case Language.Instrumental:
                    writer.WriteValue("5");
                    break;
                case Language.Korean:
                    writer.WriteValue("6");
                    break;
                case Language.French:
                    writer.WriteValue("7");
                    break;
                case Language.German:
                    writer.WriteValue("8");
                    break;
                case Language.Swedish:
                    writer.WriteValue("9");
                    break;
                case Language.Spanish:
                    writer.WriteValue("10");
                    break;
                case Language.Italian:
                    writer.WriteValue("11");
                    break;
                default:
                    writer.WriteNull();
                    break;
            }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var enumString = (string)reader.Value;
            Language? language = null;

            switch (enumString)
            {
                case "0":
                    language = Language.Any;
                    break;
                case "1":
                    language = Language.Other;
                    break;
                case "2":
                    language = Language.English;
                    break;
                case "3":
                    language = Language.Japanese;
                    break;
                case "4":
                    language = Language.Chinese;
                    break;
                case "5":
                    language = Language.Instrumental;
                    break;
                case "6":
                    language = Language.Korean;
                    break;
                case "7":
                    language = Language.French;
                    break;
                case "8":
                    language = Language.German;
                    break;
                case "9":
                    language = Language.Swedish;
                    break;
                case "10":
                    language = Language.Spanish;
                    break;
                case "11":
                    language = Language.Italian;
                    break;
                default:
                    break;
            }
            return language;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(string);
        }
    }
}
