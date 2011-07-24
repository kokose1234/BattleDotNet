using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    using JsonConverters;

    public class GuildAchievements
    {
        [JsonProperty("achievementsCompleted")]
        internal IEnumerable<int> CompletedAchievementIDs { get; private set; }

        [JsonProperty("achievementsCompletedTimestamp")]
        [JsonConverter(typeof(IEnumerableJavaScriptTimeStampConverter))]
        public IEnumerable<DateTime> CompletedAchievementDates { get; private set; }

        [JsonProperty("criteria")]
        internal IEnumerable<int> CriteriaIDs { get; private set; }

        [JsonProperty("criteriaQuantity")]
        internal IEnumerable<int> CriteriaQuantities { get; private set; }

        [JsonProperty("criteriaTimestamp")]
        internal IEnumerable<long> CriteriaTimestamps { get; private set; }

        [JsonProperty("criteriaCreated")]
        internal IEnumerable<long> CriteriaCreated { get; private set; }
    }
}
