using System.Net;
using System.Web;
using Newtonsoft.Json;
using OsuNet.Models;
using OsuNet.Converters;
using OsuNet.Abstractions;
using OsuNet.Models.Options;

namespace OsuNet {
    public class OsuApi : IOsuApi {
        public string AccessToken { get; set; }

        public OsuApi(string accessToken) { 
            AccessToken = accessToken;
        }

        private T fromJson<T>(Stream stream) {
            using (StreamReader sr = new StreamReader(stream)) {
                using (JsonTextReader jsonReader = new JsonTextReader(sr)) {
                    JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings() {
                        Converters = new JsonConverter[1] {
                            new OsuBoolConverter()
                        }
                    });
                    return serializer.Deserialize<T>(jsonReader);
                }
            }
        }

        private T get<T>(string url, IEnumerable<KeyValuePair<string, string>> query) {
            HttpWebRequest request = WebRequest.CreateHttp($"{url}?{string.Join("&", query.Select(kv => $"{kv.Key}={HttpUtility.UrlEncode(kv.Value)}"))}");
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            request.Headers.Add("Accept-Encoding", "gzip,deflate");
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse()) {
                return fromJson<T>(response.GetResponseStream());
            }
        }

        /// <summary>
        /// Retrieve general beatmap information.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Array of beatmap.</returns>
        public Beatmap[] GetBeatmap(GetBeatmapOptions options) {
            string url = "https://osu.ppy.sh/api/get_beatmaps";
            Dictionary<string, string> query = new Dictionary<string, string>() {
                { "k", AccessToken },
                { "since", options.Since?.ToUniversalTime().ToString("yyyy-MM-dd HH:mm:ss") },
                { "s", options.BeatmapSetId?.ToString() },
                { "b", options.BeatmapId?.ToString() },
                { "u", options.UserId?.ToString() },
                { "type", options.Type },
                { "m", ((int?)options.Mode)?.ToString() },
                { "a", options.ConvertedBeatmaps == true ? "1" : "0" },
                { "h", options.Hash },
                { "limit", options.Limit?.ToString() },
                { "mods", options.Mods?.ToString() }
            };
            return get<Beatmap[]>(url, query.Where(kv => kv.Value != null));
        }

        /// <summary>
        /// Retrieve general user information.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Array of user.</returns>
        public User[] GetUser(GetUserOptions options) {
            string url = "https://osu.ppy.sh/api/get_user";
            Dictionary<string, string> query = new Dictionary<string, string>() {
                { "k", AccessToken },
                { "u", options.User.ToString() },
                { "m", ((int)options.Mode).ToString() },
                { "type", options.Type },
                { "event_days", options.EventDays?.ToString() }
            };
            return get<User[]>(url, query.Where(kv => kv.Value != null));
        }

        /// <summary>
        /// Retrieve information about the top 100 scores of a specified beatmap.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Array of scores.</returns>
        public Scores[] GetScore(GetScoresOptions options) {
            string url = "https://osu.ppy.sh/api/get_scores";
            Dictionary<string, string> query = new Dictionary<string, string>() {
                { "k", AccessToken },
                { "b", options.BeatmapId?.ToString() },
                { "u", options.User },
                { "m", ((int?)options.Mode).ToString() },
                { "mods", options.Mods?.ToString() },
                { "type", options.Type},
                { "limit", options.Limit?.ToString() }
            };
            return get<Scores[]>(url, query.Where(kv => kv.Value != null));
        }

        /// <summary>
        /// Get the top scores for the specified user.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Array of the user's best scores.</returns>
        public UserBest[] GetUserBest(GetUserBestOptions options) {
            string url = "https://osu.ppy.sh/api/get_user_best";
            Dictionary<string, string> query = new Dictionary<string, string>() {
                { "k", AccessToken },
                { "u", options.User },
                { "m", ((int?)options.Mode)?.ToString() },
                { "limit", options.Limit?.ToString() },
                { "type", options.Type }
            };
            return get<UserBest[]>(url, query.Where(kv => kv.Value != null));
        }

        /// <summary>
        /// Gets the user's ten most recent plays over the last 24 hours.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Array of the user's recent results.</returns>
        public UserRecent[] GetUserRecent(GetUserRecentOptions options) {
            string url = "https://osu.ppy.sh/api/get_user_recent";
            Dictionary<string, string> query = new Dictionary<string, string>() {
                { "k", AccessToken },
                { "u", options.User },
                { "m", ((int?)options.Mode)?.ToString() },
                { "limit", options.Limit?.ToString() },
                { "type", options.Type}
            };
            return get<UserRecent[]>(url, query.Where(kv => kv.Value != null));
        }

        /// <summary>
        /// Retrieve information about a multiplayer match.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Information about a multiplayer match.</returns>
        public Multiplayer GetMultiplayer(GetMultiplayerOptions options) {
            string url = "https://osu.ppy.sh/api/get_match";
            Dictionary<string, string> query = new Dictionary<string, string>() {
                { "k", AccessToken },
                { "mp", options.MatchId.ToString() }
            };
            return get<Multiplayer>(url, query.Where(kv => kv.Value != null));
        }

        /// <summary>
        /// Get the replay data of a user's score on a map.
        /// You are only allowed to do 10 requests per minute.
        /// </summary>
        /// <param name="options"></param>
        /// <returns>Replay data of a user's score on a map.</returns>
        public Replay GetReplay(GetReplayOptions options) {
            string url = "https://osu.ppy.sh/api/get_replay";
            Dictionary<string, string> query = new Dictionary<string, string>() {
                { "k", AccessToken },
                { "b", options.BeatmapId.ToString() },
                { "u", options.User },
                { "m", ((int?)options.Mode)?.ToString() },
                { "s", options.ScoreId },
                { "type", options.Type },
                { "mods", ((int?)options.Mods)?.ToString() }
            };
            return get<Replay>(url, query.Where(kv => kv.Value != null));
        }
    }
}
