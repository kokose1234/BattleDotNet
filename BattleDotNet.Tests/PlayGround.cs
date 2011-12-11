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
            var auctions = client.GetAuctions("shattered-hand").Horde;
            foreach (var auction in auctions.Where(a => a.OwnerName.Contains("Xtek")))
                Console.WriteLine(auction.OwnerName + " is selling " + client.GetItem(auction.ItemID).Name + " x" + auction.Quantity + " for " + auction.Buyout);
        }
    }
}