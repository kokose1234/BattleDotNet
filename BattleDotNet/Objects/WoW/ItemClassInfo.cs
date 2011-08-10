using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public struct ItemClassInfo
    {
		[JsonProperty("class")]
		public int Class;

		[JsonProperty("name")]
		public string Name;

        //public ItemClassInfo() { }

        public ItemClassInfo(int classId, string name)
        {
            Class = classId;
            Name = name;
        }
    }
}
