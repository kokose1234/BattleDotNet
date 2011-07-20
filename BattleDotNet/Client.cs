using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleDotNet
{
    public abstract class Client
    {
        public Client(string publicKey, string signature)
        {
            _requestManager = new RequestManager(publicKey, signature);
        }

        private readonly RequestManager _requestManager;
        protected RequestManager RequestManager
        {
            get { return _requestManager; }
        }
    }

    public enum ClientRegion
    {
        /// <summary>
        /// United States
        /// </summary>
        US,
        /// <summary>
        /// Europe
        /// </summary>
        EU,
        /// <summary>
        /// Korea
        /// </summary>
        KR,
        /// <summary>
        /// Taiwan
        /// </summary>
        TW
    }
}