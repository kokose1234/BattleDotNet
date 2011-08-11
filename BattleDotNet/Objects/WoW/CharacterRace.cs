using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using BattleDotNet.Objects.WoW;

namespace BattleDotNet.Objects.WoW
{
    public class Race
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("mask")]
        public int Mask { get; private set; }

        [JsonProperty("side")]
        public Faction Side { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }
    }
}
