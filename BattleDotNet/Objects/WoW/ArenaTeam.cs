using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class ArenaTeam
    {
        [JsonProperty("created")]
        public DateTime CreatedOn { get; private set; }

        [JsonProperty("side")]
        public Faction Faction { get; private set; }

        [JsonProperty("gamesLost")]
        public int GamesLost { get; private set; }

        [JsonProperty("gamesPlayed")]
        public int GamesPlayed { get; private set; }

        [JsonProperty("gamesWon")]
        public int GamesWon { get; private set; }

        [JsonProperty("lastSessionRanking")]
        public int LastSessionRanking { get; private set; }

        [JsonProperty("members")]
        public ArenaCharacter[] Members { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("ranking")]
        public int Ranking { get; private set; }

        [JsonProperty("rating")]
        public int Rating { get; private set; }

        [JsonProperty("realm")]
        public string Realm { get; private set; }

        [JsonProperty("sessionGamesLost")]
        public int SessionGamesLost { get; private set; }

        [JsonProperty("sessionGamesPlayed")]
        public int SessionGamesPlayed { get; private set; }

        [JsonProperty("sessionGamesWon")]
        public int SessionGamesWon { get; private set; }

        [JsonProperty("teamsize")]
        public int TeamSize { get; private set; }
    }
}
