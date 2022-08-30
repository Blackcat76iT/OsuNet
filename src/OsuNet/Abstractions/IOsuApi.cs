using OsuNet.Models;
using OsuNet.Models.Options;

namespace OsuNet.Abstractions {
    public interface IOsuApi {
        string AccessToken { get; set; }

        Beatmap[] GetBeatmap(GetBeatmapsOptions options);
        User[] GetUser(GetUserOptions options);
        Scores[] GetScore(GetScoresOptions options);
        UserBest[] GetUserBest(GetUserBestOptions options);
        UserRecent[] GetUserRecent(GetUserRecentOptions options);
        Multiplayer GetMultiplayer(GetMultiplayerOptions options);
        Replay GetReplay(GetReplayOptions options);
    }
}
