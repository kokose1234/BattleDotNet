using System;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BattleDotNet.Objects.WoW
{
    public class Character
    {
        [JsonProperty("achievementPoints")]
        public int AchievementPoints { get; private set; }

        [JsonProperty("appearance")]
        public CharacterAppearance Appearance { get; private set; }

        [JsonProperty("class")]
        public CharacterClass Class { get; private set; }

        [JsonProperty("guild")]
        public CharacterGuild Guild { get; private set; }

        [JsonProperty("items")]
        public CharacterItems Items { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("professions")]
        public CharacterProfessions Professions { get; private set; }

        [JsonProperty("race")]
        public CharacterRace Race { get; private set; }

        [JsonProperty("reputation")]
        public IEnumerable<CharacterReputation> Reputation { get; private set; }

        [JsonProperty("stats")]
        public CharacterStats Stats { get; private set; }

        [JsonProperty("realm")]
        public string Realm { get; private set; }

        [JsonProperty("talents")]
        public IEnumerable<CharacterTalents> Talents { get; private set; }

        [JsonProperty("titles")]
        internal IEnumerable<CharacterTitle> InternalTitles { get; private set; }

        private bool _titlesProcessed = false;
        public IEnumerable<CharacterTitle> Titles
        {
            get
            {
                if (!_titlesProcessed)
                {
                    foreach (var title in InternalTitles)
                        title.SetCharacterName(this.Name);

                    _titlesProcessed = true;
                }

                return InternalTitles;
            }
        }

        [JsonProperty("thumbnail")]
        public string ThumbnailUrl { get; private set; }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(Name) && !string.IsNullOrWhiteSpace(Realm))
                return string.Format("{0} - {1}", Name, Realm);

            return base.ToString();
        }
    }

    public enum CharacterClass
    {
        Warrior = 1,
        Paladin = 2,
        Hunter = 3,
        Rogue = 4,
        Priest = 5,
        DeathKnight = 6,
        Shaman = 7,
        Mage = 8,
        Warlock = 9,
        Druid = 11
    }

    public enum CharacterRace
    {
        Human = 1,
        Orc = 2,
        Dwarf = 3,
        NightElf = 4,
        Undead = 5,
        Tauren = 6,
        Gnome = 7,
        Troll = 8,
        Goblin = 9,
        BloodElf = 10,
        Draenei = 11,
        Worgen = 22
    }

    public enum CharacterGender
    {
        Male = 0,
        Female = 1
    }
}
