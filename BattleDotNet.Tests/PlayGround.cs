using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace BattleDotNet.Tests
{
    public class PlayGround
    {
        [Fact]
        public void Test()
        {
            WoWClient client = new WoWClient(region: ClientRegion.KR);
            Console.WriteLine(client.GetRealmStatuses().Count());
        }
    }
}
