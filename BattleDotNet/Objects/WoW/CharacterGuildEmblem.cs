using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterGuildEmblem
    {
        [JsonProperty("backgroundColor")]
        public string BackgroundColor { get; private set; }

        [JsonProperty("borderColor")]
        public string BorderColor { get; private set; }

        [JsonProperty("border")]
        public int BorderID { get; private set; }

        [JsonProperty("iconColor")]
        public string IconColor { get; private set; }

        [JsonProperty("icon")]
        public int IconID { get; private set; }
    }
}
