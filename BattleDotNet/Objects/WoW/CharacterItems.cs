using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterItems
    {
        [JsonProperty("averageItemLevel")]
        public int AverageItemLevel { get; private set; }

        [JsonProperty("averageItemLevelEquipped")]
        public int AverageItemLevelEquipped { get; private set; }
    }

    public class CharacterItem
    {
        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("id")]
        public int ItemID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("quality")]
        public ItemQuality Quality { get; private set; }
    }

    public enum ItemQuality
    {
        /// <summary>
        /// Represents a gray item
        /// </summary>
        Poor = 0,
        /// <summary>
        /// Represents a white item
        /// </summary>
        Common = 1,
        /// <summary>
        /// Represents a green item
        /// </summary>
        Uncommon = 2,
        /// <summary>
        /// Represents a blue item
        /// </summary>
        Rare = 3,
        /// <summary>
        /// Represents a purple item
        /// </summary>
        Epic = 4,
        /// <summary>
        /// Represents a orange item
        /// </summary>
        Legendary = 5,
        /// <summary>
        /// Represents a light gold item
        /// </summary>
        Artifact = 6,
        /// <summary>
        /// Represents a light gold item
        /// </summary>
        Heirloom = 7
    }
}
