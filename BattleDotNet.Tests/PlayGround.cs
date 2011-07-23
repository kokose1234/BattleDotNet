using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Collections;

namespace BattleDotNet.Tests
{
    public class PlayGround
    {
        [Fact]
        public void Test()
        {
            var client = new WoWClient();
            foreach (var rep in client.GetCharacter("xtek", "shattered-hand", fields: CharacterFields.Reputation).Reputation)
            {
                Console.WriteLine(rep.Name + ": " + rep.Standing + "(" + rep.PercentComplete + ")");
            }
        }
    }
}