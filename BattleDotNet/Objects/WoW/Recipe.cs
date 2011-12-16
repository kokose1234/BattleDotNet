using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class Recipe
    {
        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("profession")]
        public string Profession { get; private set; }
    }
}
