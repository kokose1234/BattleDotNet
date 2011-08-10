using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public struct ItemSubClassInfo
    {
		[JsonProperty("subclassId")]
		public int SubClassID;

		[JsonProperty("name")]
		public string Name;

        //public ItemSubClassInfo() { }

        public ItemSubClassInfo(int classId, string name)
        {
            SubClassID = classId;
            Name = name;
        }
    }
}
