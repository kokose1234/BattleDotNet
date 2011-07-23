using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BattleDotNet.JsonConverters;

namespace BattleDotNet.Objects.WoW
{
    public class Guild
    {
        #region Core Properties
        [JsonProperty("lastModified")]

        [JsonConverter(typeof(JavaScriptTimeStampConverter))]
        public DateTime LastModified { get; private set; }

        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("side")]
        public CharacterFaction Side { get; private set; }
        #endregion

        #region Optional Member Properties
        [JsonProperty("members")]
        public IEnumerable<GuildMember> Members { get; private set; }
        #endregion

        #region Optional Achievement Properties


        #endregion

    }

    public enum CharacterFaction
    {
        Alliance,
        Horde
    }
}
