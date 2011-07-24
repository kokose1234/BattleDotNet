using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet.Objects.WoW
{
    public class GuildCompletedAchievement
    {
        public int Id { get; internal set; }
        public DateTime DateCompleted { get; internal set; }
    }
}
