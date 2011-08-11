using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class Item
    {
        [JsonProperty("baseArmor")]
        public int BaseArmor { get; private set; }

        // TODO: Implement bonusStats

        [JsonProperty("containerSlots")]
        public int ContainerSlots { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("disenchantingSkillRank")]
        public int DisenchantingSkillRank { get; private set; }

        [JsonProperty("equippable")]
        public bool Equippable { get; private set; }

        [JsonProperty("hasSockets")]
        public bool HasSockets { get; private set; }

        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("inventoryType")]
        public int InventoryType { get; private set; }

        [JsonProperty("isAuctionable")]
        public bool IsAuctionable { get; private set; }

        // TODO: Implement itemBind

        [JsonProperty("itemClass")]
        public ItemClassInfo ItemClass { get; private set; }

        [JsonProperty("itemLevel")]
        public int ItemLevel { get; private set; }

        // TODO: Implement itemSource

        // TODO: Implement itemSpells

        [JsonProperty("itemSubClass")]
        public ItemSubClassInfo ItemSubClass { get; private set; }

        [JsonProperty("maxCount")]
        public int MaxCount { get; private set; }

        [JsonProperty("maxDurability")]
        public int MaxDurability { get; private set; }

        [JsonProperty("minFactionId")]
        public int MinFactionID { get; private set; }

        [JsonProperty("minReputation")]
        public int MinReputation { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("quality")]
        public int Quality { get; private set; }

        [JsonProperty("requiredLevel")]
        public int RequiredLevel { get; private set; }

        [JsonProperty("requiredSkill")]
        public int RequiredSkill { get; private set; }

        [JsonProperty("requiredSkillRank")]
        public int RequiredSkillRank { get; private set; }

        [JsonProperty("sellPrice")]
        public int SellPrice { get; private set; }


        [JsonProperty("stackable")]
        public int Stackable { get; private set; }

        // TODO: Impelement weaponInfo
    }
}
