using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class Character
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("level")]
        public int Level { get; private set; }
    }
}
