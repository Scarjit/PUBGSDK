// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using PUBGSDK.JClass.Players.Single;
//
//    var jPlayer = JPlayer.FromJson(jsonString);

using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PUBGSDK.JClass.Players.Single
{
    public partial class JPlayer
    {
        [JsonProperty("data")] public Data Data { get; set; }

        [JsonProperty("links")] public JPlayerLinks Links { get; set; }

        [JsonProperty("meta")] public Meta Meta { get; set; }
    }

    public class Data
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("attributes")] public Attributes Attributes { get; set; }

        [JsonProperty("relationships")] public Relationships Relationships { get; set; }

        [JsonProperty("links")] public DataLinks Links { get; set; }
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

    public class DataLinks
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
        [JsonProperty("data")] public Datum[] Data { get; set; }
    }

    public class Datum
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }
    }

    public class JPlayerLinks
    {
        [JsonProperty("self")] public string Self { get; set; }
    }

    public class Meta
    {
    }

    public partial class JPlayer
    {
        public static JPlayer FromJson(string json)
        {
            return JsonConvert.DeserializeObject<JPlayer>(json, Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this JPlayer self)
        {
            return JsonConvert.SerializeObject(self, Converter.Settings);
        }
    }

    internal class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter {DateTimeStyles = DateTimeStyles.AssumeUniversal}
            }
        };
    }
}