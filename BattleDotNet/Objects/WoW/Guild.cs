using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class Guild
    {
        #region Core Properties
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
