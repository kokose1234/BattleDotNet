using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterAppearance
    {
        [JsonProperty("showCloak")]
        public bool CloakShown { get; private set; }

        [JsonProperty("faceVariation")]
        public int FaceVariation { get; private set; }

        [JsonProperty("featureVariation")]
        public int FeatureVariation { get; private set; }

        [JsonProperty("hairColor")]
        public int HairColor { get; private set; }

        [JsonProperty("hairVariation")]
        public int HairVariation { get; private set; }

        [JsonProperty("showHelm")]
        public bool HelmShown { get; private set; }

        [JsonProperty("skinColor")]
        public int SkinColor { get; private set; }
    }
}
