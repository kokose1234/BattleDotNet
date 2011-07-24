using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class GuildCharacter
    {
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; private set; }

        [JsonProperty("class")]
        public CharacterClass Class { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("race")]
        public CharacterRace Race { get; private set; }

        [JsonProperty("realm")]
        public string Realm { get; private set; }

        [JsonProperty("thumbnail")]
        public string ThumbnailUrl { get; private set; }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Realm))
                return string.Format("{0} - {1}", Name, Realm);

            return base.ToString();
        }
    }
}
