using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace BattleDotNet.Objects.WoW
{
    public struct CharacterClass
    {
        public int Id { get; private set; }

        public int Mask { get; private set; }

        public CharacterClassPowerType PowerType { get; private set; }

        public string Name { get; private set; }

        private CharacterClass(int id, int mask, CharacterClassPowerType powerType, string name)
            : this()
        {
            Id = id;
            Mask = mask;
            PowerType = powerType;
            Name = name;
        }

        public bool Equals(CharacterClass characterClass)
        {
            return this == characterClass;
        }

        public override bool Equals(object obj)
        {
            if (obj is CharacterClass)
            {
                return this == ((CharacterClass)obj);
            }

            return false;
        }


        #region Static Class Properties
        public static CharacterClass Hunter
        {
            get
            {
                return new CharacterClass(3, 4, CharacterClassPowerType.Focus, "Hunter");
            }
        }

        public static CharacterClass Warrior
        {
            get
            {
                return new CharacterClass(1, 1, CharacterClassPowerType.Rage, "Warrior");
            }
        }

        public static CharacterClass Priest
        {
            get
            {
                return new CharacterClass(5, 16, CharacterClassPowerType.Mana, "Priest");
            }
        }

        public static CharacterClass Warlock
        {
            get
            {
                return new CharacterClass(9, 256, CharacterClassPowerType.Mana, "Warlock");
            }
        }

        public static CharacterClass Shaman
        {
            get
            {
                return new CharacterClass(7, 64, CharacterClassPowerType.Mana, "Shaman");
            }
        }

        public static CharacterClass Paladin
        {
            get
            {
                return new CharacterClass(2, 2, CharacterClassPowerType.Mana, "Paladin");
            }
        }


        public static CharacterClass Rogue
        {
            get
            {
                return new CharacterClass(4, 8, CharacterClassPowerType.Energy, "Rogue");
            }
        }

        public static CharacterClass DeathKnight
        {
            get
            {
                return new CharacterClass(6, 32, CharacterClassPowerType.RunicPower, "Death Knight");
            }
        }

        public static CharacterClass Druid
        {
            get
            {
                return new CharacterClass(1, 1024, CharacterClassPowerType.Mana, "Druid");
            }
        }

        public static CharacterClass Mage
        {
            get
            {
                return new CharacterClass(8, 128, CharacterClassPowerType.Mana, "Mage");
            }
        }
        #endregion

        public static bool Equals(CharacterClass c1, CharacterClass c2)
        {
            return c1 == c2;
        }

        #region Operators
        public static bool operator ==(CharacterClass c1, CharacterClass c2)
        {
            return c1.Id == c2.Id && c1.Mask == c2.Mask && 
                c1.PowerType == c2.PowerType && c1.Name == c2.Name;
        }

        public static bool operator !=(CharacterClass c1, CharacterClass c2)
        {
            return !(c1 == c2);
        }
        #endregion
    }

    public enum CharacterClassPowerType
    {
        Energy,
        Focus,
        Mana,
        Rage,
        RunicPower
    }
}
