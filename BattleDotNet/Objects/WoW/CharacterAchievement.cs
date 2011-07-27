using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet.Objects.WoW
{
    public class CharacterAchievement
    {
        public CharacterAchievement(int id, DateTime dateCompleted)
        {
            ID = id;
            DateCompleted = dateCompleted;
        }

        public int ID { get; private set; }
        public DateTime DateCompleted { get; private set; }
    }
}
