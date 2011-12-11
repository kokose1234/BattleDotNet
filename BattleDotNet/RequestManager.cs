using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using System.Security.Cryptography;
using BattleDotNet.Extensions;
using BattleDotNet.Performance;
using BattleDotNet.Utilities;

namespace BattleDotNet
{
    public class RequestManager
    {
        public RequestManager(string publicKey = null, string privateKey = null)
        {
            if (publicKey.IsNullOrWhiteSpace() && !privateKey.IsNullOrWhiteSpace())
                throw new ArgumentException("Cannot specify public key without private key.");
            else if (privateKey.IsNullOrWhiteSpace() && !publicKey.IsNullOrWhiteSpace())
                throw new ArgumentNullException("Cannot specify private key without public key.");

            _publicKey = publicKey;

            if (!privateKey.IsNullOrWhiteSpace())
                _privateKey = Encoding.UTF8.GetBytes(privateKey);
        }

        private readonly byte[] _privateKey;
        public byte[] PrivateKey
        {
            get { return _privateKey; }
        }

        private readonly string _publicKey;
        public string PublicKey
        {
            get { return _publicKey; }
        }

		protected DateTime CurrentUTC
		{
			get
			{
				return DateTime.UtcNow.AddMilliseconds(BattleNetTime.ServerTimeDiff);
			}
		}

        public string GetContent(string url, DateTime? ifModifiedSince = null)
        {
            if (url.IsNullOrWhiteSpace())
                throw new ArgumentNullException("url");

            HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;

            // Use GZip/Delfate when possible
            webRequest.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            // This will help with speed by keeping the internal connection
            // pool on a per-thread basis
            webRequest.ConnectionGroupName = Thread.CurrentThread.ManagedThreadId.ToString();

            // TODO : Allow this to be set
            // Will help with speed by not having to check for automatic settings
            webRequest.Proxy = null;

            // Give some information
            webRequest.UserAgent = "BattleDotNet C# Library | http://git.io/bnet";

            SetAuthentication(webRequest);

            if (ifModifiedSince.HasValue)
                webRequest.IfModifiedSince = ifModifiedSince.Value;

            try
            {
                using (DebugTimer.Start(string.Format("Requesting {0}", url)))
                {
                    using (HttpWebResponse webResponse = webRequest.GetResponse() as HttpWebResponse)
                    {
                        using (StreamReader reader = new StreamReader(webResponse.GetResponseStream()))
                        {
                            string result = reader.ReadToEnd();
                            return result;
                        }
                    }
                }
            }
            catch (WebException ex)
            {
                HttpWebResponse response = null;
                if (ex.Status == WebExceptionStatus.ProtocolError && (response = ex.Response as HttpWebResponse) != null)
                {
                    if (response.StatusCode == HttpStatusCode.NotFound)
                        return null;
                }

                throw;
            }
        }

        protected void SetAuthentication(HttpWebRequest request)
        {
            if (string.IsNullOrWhiteSpace(PublicKey))
                return;

            string path = request.RequestUri.AbsolutePath;
            string verb = request.Method;
			DateTime current = this.CurrentUTC;
            string date = current.ToString("r");

            string valueToHash = string.Format("{0}\n{1}\n{2}\n", verb, date, path);

            byte[] buffer = Encoding.UTF8.GetBytes(valueToHash);
            HMACSHA1 hmac = new HMACSHA1(PrivateKey);
            byte[] hash = hmac.ComputeHash(buffer);
            string signature = Convert.ToBase64String(hash);

            request.Headers["Authorization"] = string.Format("BNET {0}:{1}", PublicKey, signature);
			request.Date = current;
        }

        public T Get<T>(string url, DateTime? ifModifiedSince = null)
        {
            if (string.IsNullOrWhiteSpace(url))
                throw new ArgumentNullException("url");

            string content = GetContent(url, ifModifiedSince: ifModifiedSince);

            if (content.IsNullOrWhiteSpace())
                return default(T);

            using (DebugTimer.Start(string.Format("Deserializing")))
            {
                return JsonConvert.DeserializeObject<T>(content);
            }
        }
    }
}