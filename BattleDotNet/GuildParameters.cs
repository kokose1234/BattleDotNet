using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet
{
    public class GuildParameters : Parameters
    {
        public GuildParameters(GuildRequestFields parms)
        {
            if (parms != GuildRequestFields.None)
            {
                this.Add("fields", parms.ToString().ToLower().Replace(" ", string.Empty));
            }
        }
    }

    [Flags]
    public enum GuildRequestFields
    {
        None = 0x0,
        Members,
        Achievements
    }
}
