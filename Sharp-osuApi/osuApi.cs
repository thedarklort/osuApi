using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
//using System.Security.Policy;
using static Sharp_osuApi.Enums;

namespace Sharp_osuApi
{
    public class osuApi
    {
        private readonly string apiKey;
        private readonly WebClient client;

        private readonly string apiUrl = "https://osu.ppy.sh/api/";
        private readonly string apiBeatmaps = "get_beatmaps";
        private readonly string apiUser = "get_user";
        private readonly string apiUserBest = "get_user_best";
        private readonly string apiUserRecent = "get_user_recent";
        private readonly string apiMatch = "get_match";
        private readonly string apiScores = "get_scores";
        private readonly string apiReplay = "get_replay";


        public osuApi(string key)
        {
            this.apiKey = key;
            this.client = new WebClient();
            this.client.BaseAddress = apiUrl;
        }

        /// <summary>
        /// Retrieve general beatmap information.
        /// </summary>
        /// <param name="id">Beatmap id</param>
        /// <returns>Beatmap object</returns>
        /// 
        public Beatmap getBeatmap(int id)
        {
            try
            {
                string url = apiBeatmaps + "?k=" + apiKey + "&b=" + id;               
                string response = client.DownloadString(url);
                List<Beatmap> b = JsonConvert.DeserializeObject<List<Beatmap>>(response);
                return b[0];
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            //catch (Exception)
            //{
            //    throw new Exception("Beatmap not found.");
            //}
        }

        /// <summary>
        /// Retrieve all beatmaps in this set.
        /// </summary>
        /// <param name="id">BeatmapSet id</param>
        /// <returns>List of Beatmap objects</returns>
        public List<Beatmap> getBeatmapSet(int id)
        {
            try
            {
                string url = apiBeatmaps + "?k=" + apiKey + "&s=" + id;
                string response = client.DownloadString(url);
                List<Beatmap> b = JsonConvert.DeserializeObject<List<Beatmap>>(response);
                return b;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("BeatmapSet not found.");
            }
        }

        public List<Beatmap> getBeatmapSet(string hash)
        {
            try
            {
                string url = apiBeatmaps + "?k=" + apiKey + "&h=" + hash;
                string response = client.DownloadString(url);
                List<Beatmap> b = JsonConvert.DeserializeObject<List<Beatmap>>(response);
                return b;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("BeatmapSet not found.");
            }
        }

        /// <summary>
        /// Retrieve beatmaps in this set wich mode are the specified.
        /// </summary>
        /// <param name="id">BeatmapSet id</param>
        /// <param name="mode">GameMode</param>
        /// <returns>List of Beatmap objects</returns>
        public List<Beatmap> getBeatmapSet(int id, GameMode mode)
        {
            try
            {
                string url = apiBeatmaps + "?k=" + apiKey + "&s=" + id + "&m=" + (int)mode;
                string response = client.DownloadString(url);
                List<Beatmap> b = JsonConvert.DeserializeObject<List<Beatmap>>(response);
                return b;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("BeatmapSet not found or this BeatmapSet doesn't have Beatmaps for this mode.");
            }
        }

        /// <summary>
        /// Retrieve general user information.
        /// </summary>
        /// <param name="name">UserName to return metadata from</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <param name="event_days">Max number of days between now and last event date. Range of 1-31. Nullable, default value is 1.</param>
        /// <returns>User object</returns>
        public User getUser(string name, GameMode? mode, int? event_days)
        {
            try
            {
                event_days = event_days ?? 1;
                GameMode m = mode ?? GameMode.osu;
                string url = apiUser + "?k=" + apiKey + "&u=" + name + "&m=" + (int)m + "&event_days=" + event_days+ "&type=string";
                string response = client.DownloadString(url);
                List<User> u = JsonConvert.DeserializeObject<List<User>>(response);
                return u[0];
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("User not found.");
            }
        }

        /// <summary>
        /// Retrieve general user information.
        /// </summary>
        /// <param name="id">UserId to return metadata from.</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <param name="event_days">Max number of days between now and last event date. Range of 1-31. Nullable, default value is 1.</param>
        /// <returns>User object</returns>
        public User getUser(int id, GameMode? mode, int? event_days)
        {
            try
            {
                event_days = event_days ?? 1;
                GameMode m = mode ?? GameMode.osu;
                string url = apiUser + "?k=" + apiKey + "&u=" + id + "&m=" + (int)m + "&event_days="+event_days+"&type=id";
                string response = client.DownloadString(url);
                List<User> u = JsonConvert.DeserializeObject<List<User>>(response);
                return u[0];
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("User not found.");
            }
        }

        /// <summary>
        /// Retrieve information about the top 100 scores of a specified beatmap
        /// </summary>
        /// <param name="id">Specify a beatmap_id to return score information from.</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <param name="limit">Amount of results from the top (range between 1 and 100 - defaults to 50)</param>
        /// <returns></returns>
        public List<Score> getBeatmapScores(int id, GameMode? mode, int? limit)
        {
            try
            {
                limit = limit ?? 50;
                GameMode m = mode ?? GameMode.osu;
                string url = apiScores + "?k=" + apiKey + "&m=" + (int)m + "&limit=" + limit+"&b="+id;
                string response = client.DownloadString(url);
                List<Score> u = JsonConvert.DeserializeObject<List<Score>>(response);
                return u;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Retrieve information about the top score of an user on the specified map
        /// </summary>
        /// <param name="id">UserId to return metadata from</param>
        /// <param name="bid">Specify a beatmap_id to return score information from.</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <returns>Score Object</returns>
        public Score getUserBeatmapScore(int id, int bid, GameMode? mode)
        {
            try
            {
                GameMode m = mode ?? GameMode.osu;
                string url = apiScores + "?k=" + apiKey + "&m=" + (int)m+"&type=id"+"&u="+id+"&b="+bid;
                string response = client.DownloadString(url);
                List<Score> u = JsonConvert.DeserializeObject<List<Score>>(response);
                return u[0];
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Retrieve information about the top score of an user on the specified map
        /// </summary>
        /// <param name="userName">UserName to return metadata from</param>
        /// <param name="bid">Specify a beatmap_id to return score information from.</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <returns>Score Object</returns>
        public Score getUserBeatmapScore(string userName, int bid, GameMode? mode)
        {
            try
            {
                GameMode m = mode ?? GameMode.osu;
                string url = apiScores + "?k=" + apiKey + "&m=" + (int)m + "&type=string" + "&u=" + userName + "&b=" + bid;
                string response = client.DownloadString(url);
                List<Score> u = JsonConvert.DeserializeObject<List<Score>>(response);
                return u[0];
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Get the top scores for the specified user.
        /// </summary>
        /// <param name="id">UserId to return metadata from</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <param name="limit">Amount of results from the top (range between 1 and 100 - defaults to 10).</param>
        /// <returns>List of UserScore Objects</returns>
        public List<UserScore> getUserBest(int id, GameMode? mode, int? limit)
        {
            try
            {
                limit = limit ?? 10;
                GameMode m = mode ?? GameMode.osu;
                string url = apiUserBest + "?k=" + apiKey + "&m=" + (int)m + "&u=" + id +"&limit="+limit + "&type=id";
                string response = client.DownloadString(url);
                List<UserScore> u = JsonConvert.DeserializeObject<List<UserScore>>(response);
                return u;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Get the top scores for the specified user.
        /// </summary>
        /// <param name="userName">UserName to return metadata from</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <param name="limit">Amount of results from the top (range between 1 and 100 - defaults to 10).</param>
        /// <returns>List of UserScore Objects</returns>
        public List<UserScore> getUserBest(string userName, GameMode? mode, int? limit)
        {
            try
            {
                limit = limit ?? 10;
                GameMode m = mode ?? GameMode.osu;
                string url = apiUserBest + "?k=" + apiKey + "&m=" + (int)m + "&type=string" + "&u=" + userName + "&limit=" + limit;
                string response = client.DownloadString(url);
                List<UserScore> u = JsonConvert.DeserializeObject<List<UserScore>>(response);
                return u;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Gets the user's ten most recent plays.
        /// </summary>
        /// <param name="id">UserId to return metadata from</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <param name="limit">Amount of results from the top (range between 1 and 50 - defaults to 10).</param>
        /// <returns>List of UserScore Objects</returns>
        public List<UserScore> getUserRecent(int id, GameMode? mode, int? limit)
        {
            try
            {
                limit = limit ?? 10;
                GameMode m = mode ?? GameMode.osu;
                string url = apiUserRecent + "?k=" + apiKey + "&m=" + (int)m + "&u=" + id + "&limit=" + limit + "&type=id";
                string response = client.DownloadString(url);
                List<UserScore> u = JsonConvert.DeserializeObject<List<UserScore>>(response);
                return u;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Gets the user's ten most recent plays.
        /// </summary>
        /// <param name="userName">UserName to return metadata from</param>
        /// <param name="mode">GameMode. Nullable, default value is osu.</param>
        /// <param name="limit">Amount of results from the top (range between 1 and 50 - defaults to 10).</param>
        /// <returns>List of UserScore Objects</returns>
        public List<UserScore> getUserRecent(string userName, GameMode? mode, int? limit)
        {
            try
            {
                limit = limit ?? 10;
                GameMode m = mode ?? GameMode.osu;
                string url = apiUserRecent + "?k=" + apiKey + "&m=" + (int)m + "&type=string" + "&u=" + userName + "&limit=" + limit;
                string response = client.DownloadString(url);
                List<UserScore> u = JsonConvert.DeserializeObject<List<UserScore>>(response);
                return u;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception)
            {
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Retrieve information about multiplayer match.
        /// </summary>
        /// <param name="id">Match id to get information from.</param>
        /// <returns>MultiplayerMatch object</returns>
        public MultiplayerMatch getMatch(int id)
        {
            try
            {
                string url = apiMatch + "?k=" + apiKey + "&mp=" + id;
                string response = client.DownloadString(url);
                MultiplayerMatch u = JsonConvert.DeserializeObject<MultiplayerMatch>(response);
                return u;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception e)
            {
                throw e;
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Get the replay data of a user's score on a map.
        /// </summary>
        /// <param name="userId">User ID not nullable</param>
        /// <param name="mode">GameMode not nullable..</param>
        /// <param name="bId">Beatmap ID not nullable.</param>
        /// <returns>Replay object</returns>
        public Replay getReplay(int userId, GameMode mode, int bId)
        {
            try
            {
                string url = apiReplay + "?k=" + apiKey + "&m=" + (int)mode+"&u="+userId+"&b="+bId;
                string response = client.DownloadString(url);
                Replay r = JsonConvert.DeserializeObject<Replay>(response);
                return r;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception e)
            {
                throw e;
                throw new Exception("Data not found.");
            }
        }

        /// <summary>
        /// Get the replay data of a user's score on a map.
        /// </summary>
        /// <param name="userName">Username not nullable</param>
        /// <param name="mode">GameMode not nullable..</param>
        /// <param name="bId">Beatmap ID not nullable.</param>
        /// <returns>Replay object</returns>
        public Replay getReplay(string userName, GameMode mode, int bId)
        {
            try
            {
                string url = apiReplay + "?k=" + apiKey + "&m=" + (int)mode + "&u=" + userName + "&b=" + bId;
                string response = client.DownloadString(url);
                Replay r = JsonConvert.DeserializeObject<Replay>(response);
                return r;
            }
            catch (WebException w)
            {
                throw new Exception(w.Message);
            }
            catch (Exception e)
            {
                throw e;
                throw new Exception("Data not found.");
            }
        }
    }
}
