using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class Quest
    {
        [JsonProperty("category")]
        public string Category { get; private set; }

        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }

        [JsonProperty("reaLevel")]
        public int RequiredLevel { get; private set; }

        [JsonProperty("suggestedPartyMembers")]
        public int SuggestedPartyMembers { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }
    }
}
