using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.IO;

namespace BattleDotNet
{
    public class RequestManager
    {
        public RequestManager(string publicKey = null, string signature = null)
        {
            if (string.IsNullOrWhiteSpace(publicKey) && !string.IsNullOrWhiteSpace(signature) ||
                !string.IsNullOrWhiteSpace(publicKey) && string.IsNullOrWhiteSpace(signature))
            {
                throw new InvalidOperationException("Both Public Key and Signature need to be null or both specified.");
            }

            _publicKey = publicKey;
            _signature = signature;

            if (!string.IsNullOrWhiteSpace(_publicKey))
                _bnetAuth = string.Format("BNET {0}:{1}", _publicKey, _signature);
        }

        private readonly string _publicKey;
        public string PublicKey
        {
            get { return _publicKey; }
        }

        private readonly string _signature;
        public string Signature
        {
            get { return _signature; }
        }

        private readonly string _bnetAuth;
        public string BNetAuth
        {
            get { return _bnetAuth; }
        }

        public string GetContent(string url)
        {
            HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
            
            // Use GZip/Delfate when possible
            webRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;
            
            // This will help with speed by keeping the internal connection
            // pool on a per-thread basis
            webRequest.ConnectionGroupName = Thread.CurrentThread.ManagedThreadId.ToString();

            // Will help with speed by not having to check for automatic settings
            webRequest.Proxy = null;

            // Give some information
            webRequest.UserAgent = "BattleDotNet C# Library | http://github.com/ChadMoran/BattleDotNet";

            // Add application authorization
            if (!string.IsNullOrWhiteSpace(BNetAuth))
                webRequest.Headers.Add("Authorization", BNetAuth);

            using (HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse)
            {
                using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}