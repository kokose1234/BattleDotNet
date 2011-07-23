using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterTalents
    {
        [JsonProperty("build")]
        public string Build { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("selected")]
        public bool IsSelected { get; private set; }

        [JsonProperty("trees")]
        public IEnumerable<CharacterTalentTree> Trees { get; private set; }
    }

    public class CharacterTalentTree
    {
        [JsonProperty("points")]
        public string Build { get; private set; }

        [JsonProperty("total")]
        public int Points { get; private set; }
    }

    public class CharacterTalentGlyphs
    {
        [JsonProperty("prime")]
        public IEnumerable<CharacterTalentGlyph> Prime { get; private set; }

        [JsonProperty("major")]
        public IEnumerable<CharacterTalentGlyph> Major { get; private set; }

        [JsonProperty("minor")]
        public IEnumerable<CharacterTalentGlyph> Minor { get; private set; }
    }

    public class CharacterTalentGlyph
    {
        [JsonProperty("glyph")]
        public int Glyph { get; private set; }

        [JsonProperty("icon")]
        public string IconName { get; private set; }

        [JsonProperty("item")]
        public int ItemID { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }
    }
}
