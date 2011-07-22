using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BattleDotNet.Objects.WoW;
using Newtonsoft.Json;

namespace BattleDotNet
{
    public class WoWClient : Client
    {
        public WoWClient(ClientRegion? region = null, string publicKey = null, string signature = null)
            : base("wow", region, publicKey, signature)
        {
        }

        #region Private Types
        private class RealmStatusData
        {
            [JsonProperty("realms")]
            public IEnumerable<RealmStatus> Realms { get; private set; }
        }
        #endregion

        public IEnumerable<RealmStatus> GetRealmStatuses(params string[] realms)
        {
            return this.Get<RealmStatusData>("realm/status", new Parameters { { "realms", string.Join(",", realms) } }).Realms;
        }
    }
}