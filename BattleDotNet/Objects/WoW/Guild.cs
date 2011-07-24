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

        [JsonProperty("realm")]
        public string Realm { get; private set; }

        [JsonProperty("side")]
        public CharacterFaction Side { get; private set; }
        #endregion

        #region Optional Member Properties
        [JsonProperty("members")]
        public IEnumerable<GuildMember> Members { get; private set; }
        #endregion

        #region Optional Achievement Properties
        [JsonProperty("achievements")]
        private GuildAchievementData Achievements;
        #endregion

        #region Custom Achievement API (because the default sucks)
        public IEnumerable<GuildCompletedAchievement> CompletedAchievements
        {
            get 
            { 
                return new GuildCompletedAchievementCollection(
                    Achievements.AchievementsCompleted, 
                    Achievements.AchievementsCompletedTimestamp).ToArray(); 
            }
        }
        #endregion

        #region Private Types
        private class GuildAchievementData
        {
            [JsonProperty("achievementsCompleted")]
            internal IEnumerable<int> AchievementsCompleted { get; private set; }

            [JsonProperty("achievementsCompletedTimestamp")]
            internal IEnumerable<long> AchievementsCompletedTimestamp { get; private set; }

            [JsonProperty("criteria")]
            internal IEnumerable<int> Criteria { get; private set; }

            [JsonProperty("criteriaQuantity")]
            internal IEnumerable<int> CriteriaQuantity { get; private set; }

            [JsonProperty("criteriaTimestamp")]
            internal IEnumerable<long> CriteriaTimestamp { get; private set; }

            [JsonProperty("criteriaCreated")]
            internal IEnumerable<long> CriteriaCreated { get; private set; }

        }

        #endregion

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Realm))
                return string.Format("{0} - {1}", Name, Realm);

            return base.ToString();
        }

    }

    public enum CharacterFaction
    {
        Alliance,
        Horde
    }
}
