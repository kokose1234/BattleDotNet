using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterGuild
    {
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; private set; }

        [JsonProperty("emblem")]
        public CharacterGuildEmblem Emblem { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("members")]
        public int MemberCount { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("realm")]
        public string Realm { get; private set; }
    }
}