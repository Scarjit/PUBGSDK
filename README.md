# PUBGSDK

This API allows you to interact with the pubg api at a very low level
It only does the requests and conversion to JSON objects for you

## Usage
You can find a usage sample in the TestApp/Program.cs file

### Authorization
The API_KEY and REGION are saved inside the Authorization class
```cs
var authorization = new Authorization(string API_KEY, enum REGION = pc_eu)
```

### Match
The Match class returns informations about a specifc match

```cs
var m = new Match(authorization);
var match = m.GetMatchById(string MATCH_ID);


//Get the telemetry data's from the match
var telem = m.GetTelemetry(match);
```

### Player
The player class can find player(s) by Name or Id's

```cs
var p = new Player(authorization);
var player = p.GetPlayerById(string PLAYER_ID);

//Select multiple players by name
//Please notice, that the api silently ignores invalid name's
var players = p.GetPlayersByNames(new List<string> {PLAYER_NAMES'S});

//Select multiple players by account id
//Please notice, that the api silently ignores invalid id's
var players2 =
    p.GetPlayersByIds(new List<string> {PLAYER_ID'S});
```

### Telemetry
Retrived the telemetry data of a match
Please use this carefully, as it generates high loads on the pubg server infrastructure

```cs
//Generates a new Telemetry object and pass the first telemetry of the match object into it.
var t = new Telemetry();
var xtelem = t.GetTelemetry(string URL);
```
