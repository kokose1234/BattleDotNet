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
            dynamic x = client.Get("realm/status", realms: new[] { "test1", "test2" });

            Console.WriteLine(((IEnumerable<dynamic>)x.realms).First().name);
        }
    }
}
