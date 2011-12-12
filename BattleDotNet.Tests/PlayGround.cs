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
            foreach (var x in client.GetClasses(locale: Locale.es_MX))
            {
                Console.WriteLine(x.Name);
            }
        }
    }
}