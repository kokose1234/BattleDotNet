using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleDotNet.Objects.WoW;
using Newtonsoft.Json;
using BattleDotNet.JsonConverters;

namespace BattleDotNet
{
    public class WoWClient : Client
    {
        public WoWClient(Region? region = Region.US, string publicKey = null, string privateKey = null)
            : base("wow", region, publicKey, privateKey)
        {
        }

        #region Private Types
        internal class AuctionData
        {
            internal class AuctionsData
            {
                [JsonProperty("auctions")]
                internal IEnumerable<Auction> Auctions { get; private set; }
            }

            [JsonProperty("alliance")]
            internal AuctionsData Alliance { get; private set; }

            [JsonProperty("horde")]
            internal AuctionsData Horde { get; private set; }

            [JsonProperty("neutral")]
            internal AuctionsData Neutral { get; private set; }
        }

        private class AuctionMetaData
        {
            [JsonProperty("files")]
            internal IEnumerable<AuctionMetaDataFile> Files { get; private set; }
        }

        private class AuctionMetaDataFile
        {
            [JsonProperty("url")]
            public string Url { get; private set; }

            [JsonProperty("lastModified")]
            [JsonConverter(typeof(JavaScriptTimeStampConverter))]
            public DateTime LastModified { get; private set; }
        }

        private class ClassData
        {
            [JsonProperty("classes")]
            public IEnumerable<CharacterClassInfo> Classes { get; private set; }
        }
        
        private class RaceData
        {
            [JsonProperty("races")]
            public IEnumerable<CharacterRaceInfo> Races { get; private set; }
        }

        private class GuildPerkData
        {
            [JsonProperty("perks")]
            public IEnumerable<GuildPerk> Perks { get; private set; }
        }

        private class GuildRewardData
        {
            [JsonProperty("rewards")]
            public IEnumerable<GuildReward> Rewards { get; private set; }
        }
        
        private class RealmStatusData
        {
            [JsonProperty("realms")]
            public IEnumerable<RealmStatus> Realms { get; private set; }
        }
        #endregion

        public ArenaTeam GetArenaTeam(string realmSlug, int teamSize, string teamName, Region? region = null, Locale? locale = null)
        {
            if (string.IsNullOrWhiteSpace(realmSlug))
                throw new ArgumentNullException("realmSlug");
            else if (string.IsNullOrWhiteSpace(teamName))
                throw new ArgumentNullException("teamName");

            return this.Get<ArenaTeam>(string.Format("arena/{0}/{1}v{1}/{2}", realmSlug, teamSize, teamName), region: region, locale: locale);
        }

        public Auctions GetAuctions(string realmSlug)
        {
            if (string.IsNullOrWhiteSpace(realmSlug))
                throw new ArgumentNullException("realmSlug");

            AuctionMetaData metaData = Get<AuctionMetaData>(string.Format("auction/data/{0}", realmSlug));
            AuctionData auctionData = Get<AuctionData>(fullUrl: metaData.Files.First().Url);
            return new Auctions(auctionData.Alliance.Auctions, auctionData.Horde.Auctions, auctionData.Neutral.Auctions);
        }

        public Character GetCharacter(string name, string realm, CharacterFields fields = CharacterFields.None, Region? region = null, Locale? locale = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");
            if (string.IsNullOrWhiteSpace(realm))
                throw new ArgumentNullException("realm");

            return this.Get<Character>(string.Format("character/{0}/{1}", realm, name), fields: fields, region: region, locale: locale);
        }

        public IEnumerable<CharacterClassInfo> GetClasses(Region? region = null, Locale? locale = null)
        {
            return this.Get<ClassData>("data/character/classes", region: region, locale: locale).Classes;
        }

        public IEnumerable<GuildPerk> GetGuildPerks(Region? region = null, Locale? locale = null)
        {
            return this.Get<GuildPerkData>("data/guild/perks", region: region, locale: locale).Perks;
        }

        public IEnumerable<GuildReward> GetGuildRewards(Region? region = null, Locale? locale = null)
        {
            return this.Get<GuildRewardData>("data/guild/rewards", region: region, locale: locale).Rewards;
        }

        public Item GetItem(int id, Region? region = null, Locale? locale = null)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException("id");

            return this.Get<Item>(string.Format("item/{0}", id), region: region, locale: locale);
        }

        public IEnumerable<RealmStatus> GetRealmStatuses(params string[] realms)
        {
            return this.Get<RealmStatusData>("realm/status", new Parameters { { "realms", string.Join(",", realms) } }).Realms;
        }

        public Guild GetGuild(string name, string realm, GuildFields fields = GuildFields.None, Region? region = null, Locale? locale = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException("name");
            if (string.IsNullOrWhiteSpace(realm))
                throw new ArgumentNullException("realm");

            return this.Get<Guild>(string.Format("guild/{0}/{1}", realm, name), fields: fields, region: region, locale: locale);
        }

        public Quest GetQuest(int id, Region? region = null, Locale? locale = null)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException("id");

            return this.Get<Quest>(string.Format("quest/{0}", id), region: region, locale: locale);
        }

        public IEnumerable<CharacterRaceInfo> GetRaces(Region? region = null, Locale? locale = null)
        {
            return this.Get<RaceData>("data/character/races", region: region, locale: locale).Races;
        }

        public Recipe GetRecipe(int id, Region? region = null, Locale? locale = null)
        {
            if (id < 1)
                throw new ArgumentOutOfRangeException("id");

            return this.Get<Recipe>(string.Format("recipe/{0}", id), region: region, locale: locale);
        }
    }

    [Flags]
    public enum CharacterFields
    {
        None = 0x0,

        Guild = 0x1,
        Stats = 0x2,
        Talents = 0x4,
        Items = 0x8,
        Reputation = 0x10,
        Titles = 0x20,
        Professions = 0x40,
        Appearance = 0x80,
        Companions = 0x100,
        Mounts = 0x200,
        Pets = 0x400,
        Achievements = 0x800,
        Progression = 0x1000,
        Quests = 0x2000,

        All = 0x7FFFFFFF,
    }

    [Flags]
    public enum GuildFields
    {
        None = 0x0,
        Members = 0x1,
        Achievements = 0x2,

        All = 0x7FFFFFFF
    }
}