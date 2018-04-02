// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using PUBGSDK.JClass.Status;
//
//    var jStatus = JStatus.FromJson(jsonString);

namespace PUBGSDK.JClass.Status
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class JStatus
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }
    }

    public partial class Attributes
    {
        [JsonProperty("releasedAt")]
        public System.DateTimeOffset ReleasedAt { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }

    public partial class JStatus
    {
        public static JStatus FromJson(string json) => JsonConvert.DeserializeObject<JStatus>(json, PUBGSDK.JClass.Status.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this JStatus self) => JsonConvert.SerializeObject(self, PUBGSDK.JClass.Status.Converter.Settings);
    }

    internal class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
