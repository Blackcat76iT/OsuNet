# OsuNet
OsuNet is a library for the [Osu!API v1](https://github.com/ppy/osu-api/wiki)

## Installation
```
PM> Install-Package OsuNet
```

## Usage Example
Before you can start using the library, you must obtain a [token](https://osu.ppy.sh/p/api/) (It is abcisable to log into your Osu acconunt in advence)

**An example of using this library:**
```cs
using System;
using OsuNet;
using OsuNet.Models;
using OsuNet.Models.Options;

public class Program {
    private static readonly OsuApi api = new OsuApi("Your Token");

    static void Main(string[] args) {
        Console.WriteLine(GetBeatmapAsync(3713514).Title);
        Console.WriteLine(GetBeatmapAsync(3713514).GetThumbnail()) // Returns a reference to the thumbnail beatmap
    }

    public static Beatmap GetBeatmapAsync(ulong id) {
        Beatmap beatmap = (await api.GetBeatmapAsync(new GetBeatmapOptions() {
            BeatmapId = id
        })).FirstOrDefault();

        return beatmap;
    }
}
```
## License
[MIT license](LICENSE)

## Additionally
[![.NET](https://github.com/Blackcat76iT/OsuNet/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Blackcat76iT/OsuNet/actions/workflows/dotnet.yml)