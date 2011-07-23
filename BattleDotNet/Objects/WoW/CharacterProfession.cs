using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterProfessions
    {
        [JsonProperty("primary")]
        public IEnumerable<CharacterProfession> Primary { get; private set; }

        [JsonProperty("secondary")]
        public IEnumerable<CharacterProfession> Secondary { get; private set; }
    }

    public class CharacterProfession
    {
        [JsonProperty("id")]
        public int ID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("iconName")]
        public string IconName { get; private set; }

        [JsonProperty("rank")]
        public int Rank { get; private set; }

        [JsonProperty("max")]
        public int MaxRank { get; private set; }

        public float PercentComplete
        {
            get
            {
                if (MaxRank == 0)
                    return 0F;

                return ((float)Rank / MaxRank) * 100;
            }
        }

        [JsonProperty("recipes")]
        public IEnumerable<int> RecipeIDs { get; private set; }
    }
}
