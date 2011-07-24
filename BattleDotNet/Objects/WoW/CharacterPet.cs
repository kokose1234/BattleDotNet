using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterPet
    {
        [JsonProperty("creature")]
        public int CreatureID { get; private set; }

        [JsonProperty("selected")]
        public bool IsSelected { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("slot")]
        public int SlotIndex { get; private set; }
    }
}
