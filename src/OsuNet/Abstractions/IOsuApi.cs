using OsuNet.Models;
using OsuNet.Models.Options;

namespace OsuNet.Abstractions {
    public interface IOsuApi {
        string AccessToken { get; set; }

        Beatmap[] GetBeatmap(GetBeatmapOptions options);
        User[] GetUser(GetUserOptions options);
        UserBest[] GetUserBest(GetUserBestOptions options);
        UserRecent[] GetUserRecent(GetUserRecentOptions options);
        Scores[] GetScores(GetScoresOptions options);
        Multiplayer GetMultiplayer(GetMultiplayerOptions options);
        Replay GetReplay(GetReplayOptions options);
        Task<Beatmap[]> GetBeatmapAsync(GetBeatmapOptions options);
        Task<User[]> GetUserAsync(GetUserOptions options);
        Task<UserBest[]> GetUserBestAsync(GetUserBestOptions options);
        Task<UserRecent[]> GetUserRecentAsync(GetUserRecentOptions options);
        Task<Scores[]> GetScoresAsync(GetScoresOptions options);
        Task<Multiplayer> GetMultiplayerAsync(GetMultiplayerOptions options);
        Task<Replay> GetReplayAsync(GetReplayOptions options);
    }
}
