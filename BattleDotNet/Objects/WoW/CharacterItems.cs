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

        [JsonProperty("head")]
        public CharacterItem Head { get; private set; }

        [JsonProperty("neck")]
        public CharacterItem Neck { get; private set; }

        [JsonProperty("shoulder")]
        public CharacterItem Shoulder { get; private set; }

        [JsonProperty("back")]
        public CharacterItem Back { get; private set; }

        [JsonProperty("chest")]
        public CharacterItem Chest { get; private set; }

        [JsonProperty("tabard")]
        public CharacterItem Tabard { get; private set; }

        [JsonProperty("wrist")]
        public CharacterItem Wrist { get; private set; }

        [JsonProperty("hands")]
        public CharacterItem Hands { get; private set; }

        [JsonProperty("waist")]
        public CharacterItem Waist { get; private set; }

        [JsonProperty("legs")]
        public CharacterItem Legs { get; private set; }

        [JsonProperty("feet")]
        public CharacterItem Feet { get; private set; }

        [JsonProperty("finger1")]
        public CharacterItem Finger1 { get; private set; }

        [JsonProperty("finger2")]
        public CharacterItem Finger2 { get; private set; }

        [JsonProperty("trinket1")]
        public CharacterItem Trinket1 { get; private set; }

        [JsonProperty("trinket2")]
        public CharacterItem Trinket2 { get; private set; }

        [JsonProperty("mainHand")]
        public CharacterItem MainHand { get; private set; }

        [JsonProperty("offHand")]
        public CharacterItem OffHand { get; private set; }

        [JsonProperty("ranged")]
        public CharacterItem Ranged { get; private set; }
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

    public class CharacterItemTooltip
    {
        [JsonProperty("enchant")]
        public int? EnchandID { get; private set; }

        [JsonProperty("gem0")]
        public int? Gem1ID { get; private set; }

        [JsonProperty("gem1")]
        public int? Gem2ID { get; private set; }

        [JsonProperty("gem2")]
        public int? Gem3ID { get; private set; }

        [JsonProperty("gem3")]
        public int? Gem4ID { get; private set; }

        [JsonProperty("extraSocket")]
        public bool HasExtraSocket { get; private set; }

        [JsonProperty("reforge")]
        public int? ReforgeID { get; private set; }

        [JsonProperty("set")]
        public IEnumerable<int> SetItemIDs { get; private set; }
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
