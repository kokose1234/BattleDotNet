using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class GuildPerk
    {
        [JsonProperty("guildLevel")]
        public int GuildLevel { get; private set; }

        [JsonProperty("spell")]
        public GuildPerkSpell Details { get; private set; }
    }

    public class GuildPerkSpell
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("description")]
        public string Description { get; private set; }
    }
}
