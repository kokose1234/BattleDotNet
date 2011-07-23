using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterTitle
    {
        internal void SetCharacterName(string characterName)
        {
            FormattedName = Name.Replace("%s", characterName);
        }

        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        public string FormattedName { get; private set; }
    }
}