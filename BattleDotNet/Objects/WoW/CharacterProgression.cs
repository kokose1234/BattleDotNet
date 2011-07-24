using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterProgression
    {
        [JsonProperty("raids")]
        public IEnumerable<CharacterProgressionRaid> Raids { get; private set; }
    }

    public class CharacterProgressionRaid
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normal")]
        public ProgressionStatus NormalStatus { get; private set; }

        [JsonProperty("heroic")]
        public ProgressionStatus HeroicStatus { get; private set; }

        [JsonProperty("bosses")]
        public IEnumerable<CharacterProgressionBoss> Bosses { get; private set; }
    }

    public enum ProgressionStatus
    {
        NotStarted = 0,
        PartiallyCleared = 1,
        Cleared = 2
    }

    public class CharacterProgressionBoss
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("normalKills")]
        public int NormalKills { get; private set; }

        [JsonProperty("heroicKills")]
        public int HeroicKills { get; private set; }
    }
}