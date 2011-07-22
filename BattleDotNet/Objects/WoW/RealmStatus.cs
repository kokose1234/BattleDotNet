using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class RealmStatus
    {
        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("status")]
        public bool IsUp { get; private set; }

        [JsonProperty("queue")]
        public bool HasQueue { get; private set; }

        [JsonProperty("type")]
        public RealmStatusType Type { get; private set; }

        [JsonProperty("population")]
        public PopulationType Population { get; private set; }

        [JsonProperty("slug")]
        public string Slug { get; private set; }
    }

    public enum RealmStatusType
    {
        PvE,
        PvP,
        RP,
        RPPvP
    }

    public enum PopulationType
    {
        Low,
        Medium,
        High
    }
}