// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using PUBGSDK.JClass.Players.Collection;
//
//    var jPlayers = JPlayers.FromJson(jsonString);

using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PUBGSDK.JClass.Players.Collection
{
    public partial class JPlayers
    {
        [JsonProperty("data")] public JPlayersDatum[] Data { get; set; }

        [JsonProperty("links")] public JPlayersLinks Links { get; set; }

        [JsonProperty("meta")] public Meta Meta { get; set; }
    }

    public class JPlayersDatum
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("attributes")] public Attributes Attributes { get; set; }

        [JsonProperty("relationships")] public Relationships Relationships { get; set; }

        [JsonProperty("links")] public DatumLinks Links { get; set; }
    }

    public class Attributes
    {
        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("name")] public string Name { get; set; }

        [JsonProperty("patchVersion")] public string PatchVersion { get; set; }

        [JsonProperty("shardId")] public string ShardId { get; set; }

        [JsonProperty("stats")] public object Stats { get; set; }

        [JsonProperty("titleId")] public string TitleId { get; set; }

        [JsonProperty("updatedAt")] public DateTimeOffset UpdatedAt { get; set; }
    }

    public class DatumLinks
    {
        [JsonProperty("schema")] public string Schema { get; set; }

        [JsonProperty("self")] public string Self { get; set; }
    }

    public class Relationships
    {
        [JsonProperty("assets")] public Assets Assets { get; set; }

        [JsonProperty("matches")] public Assets Matches { get; set; }
    }

    public class Assets
    {
        [JsonProperty("data")] public AssetsDatum[] Data { get; set; }
    }

    public class AssetsDatum
    {
        [JsonProperty("type")] public DatumType Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }
    }

    public class JPlayersLinks
    {
        [JsonProperty("self")] public string Self { get; set; }
    }

    public class Meta
    {
    }

    public enum DatumType
    {
        Match
    }

    public partial class JPlayers
    {
        public static JPlayers FromJson(string json)
        {
            return JsonConvert.DeserializeObject<JPlayers>(json, Converter.Settings);
        }
    }

    internal static class DatumTypeExtensions
    {
        public static DatumType? ValueForString(string str)
        {
            switch (str)
            {
                case "match": return DatumType.Match;
                default: return null;
            }
        }

        public static DatumType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this DatumType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case DatumType.Match:
                    serializer.Serialize(writer, "match");
                    break;
            }
        }
    }

    public static class Serialize
    {
        public static string ToJson(this JPlayers self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    internal class Converter : JsonConverter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new Converter(),
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            }
        };

        public override bool CanConvert(Type t)
        {
            return t == typeof(DatumType) || t == typeof(DatumType?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(DatumType))
                return DatumTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(DatumType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DatumTypeExtensions.ReadJson(reader, serializer);
            }

            throw new Exception("Unknown type");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var t = value.GetType();
            if (t == typeof(DatumType))
            {
                ((DatumType) value).WriteJson(writer, serializer);
                return;
            }

            throw new Exception("Unknown type");
        }
    }
}