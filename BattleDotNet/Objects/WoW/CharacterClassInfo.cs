using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public struct CharacterClassInfo
    {
        public int Id { get; private set; }

        public int Mask { get; private set; }

        public CharacterClassPowerType PowerType { get; private set; } 

        public string Name { get; private set; }

        private CharacterClassInfo(int id, int mask, CharacterClassPowerType powerType, string name)
            : this()
        {
            Id = id;
            Mask = mask;
            PowerType = powerType;
            Name = name;
        }

        #region Public Overrides
        public bool Equals(CharacterClassInfo characterClass)
        {
            return this == characterClass;
        }

        public override bool Equals(object obj)
        {
            if (obj is CharacterClassInfo)
            {
                return this == ((CharacterClassInfo)obj);
            }

            return false;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Mask.GetHashCode() ^ PowerType.GetHashCode() ^ Name.GetHashCode(); 
        }

        public override string ToString()
        {
            return Name;
        }
        #endregion

        #region Static Class Properties
        public static CharacterClassInfo Hunter
        {
            get
            {
                return new CharacterClassInfo(3, 4, CharacterClassPowerType.Focus, "Hunter");
            }
        }

        public static CharacterClassInfo Warrior
        {
            get
            {
                return new CharacterClassInfo(1, 1, CharacterClassPowerType.Rage, "Warrior");
            }
        }

        public static CharacterClassInfo Priest
        {
            get
            {
                return new CharacterClassInfo(5, 16, CharacterClassPowerType.Mana, "Priest");
            }
        }

        public static CharacterClassInfo Warlock
        {
            get
            {
                return new CharacterClassInfo(9, 256, CharacterClassPowerType.Mana, "Warlock");
            }
        }

        public static CharacterClassInfo Shaman
        {
            get
            {
                return new CharacterClassInfo(7, 64, CharacterClassPowerType.Mana, "Shaman");
            }
        }

        public static CharacterClassInfo Paladin
        {
            get
            {
                return new CharacterClassInfo(2, 2, CharacterClassPowerType.Mana, "Paladin");
            }
        }


        public static CharacterClassInfo Rogue
        {
            get
            {
                return new CharacterClassInfo(4, 8, CharacterClassPowerType.Energy, "Rogue");
            }
        }

        public static CharacterClassInfo DeathKnight
        {
            get
            {
                return new CharacterClassInfo(6, 32, CharacterClassPowerType.RunicPower, "Death Knight");
            }
        }

        public static CharacterClassInfo Druid
        {
            get
            {
                return new CharacterClassInfo(1, 1024, CharacterClassPowerType.Mana, "Druid");
            }
        }

        public static CharacterClassInfo Mage
        {
            get
            {
                return new CharacterClassInfo(8, 128, CharacterClassPowerType.Mana, "Mage");
            }
        }
        #endregion

        public static bool Equals(CharacterClassInfo c1, CharacterClassInfo c2)
        {
            return c1 == c2;
        }

        #region Operators
        public static bool operator ==(CharacterClassInfo c1, CharacterClassInfo c2)
        {
            return c1.Id == c2.Id && c1.Mask == c2.Mask && 
                c1.PowerType == c2.PowerType && c1.Name == c2.Name;
        }

        public static bool operator !=(CharacterClassInfo c1, CharacterClassInfo c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }

    public enum CharacterClassPowerType // TODO: get a better name
    {
        Energy,
        Focus,
        Mana,
        Rage,
        RunicPower
    }
}
