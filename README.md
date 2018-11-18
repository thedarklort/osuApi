# osuApi
Documented C# library for osu! api

<h3>Examples</h3>

First, you need to create an instance of osuApi with your api key
```csharp
osuApi api = new osuApi("your_api_key");
```

Then you can retreive data from beatmaps, users, beatmapsets, etc.
```csharp
User user = api.getUser("Cookiezi", GameMode.osu, null); // We create an instance of User and retreive data for Cookiezi.

// Then, we can interact with the user properties
Console.WriteLine("User Id: " + user.userId); // Will output 124493
Console.WriteLine("User Name: " + user.userName); // Will output Cookiezi
Console.WriteLine("User Accuracy: " + user.Accuracy); // Will output 98,7263565063477
Console.WriteLine("PP: " + user.ppRaw); // Will output 13959,1
Console.WriteLine("Rank: " + user.ppRank); // Will output 1
```
For Beatmaps its the same logic

```csharp
Beatmap bm = api.getBeatmap(774965); // https://osu.ppy.sh/b/774965?m=0

Console.WriteLine("Id: " + bm.beatmapId); // Will output 774965
Console.WriteLine("Artist: " + bm.Artist); // Will output kradness&Reol
Console.WriteLine("Song: " + bm.Title); // Will output Remote Control
Console.WriteLine("Approved Status: " + bm.Approved); // Will output Ranked
Console.WriteLine("Approved Date: " + bm.approvedDate); // Will output 18-04-2016 12:00:26
```
As you can see, using my osuApiWrapper makes the interaction with the osuApi be very easy and simple :D

For more information, you can visit the osuApi wiki https://github.com/ppy/osu-api/wiki

This project includes clases for Beatmaps, BeatmapSet, Events, Games, GameScores, Users, UserScores, Replays, Scores, Matches and MultiplayerMatches.
