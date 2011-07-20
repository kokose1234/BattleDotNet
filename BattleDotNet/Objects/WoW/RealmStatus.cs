using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet.Objects.WoW
{
    public class RealmStatus
    {
        public bool HasQueue { get; private set; }

        public RealmStatusType Type { get; private set; }
    }

    public enum RealmStatusType
    {
        PvE,
        PvP,
        RP,
        RPPvP
    }
}