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
            foreach (var x in client.GetCharacter("xtek", "shattered-hand", fields: CharacterFields.Professions).Professions.Secondary)
            {
                Console.WriteLine("{0} {1} {2}", x.Name, x.Rank, x.PercentComplete);
            }
        }
    }
}