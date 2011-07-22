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
            dynamic client = new DynamicClient("wow");
            dynamic x = client.Get("realm/status", realms: string.Join(",", new[] { "Shattered-Hand", "Lightbringer" }));

            Console.WriteLine(((IEnumerable<dynamic>)x.realms).Count());
        }
    }
}
