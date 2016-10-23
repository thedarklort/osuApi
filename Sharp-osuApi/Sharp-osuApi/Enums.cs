namespace Sharp_osuApi
{
    public class Enums
    {
        public enum GameMode
        {
            osu = 0,
            Taiko = 1, 
            CtB = 2,
            Mania = 3
        }

        public enum Approved
        {
            Graveyard = -2,
            WIP = -1,
            Pending = 0,
            Ranked = 1,
            Approved = 2,
            Qualified = 3,
            Loved = 4
        }

        public enum Genre
        {
            Any = 0,
            Unspecified = 1,
            VideoGame = 2,
            Anime = 3,
            Rock = 4,
            Pop = 5,
            Other = 6,
            Novelty = 7,
            HipHop = 9,
            Electronic = 10
        }

        public enum Language
        {
            Any = 0,
            Other = 1,
            English = 2,
            Japanese = 3,
            Chinese = 4,
            Instrumental = 5,
            Korean = 6,
            French = 7,
            German = 8,
            Swedish = 9,
            Spanish = 10,
            Italian = 11
        }

        public enum ScoringType
        {
            Score = 0,
            Accuracy = 1,
            Combo = 2,
            Scorev2 = 3
        }

        public enum TeamType
        {
            HeadToHead = 0,
            TagCoop = 1,
            TeamVS = 2,
            TagTeamVS = 3
        }

        public enum Team
        {
            None = 0,
            Blue = 1,
            Red = 2
        }

        public enum Mods
        {
            None = 0,
            NoFail = 1,
            Easy = 2,
            //NoVideo      = 4,
            Hidden = 8,
            HardRock = 16,
            SuddenDeath = 32,
            DoubleTime = 64,
            Relax = 128,
            HalfTime = 256,
            Nightcore = 512, // Only set along with DoubleTime. i.e: NC only gives 576
            Flashlight = 1024,
            Autoplay = 2048,
            SpunOut = 4096,
            Relax2 = 8192,  // Autopilot?
            Perfect = 16384,
            Key4 = 32768,
            Key5 = 65536,
            Key6 = 131072,
            Key7 = 262144,
            Key8 = 524288,
            keyMod = Key4 | Key5 | Key6 | Key7 | Key8,
            FadeIn = 1048576,
            Random = 2097152,
            LastMod = 4194304,
            FreeModAllowed = NoFail | Easy | Hidden | HardRock | SuddenDeath | Flashlight | FadeIn | Relax | Relax2 | SpunOut | keyMod,
            Key9 = 16777216,
            Key10 = 33554432,
            Key1 = 67108864,
            Key3 = 134217728,
            Key2 = 268435456
        }
    }
}
