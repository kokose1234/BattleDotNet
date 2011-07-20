using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet
{
    public class WoWClient : Client
    {
        public WoWClient(string publicKey = null, string signature = null)
            : base(publicKey, signature)
        {
        }
    }
}