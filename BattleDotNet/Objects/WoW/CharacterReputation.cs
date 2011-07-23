using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterReputation
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("value")]
        public int Current { get; private set; }

        [JsonProperty("max")]
        public int Max { get; private set; }

        [JsonProperty("standing")]
        public ReputationStanding Standing { get; private set; }

        /// <summary>
        /// Gets a value that indicates the percentage complete for this reputation (0-100)
        /// </summary>
        public float PercentComplete
        {
            get
            {
                if (Max == 0)
                    return 0F;

                return ((float)Current / Max) * 100;
            }
        }
    }

    public enum ReputationStanding
    {
        Hated = 0,
        Hostile = 1,
        Unfriendly = 2,
        Neutural = 3,
        Friendly = 4,
        Honored = 5,
        Revered = 6,
        Exalted = 7,
    }
}