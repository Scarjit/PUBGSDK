// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using PUBGSDK.JClass.Matches;
//
//    var jMatch = JMatch.FromJson(jsonString);

using System;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace PUBGSDK.JClass.Matches
{
    public partial class JMatch
    {
        [JsonProperty("data")] public Data Data { get; set; }

        [JsonProperty("included")] public Included[] Included { get; set; }

        [JsonProperty("links")] public JMatchLinks Links { get; set; }

        [JsonProperty("meta")] public Meta Meta { get; set; }
    }

    public class Data
    {
        [JsonProperty("type")] public string Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("attributes")] public DataAttributes Attributes { get; set; }

        [JsonProperty("relationships")] public DataRelationships Relationships { get; set; }

        [JsonProperty("links")] public DataLinks Links { get; set; }
    }

    public class DataAttributes
    {
        [JsonProperty("createdAt")] public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("duration")] public long Duration { get; set; }

        [JsonProperty("gameMode")] public string GameMode { get; set; }

        [JsonProperty("patchVersion")] public string PatchVersion { get; set; }

        [JsonProperty("shardId")] public string ShardId { get; set; }

        [JsonProperty("stats")] public object Stats { get; set; }

        [JsonProperty("tags")] public object Tags { get; set; }

        [JsonProperty("titleId")] public string TitleId { get; set; }
    }

    public class DataLinks
    {
        [JsonProperty("schema")] public string Schema { get; set; }

        [JsonProperty("self")] public string Self { get; set; }
    }

    public class DataRelationships
    {
        [JsonProperty("assets")] public Assets Assets { get; set; }

        [JsonProperty("rosters")] public Assets Rosters { get; set; }

        [JsonProperty("rounds")] public Assets Rounds { get; set; }

        [JsonProperty("spectators")] public Assets Spectators { get; set; }
    }

    public class Assets
    {
        [JsonProperty("data")] public Datum[] Data { get; set; }
    }

    public class Datum
    {
        [JsonProperty("type")] public DatumType Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }
    }

    public class Included
    {
        [JsonProperty("type")] public DatumType Type { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("attributes")] public IncludedAttributes Attributes { get; set; }

        [JsonProperty("relationships", NullValueHandling = NullValueHandling.Ignore)]
        public IncludedRelationships Relationships { get; set; }
    }

    public class IncludedAttributes
    {
        [JsonProperty("actor", NullValueHandling = NullValueHandling.Ignore)]
        public Actor? Actor { get; set; }

        [JsonProperty("shardId", NullValueHandling = NullValueHandling.Ignore)]
        public ShardId? ShardId { get; set; }

        [JsonProperty("stats", NullValueHandling = NullValueHandling.Ignore)]
        public Stats Stats { get; set; }

        [JsonProperty("won", NullValueHandling = NullValueHandling.Ignore)]
        public Won? Won { get; set; }

        [JsonProperty("URL", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }

        [JsonProperty("createdAt", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }
    }

    public class Stats
    {
        [JsonProperty("DBNOs", NullValueHandling = NullValueHandling.Ignore)]
        public long? DbnOs { get; set; }

        [JsonProperty("assists", NullValueHandling = NullValueHandling.Ignore)]
        public long? Assists { get; set; }

        [JsonProperty("boosts", NullValueHandling = NullValueHandling.Ignore)]
        public long? Boosts { get; set; }

        [JsonProperty("damageDealt", NullValueHandling = NullValueHandling.Ignore)]
        public double? DamageDealt { get; set; }

        [JsonProperty("deathType", NullValueHandling = NullValueHandling.Ignore)]
        public DeathType? DeathType { get; set; }

        [JsonProperty("headshotKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? HeadshotKills { get; set; }

        [JsonProperty("heals", NullValueHandling = NullValueHandling.Ignore)]
        public long? Heals { get; set; }

        [JsonProperty("killPlace", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillPlace { get; set; }

        [JsonProperty("killPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillPoints { get; set; }

        [JsonProperty("killPointsDelta", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillPointsDelta { get; set; }

        [JsonProperty("killStreaks", NullValueHandling = NullValueHandling.Ignore)]
        public long? KillStreaks { get; set; }

        [JsonProperty("kills", NullValueHandling = NullValueHandling.Ignore)]
        public long? Kills { get; set; }

        [JsonProperty("lastKillPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastKillPoints { get; set; }

        [JsonProperty("lastWinPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? LastWinPoints { get; set; }

        [JsonProperty("longestKill", NullValueHandling = NullValueHandling.Ignore)]
        public long? LongestKill { get; set; }

        [JsonProperty("mostDamage", NullValueHandling = NullValueHandling.Ignore)]
        public long? MostDamage { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("playerId", NullValueHandling = NullValueHandling.Ignore)]
        public string PlayerId { get; set; }

        [JsonProperty("revives", NullValueHandling = NullValueHandling.Ignore)]
        public long? Revives { get; set; }

        [JsonProperty("rideDistance", NullValueHandling = NullValueHandling.Ignore)]
        public double? RideDistance { get; set; }

        [JsonProperty("roadKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? RoadKills { get; set; }

        [JsonProperty("teamKills", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamKills { get; set; }

        [JsonProperty("timeSurvived", NullValueHandling = NullValueHandling.Ignore)]
        public long? TimeSurvived { get; set; }

        [JsonProperty("vehicleDestroys", NullValueHandling = NullValueHandling.Ignore)]
        public long? VehicleDestroys { get; set; }

        [JsonProperty("walkDistance", NullValueHandling = NullValueHandling.Ignore)]
        public double? WalkDistance { get; set; }

        [JsonProperty("weaponsAcquired", NullValueHandling = NullValueHandling.Ignore)]
        public long? WeaponsAcquired { get; set; }

        [JsonProperty("winPlace", NullValueHandling = NullValueHandling.Ignore)]
        public long? WinPlace { get; set; }

        [JsonProperty("winPoints", NullValueHandling = NullValueHandling.Ignore)]
        public long? WinPoints { get; set; }

        [JsonProperty("winPointsDelta", NullValueHandling = NullValueHandling.Ignore)]
        public long? WinPointsDelta { get; set; }

        [JsonProperty("rank", NullValueHandling = NullValueHandling.Ignore)]
        public long? Rank { get; set; }

        [JsonProperty("teamId", NullValueHandling = NullValueHandling.Ignore)]
        public long? TeamId { get; set; }
    }

    public class IncludedRelationships
    {
        [JsonProperty("participants")] public Assets Participants { get; set; }

        [JsonProperty("team")] public Assets Team { get; set; }
    }

    public class JMatchLinks
    {
        [JsonProperty("self")] public string Self { get; set; }
    }

    public class Meta
    {
    }

    public enum DatumType
    {
        Asset,
        Participant,
        Roster
    }

    public enum Actor
    {
        Empty
    }

    public enum ShardId
    {
        PcEu
    }

    public enum DeathType
    {
        Alive,
        Byplayer,
        Suicide
    }

    public enum Won
    {
        False,
        True
    }

    public partial class JMatch
    {
        public static JMatch FromJson(string json)
        {
            return JsonConvert.DeserializeObject<JMatch>(json, Converter.Settings);
        }
    }

    internal static class DatumTypeExtensions
    {
        public static DatumType? ValueForString(string str)
        {
            switch (str)
            {
                case "asset": return DatumType.Asset;
                case "participant": return DatumType.Participant;
                case "roster": return DatumType.Roster;
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
                case DatumType.Asset:
                    serializer.Serialize(writer, "asset");
                    break;
                case DatumType.Participant:
                    serializer.Serialize(writer, "participant");
                    break;
                case DatumType.Roster:
                    serializer.Serialize(writer, "roster");
                    break;
            }
        }
    }

    internal static class ActorExtensions
    {
        public static Actor? ValueForString(string str)
        {
            switch (str)
            {
                case "": return Actor.Empty;
                default: return null;
            }
        }

        public static Actor ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Actor value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Actor.Empty:
                    serializer.Serialize(writer, "");
                    break;
            }
        }
    }

    internal static class ShardIdExtensions
    {
        public static ShardId? ValueForString(string str)
        {
            switch (str)
            {
                case "pc-eu": return ShardId.PcEu;
                default: return null;
            }
        }

        public static ShardId ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this ShardId value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case ShardId.PcEu:
                    serializer.Serialize(writer, "pc-eu");
                    break;
            }
        }
    }

    internal static class DeathTypeExtensions
    {
        public static DeathType? ValueForString(string str)
        {
            switch (str)
            {
                case "alive": return DeathType.Alive;
                case "byplayer": return DeathType.Byplayer;
                case "suicide": return DeathType.Suicide;
                default: return null;
            }
        }

        public static DeathType ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this DeathType value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case DeathType.Alive:
                    serializer.Serialize(writer, "alive");
                    break;
                case DeathType.Byplayer:
                    serializer.Serialize(writer, "byplayer");
                    break;
                case DeathType.Suicide:
                    serializer.Serialize(writer, "suicide");
                    break;
            }
        }
    }

    internal static class WonExtensions
    {
        public static Won? ValueForString(string str)
        {
            switch (str)
            {
                case "false": return Won.False;
                case "true": return Won.True;
                default: return null;
            }
        }

        public static Won ReadJson(JsonReader reader, JsonSerializer serializer)
        {
            var str = serializer.Deserialize<string>(reader);
            var maybeValue = ValueForString(str);
            if (maybeValue.HasValue) return maybeValue.Value;
            throw new Exception("Unknown enum case " + str);
        }

        public static void WriteJson(this Won value, JsonWriter writer, JsonSerializer serializer)
        {
            switch (value)
            {
                case Won.False:
                    serializer.Serialize(writer, "false");
                    break;
                case Won.True:
                    serializer.Serialize(writer, "true");
                    break;
            }
        }
    }

    public static class Serialize
    {
        public static string ToJson(this JMatch self)
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
            return t == typeof(DatumType) || t == typeof(Actor) || t == typeof(ShardId) || t == typeof(DeathType) ||
                   t == typeof(Won) || t == typeof(DatumType?) || t == typeof(Actor?) || t == typeof(ShardId?) ||
                   t == typeof(DeathType?) || t == typeof(Won?);
        }

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (t == typeof(DatumType))
                return DatumTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Actor))
                return ActorExtensions.ReadJson(reader, serializer);
            if (t == typeof(ShardId))
                return ShardIdExtensions.ReadJson(reader, serializer);
            if (t == typeof(DeathType))
                return DeathTypeExtensions.ReadJson(reader, serializer);
            if (t == typeof(Won))
                return WonExtensions.ReadJson(reader, serializer);
            if (t == typeof(DatumType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DatumTypeExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(Actor?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ActorExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(ShardId?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return ShardIdExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(DeathType?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return DeathTypeExtensions.ReadJson(reader, serializer);
            }

            if (t == typeof(Won?))
            {
                if (reader.TokenType == JsonToken.Null) return null;
                return WonExtensions.ReadJson(reader, serializer);
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

            if (t == typeof(Actor))
            {
                ((Actor) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(ShardId))
            {
                ((ShardId) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(DeathType))
            {
                ((DeathType) value).WriteJson(writer, serializer);
                return;
            }

            if (t == typeof(Won))
            {
                ((Won) value).WriteJson(writer, serializer);
                return;
            }

            throw new Exception("Unknown type");
        }
    }
}