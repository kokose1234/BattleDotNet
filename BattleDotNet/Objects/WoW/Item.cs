using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class Item
    {
        /// <summary>
        /// Gets an enumerable of class IDs that can use the item.  If empty, no restriction is assumed.
        /// </summary>
        [JsonProperty("allowableClasses")]
        public IEnumerable<int> AllowableClasses { get; private set; }

        [JsonProperty("baseArmor")]
        public int BaseArmor { get; private set; }

        /// <summary>
        /// Gets the zone information the item is bound to.  If null, no restriction is assumed.
        /// </summary>
        [JsonProperty("boundZone")]
        public ItemBoundZone BoundZone { get; private set; }

        [JsonProperty("buyPrice")]
        public int BuyPrice { get; private set; }

        [JsonProperty("bonusStats")]
        public IEnumerable<ItemBonusStat> BonusStats { get; private set; }

        [JsonProperty("containerSlots")]
        public int ContainerSlots { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("disenchantingSkillRank")]
        public int DisenchantingSkillRank { get; private set; }

        [JsonProperty("hasSockets")]
        public bool HasSockets { get; private set; }

        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("inventoryType")]
        public int InventoryType { get; private set; }

        [JsonProperty("isAuctionable")]
        public bool IsAuctionable { get; private set; }

        [JsonProperty("equippable")]
        public bool IsEquippable { get; private set; }

        [JsonProperty("itemBind")]
        public int ItemBind { get; private set; }

        [JsonProperty("itemClass")]
        public int ItemClass { get; private set; }

        [JsonProperty("itemLevel")]
        public int ItemLevel { get; private set; }

        [JsonProperty("itemSource")]
        public ItemSource Source { get; private set; }

        // TODO: Implement itemSpells

        [JsonProperty("itemSubClass")]
        public int ItemSubClass { get; private set; }

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

        [JsonProperty("itemSpells")]
        public IEnumerable<ItemSpell> Spells { get; private set; }

        [JsonProperty("stackable")]
        public int Stackable { get; private set; }

        [JsonProperty("weaponInfo")]
        public ItemWeaponInfo WeaponInfo { get; private set; }
    }

    public class ItemWeaponInfo
    {
        [JsonProperty("damage")]
        public IEnumerable<ItemWeaponInfoDamage> Damage { get; private set; }

        [JsonProperty("dps")]
        public float Dps { get; private set; }

        [JsonProperty("weaponSpeed")]
        public float Speed { get; private set; }
    }

    public class ItemBoundZone
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }
    }

    public class ItemWeaponInfoDamage
    {
        [JsonProperty("minDamage")]
        public int MinDamage { get; private set; }

        [JsonProperty("maxDamage")]
        public int MaxDamage { get; private set; }
    }

    public class ItemBonusStat
    {
        [JsonProperty("stat")]
        public int Stat { get; private set; }

        [JsonProperty("amount")]
        public int Amount { get; private set; }

        [JsonProperty("reforged")]
        public bool Reforged { get; private set; }
    }

    public class ItemSource
    {
        [JsonProperty("sourceId")]
        public int ID { get; private set; }

        [JsonProperty("sourceType")]
        public string Type { get; private set; }
    }

    public class ItemSpell
    {
        [JsonProperty("categoryId")]
        public int CategoryID { get; private set; }

        [JsonProperty("nCharges")]
        public int ChargeCount { get; private set; }

        [JsonProperty("spell")]
        public ItemSpellDetails Details { get; private set; }

        [JsonProperty("consumable")]
        public bool IsConsumable { get; private set; }

        [JsonProperty("spellId")]
        public int SpellID { get; private set; }
    }

    public class ItemSpellDetails
    {
        [JsonProperty("castTime")]
        public string CastTime { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }

        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("range")]
        public string Range { get; private set; }
    }

    public enum ItemEquipType
    {
        Ammo = 0,
        Head = 1,
        Neck = 2,
        Shoulder = 3,
        Shirt = 4,
        Chest = 5,
        Waist = 6,
        Legs = 7,
        Feet = 8,
        Wrist = 9,
        Hands = 10,
        Finger = 11,
        Trinket = 12,
        OneHanded = 13,
        Bow = 15,
        Back = 16,
        TwoHanded = 17,
        Tabard = 19,
        Thrown = 25,
        Ranged = 26
    }
}