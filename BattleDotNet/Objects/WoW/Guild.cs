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
        public Faction Side { get; private set; }
        #endregion

        #region Optional Member Properties
        [JsonProperty("members")]
        public IEnumerable<GuildMember> Members { get; private set; }
        #endregion

        #region Optional Achievement Properties
        [JsonProperty("achievements")]
        private GuildAchievements Achievements = null;
        #endregion

        #region Custom Achievement API
        private IEnumerable<GuildAchievement> _completedAchievements;
        public IEnumerable<GuildAchievement> CompletedAchievements
        {
            get
            {
                if (Achievements == null)
                    return Enumerable.Empty<GuildAchievement>();

                if (_completedAchievements == null)
                {
                    int[] ids = Achievements.CompletedAchievementIDs.ToArray();
                    DateTime[] dates = Achievements.CompletedAchievementDates.ToArray();

                    HashSet<GuildAchievement> completedAchievements = new HashSet<GuildAchievement>();
                    for (int i = 0; i < ids.Length; i++)
                    {
                        completedAchievements.Add(new GuildAchievement(ids[i], dates[i]));
                    }
                    _completedAchievements = completedAchievements;
                }

                return _completedAchievements;
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

    public enum Faction
    {
        Alliance,
        Horde
    }
}
