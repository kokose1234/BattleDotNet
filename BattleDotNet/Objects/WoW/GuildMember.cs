using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    // This class isn't defined in the API, but matches the format of the object in the members collection
    public class GuildMember
    {
        [JsonProperty("character")]
        public MetaCharacter Character { get; private set; }

        [JsonProperty("rank")]
        public int Rank { get; private set; }
    }
}
