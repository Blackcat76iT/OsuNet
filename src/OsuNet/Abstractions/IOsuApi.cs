using OsuNet.Models;
using OsuNet.Models.Options;

namespace OsuNet.Abstractions {
    public interface IOsuApi {
        string AccessToken { get; set; }

        Beatmap[] GetBeatmap(GetBeatmapOptions options);
        Task<Beatmap[]> GetBeatmapAsync(GetBeatmapOptions options);
        User[] GetUser(GetUserOptions options);
        Task<User[]> GetUserAsync(GetUserOptions options);
        Scores[] GetScore(GetScoresOptions options);
        Task<Scores[]> GetScoreAsync(GetScoresOptions options);
        UserBest[] GetUserBest(GetUserBestOptions options);
        Task<UserBest[]> GetUserBestAsync(GetUserBestOptions options);
        UserRecent[] GetUserRecent(GetUserRecentOptions options);
        Task<UserRecent[]> GetUserRecentAsync(GetUserRecentOptions options);
        Multiplayer GetMultiplayer(GetMultiplayerOptions options);
        Task<Multiplayer> GetMultiplayerAsync(GetMultiplayerOptions options);
        Replay GetReplay(GetReplayOptions options);
        Task<Replay> GetReplayAsync(GetReplayOptions options);
    }
}
