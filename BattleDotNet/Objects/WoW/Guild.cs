using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using BattleDotNet.JsonConverters;

namespace BattleDotNet.Objects.WoW
{
    using Extensions;

    public class Guild
    {
        #region Core Properties
        [JsonProperty("lastModified")]
        internal long LastModifiedTimestamp { get; private set; }
        
        public DateTime LastModifiedDate
        {
            get { return LastModifiedTimestamp.ConvertJavaScriptTimestamp(); }
        }

        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("realm")]
        public string Realm { get; private set; }

        [JsonProperty("side")]
        public GuildFaction Side { get; private set; }
        #endregion

        #region Optional Member Properties
        [JsonProperty("members")]
        public IEnumerable<GuildMember> Members { get; private set; }
        #endregion

        #region Optional Achievement Properties
        [JsonProperty("achievements")]
        private GuildAchievements Achievements;
        #endregion

        #region Custom Achievement API (because the default sucks)
        public IEnumerable<GuildCompletedAchievement> CompletedAchievements
        {
            get 
            { 
                return new GuildCompletedAchievementCollection(
                    Achievements.CompletedAchievementIDs, 
                    Achievements.CompletedAchievementDates).ToArray(); 
            }
        }
        #endregion

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Realm))
                return string.Format("{0} - {1}", Name, Realm);

            return base.ToString();
        }

    }

    public enum GuildFaction
    {
        Alliance,
        Horde
    }
}
