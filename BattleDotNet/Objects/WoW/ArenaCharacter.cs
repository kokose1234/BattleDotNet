using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class ArenaCharacter
    {
        [JsonProperty("character")]
        public MetaCharacter Character { get; private set; }

        [JsonProperty("gamesLost")]
        public int GamesLost { get; private set; }

        [JsonProperty("gamesPlayed")]
        public int GamesPlayed { get; private set; }

        [JsonProperty("gamesWon")]
        public int GamesWon { get; private set; }

        [JsonProperty("rank")]
        public int Rank { get; private set; }

        [JsonProperty("personalRating")]
        public int Rating { get; private set; }

        [JsonProperty("sessionGamesLost")]
        public int SessionGamesLost { get; private set; }

        [JsonProperty("sessionGamesPlayed")]
        public int SessionGamesPlayed { get; private set; }

        [JsonProperty("sessionGamesWon")]
        public int SessionGamesWon { get; private set; }
    }
}
