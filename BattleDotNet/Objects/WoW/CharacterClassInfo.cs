using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public struct CharacterClassInfo
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("mask")]
        public int Mask { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("powerType")]
        public string PowerType { get; private set; }
    }

    public enum CharacterClassPowerType // TODO: get a better name
    {
        Energy,
        Focus,
        Mana,
        Rage,
        RunicPower
    }
}
