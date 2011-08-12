using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class GuildReward
    {
        [JsonProperty("minGuildLevel")]
        public int MinGuildLevel { get; private set; }

        [JsonProperty("minGuildRepLevel")]
        public int MinGuildRepLevel { get; private set; }

        [JsonProperty("races")]
        public IEnumerable<int> RaceIDs { get; private set; }

        [JsonProperty("achievement")]
        public GuildRewardAchievement Achievement { get; private set; }

        [JsonProperty("item")]
        public GuildRewardItem Item { get; private set; }
    }

    public class GuildRewardAchievement
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("points")]
        public int Points { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("reward")]
        public string RewardName { get; private set; }

        [JsonProperty("rewardItem")] // Not sure why Blizzard put this here, too
        public GuildRewardItem RewardItem { get; private set; }
    }

    public class GuildRewardItem
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("quantity")]
        public int Quantity { get; private set; }
    }
}
